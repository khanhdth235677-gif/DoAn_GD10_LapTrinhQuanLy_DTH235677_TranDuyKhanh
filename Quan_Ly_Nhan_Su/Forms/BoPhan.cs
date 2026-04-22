using Quan_Ly_Nhan_Su.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Guna.UI2.WinForms;

namespace Quan_Ly_Nhan_Su.Forms
{
    public partial class BoPhan : Form
    {
        #region ===== Khai báo biến =====
        QLNSDataContext context = new QLNSDataContext();
        int id = 0;
        bool xuLyThem = false;
        #endregion

        #region ===== Khởi tạo =====
        public BoPhan()
        {
            InitializeComponent();
        }
        #endregion

        #region ===== Load dữ liệu =====
        void LoadBoPhan()
        {
            dgvBoPhan.AutoGenerateColumns = false;

            var ds = from pb in context.PhongBan
                     select new
                     {
                         pb.ID,
                         pb.TenPhongBan,
                         HoTen = string.Join(", ",
                                context.NhanVien
                                .Where(nv => nv.PhongBanID == pb.ID)
                                .Select(nv => nv.HoTen)),
                         pb.MoTa
                     };

            dgvBoPhan.DataSource = ds.ToList();
        }

        void LoadComboBoPhan()
        {
            cbTenPhongBan.DataSource = context.PhongBan.ToList();
            cbTenPhongBan.DisplayMember = "TenPhongBan";
            cbTenPhongBan.ValueMember = "ID";
            cbTenPhongBan.SelectedIndex = -1;
        }
        #endregion

        #region ===== Xử lý form =====
        void ResetForm()
        {
            txtID.Clear();
            txtMoTa.Clear();
            txtHoTenNV.Clear();
            cbTenPhongBan.SelectedIndex = -1;
            dgvBoPhan.ClearSelection();
            id = 0;
        }

        private void BoPhan_Load(object sender, EventArgs e)
        {
            UIStyle.ApplyStyle(this);
            LoadBoPhan();
            LoadComboBoPhan();
            if (Session.Quyen == "Nhân viên")
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
        #endregion

        #region ===== Thêm =====
        private void btnThem_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(cbTenPhongBan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên bộ phận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbTenPhongBan.Focus();
                return;
            }

            try
            {
                // 2. Tạo đối tượng mới và gán dữ liệu
                PhongBan pb = new PhongBan();
                // Dùng .Trim() để cắt bỏ khoảng trắng thừa ở hai đầu chữ nếu có
                pb.TenPhongBan = cbTenPhongBan.Text.Trim();
                pb.MoTa = txtMoTa.Text.Trim();

                // 3. Lưu vào Database
                context.PhongBan.Add(pb);
                context.SaveChanges();

                // 4. THÔNG BÁO THÊM THÀNH CÔNG
                MessageBox.Show("Thêm bộ phận mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5. Cập nhật lại giao diện
                LoadBoPhan();
                LoadComboBoPhan();
                ResetForm();
            }
            catch (Exception ex)
            {
                // Bắt lỗi an toàn nếu có sự cố xảy ra
                MessageBox.Show("Có lỗi xảy ra khi thêm bộ phận: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region ===== Xóa =====
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Vui lòng chọn bộ phận cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Cảnh báo nguy hiểm (Lớp bảo vệ thứ nhất)
            DialogResult canhBao = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa bộ phận này không?\n\nLƯU Ý: Thao tác này sẽ XÓA TOÀN BỘ nhân viên đang thuộc bộ phận này và không thể hoàn tác!",
                "Cảnh báo xóa bộ phận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            // 2. Nếu người dùng đồng ý với cảnh báo, tiến hành gọi Form đăng nhập (Lớp bảo vệ thứ hai)
            if (canhBao == DialogResult.Yes)
            {
                frmXacNhanXoa frm = new frmXacNhanXoa();
                frm.StartPosition = FormStartPosition.CenterParent;

                // 3. Nếu nhập đúng tài khoản và mật khẩu
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var pb = context.PhongBan.Find(id);

                        if (pb != null)
                        {
                            // Lấy danh sách nhân viên thuộc phòng ban
                            var nhanViens = context.NhanVien
                                .Where(nv => nv.PhongBanID == id)
                                .ToList();

                            // Xóa nhân viên trước
                            context.NhanVien.RemoveRange(nhanViens);

                            // Xóa phòng ban sau
                            context.PhongBan.Remove(pb);

                            // Lưu xuống database
                            context.SaveChanges();

                            // Thông báo thành công
                            MessageBox.Show("Đã xóa bộ phận và các nhân viên liên quan thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Cập nhật lại giao diện
                            LoadBoPhan();
                            ResetForm();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy bộ phận để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Bắt lỗi nếu có nhân viên đang dính dữ liệu ở bảng khác (chấm công, lương...)
                        MessageBox.Show("Không thể xóa bộ phận này vì dữ liệu đang được liên kết ở nơi khác.\nChi tiết lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            // Nếu bấm No ở cảnh báo, hoặc bấm Hủy ở màn hình nhập mật khẩu, chương trình tự động bỏ qua.
        }
        #endregion

        #region ===== Sửa =====
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Vui lòng chọn bộ phận cần sửa");
                return;
            }

            var pb = context.PhongBan.Find(id);

            if (pb != null)
            {
                pb.TenPhongBan = cbTenPhongBan.Text;
                pb.MoTa = txtMoTa.Text;

                context.SaveChanges();
            }

            LoadBoPhan();
            ResetForm();
        }
        #endregion

        #region ===== Reset =====
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadBoPhan();
        }
        #endregion

        #region ===== Tìm kiếm =====
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenPB = cbTenPhongBan.Text.Trim();

            var ds = from pb in context.PhongBan
                     where pb.TenPhongBan.Contains(tenPB)
                     select new
                     {
                         pb.ID,
                         pb.TenPhongBan,
                         HoTen = string.Join(", ",
                                context.NhanVien
                                .Where(nv => nv.PhongBanID == pb.ID)
                                .Select(nv => nv.HoTen)),
                         pb.MoTa
                     };

            dgvBoPhan.DataSource = ds.ToList();
        }
        #endregion

        #region ===== DataGridView =====
        private void dgvBoPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBoPhan.Rows[e.RowIndex];

                id = Convert.ToInt32(row.Cells["ID"].Value);

                txtID.Text = row.Cells["ID"].Value.ToString();
                cbTenPhongBan.Text = row.Cells["TenPhongBan"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();
                txtHoTenNV.Text = row.Cells["HoTen"].Value?.ToString();
            }
        }
        #endregion

        #region ===== Xuất Excel =====
        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất danh sách phòng ban";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "PhongBan_" + DateTime.Now.ToString("dd_MM_yyyy");

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();

                    table.Columns.Add("MaBoPhan");
                    table.Columns.Add("TenPhongBan");
                    table.Columns.Add("HoTenNhanVien");
                    table.Columns.Add("MoTa");

                    var dsPhongBan = context.PhongBan
                                            .Include(pb => pb.NhanVien)
                                            .ToList();

                    foreach (var pb in dsPhongBan)
                    {
                        string danhSachNV = string.Join(", ",
                            pb.NhanVien.Select(nv => nv.HoTen));

                        table.Rows.Add(
                            pb.ID,
                            pb.TenPhongBan,
                            danhSachNV,
                            pb.MoTa
                        );
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "PhongBan");

                        sheet.Row(1).Style.Font.Bold = true;
                        sheet.Columns().AdjustToContents();

                        wb.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Xuất Excel thành công!",
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region ===== Sự kiện khác =====
        private void label3_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}