using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using Quan_Ly_Nhan_Su.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Nhan_Su.Forms
{
    public partial class NghiPhep : Form
    {
        #region ===== Khai báo biến =====
        private readonly QLNSDataContext context = new QLNSDataContext();
        private bool xuLyThem = false;
        private int id;
        #endregion

        #region ===== Khởi tạo =====
        public NghiPhep()
        {
            InitializeComponent();
        }
        #endregion

        #region ===== Load Form =====
        private void NghiPhep_Load(object sender, EventArgs e)
        {
            UIStyle.ApplyStyle(this);
            LoadNhanVien();
            LoadData();
            dgvNghiPhep.RowPrePaint += dgvNghiPhep_RowPrePaint;
            if (Session.Quyen == "Nhân viên")
            {
                btnThem.Enabled = false;
                btnDuyet.Enabled = false;
                btnTuChoi.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;

            }
        }
        #endregion

        #region ===== Load dữ liệu =====
        void LoadNhanVien()
        {
            cbNhanVien.DataSource = context.NhanVien.ToList();
            cbNhanVien.DisplayMember = "HoTen";
            cbNhanVien.ValueMember = "ID";
        }

        void LoadData()
        {
            var data = from np in context.NghiPhep
                       join nv in context.NhanVien on np.NhanVienID equals nv.ID
                       select new
                       {
                           MaNghiPhep = np.ID,
                           MaNV = np.NhanVienID,
                           TenNhanVien = nv.HoTen,
                           TuNgay = np.TuNgay,
                           DenNgay = np.DenNgay,
                           LyDo = np.LyDo,
                           TrangThai = np.TrangThai ?? "Chờ duyệt"
                       };

            dgvNghiPhep.DataSource = data.ToList();
        }
        #endregion

        #region ===== Thêm =====
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            cbNhanVien.SelectedIndex = -1;
            txtLyDo.Clear();
            txtTrangThai.Text = "Chờ duyệt";
        }
        #endregion

        #region ===== Duyệt =====
        private void btnDuyet_Click(object sender, EventArgs e)
        {
            var np = context.NghiPhep.FirstOrDefault(x => x.ID == id);

            if (np == null) return;

            if (np.TrangThai == "Đã duyệt")
            {
                MessageBox.Show("Đã duyệt rồi!");
                return;
            }

            if (np.TrangThai == "Từ chối")
            {
                MessageBox.Show("Đã bị từ chối!");
                return;
            }

            np.TrangThai = "Đã duyệt";
            context.SaveChanges();

            LoadData();
        }
        #endregion

        #region ===== Từ chối =====
        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            var np = context.NghiPhep.FirstOrDefault(x => x.ID == id);

            if (np == null) return;

            if (np.TrangThai == "Từ chối")
            {
                MessageBox.Show("Đã từ chối!");
                return;
            }

            if (np.TrangThai == "Đã duyệt")
            {
                MessageBox.Show("Đã duyệt, không thể từ chối!");
                return;
            }

            np.TrangThai = "Từ chối";
            context.SaveChanges();

            LoadData();
        }
        #endregion

        #region ===== Xóa =====
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var np = context.NghiPhep.FirstOrDefault(x => x.ID == id);

            if (np == null)
            {
                MessageBox.Show("Không tìm thấy dữ liệu nghỉ phép cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 1. Giữ nguyên logic bảo vệ: Không cho phép xóa đơn đã duyệt
            if (np.TrangThai == "Đã duyệt")
            {
                MessageBox.Show("Không thể xóa đơn nghỉ phép đã được duyệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Gọi Form xác nhận bằng mật khẩu và tên đăng nhập
            frmXacNhanXoa frm = new frmXacNhanXoa();
            frm.StartPosition = FormStartPosition.CenterParent; // Hiển thị giữa màn hình cha

            // 3. Nếu người dùng nhập đúng tài khoản & mật khẩu (Trả về DialogResult.OK)
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Tiến hành xóa dữ liệu khỏi Database
                    context.NghiPhep.Remove(np);
                    context.SaveChanges();

                    // Thông báo thành công
                    MessageBox.Show("Xóa thông tin nghỉ phép thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại danh sách dữ liệu để cập nhật giao diện
                    LoadData();
                }
                catch (Exception ex)
                {
                    // Bắt lỗi nếu có trục trặc kết nối hoặc ràng buộc dữ liệu
                    MessageBox.Show("Lỗi trong quá trình xóa dữ liệu: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Nếu bấm Hủy hoặc nhập sai, code tự động không thực hiện lệnh xóa bên trong block IF này.
        }
        #endregion

        #region ===== Tìm kiếm =====
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var data = from np in context.NghiPhep
                       join nv in context.NhanVien on np.NhanVienID equals nv.ID
                       where
                       (cbNhanVien.SelectedValue == null || np.NhanVienID == Convert.ToInt32(cbNhanVien.SelectedValue))
                       && (string.IsNullOrEmpty(txtTrangThai.Text) || np.TrangThai == txtTrangThai.Text)
                       select new
                       {
                           MaNghiPhep = np.ID,
                           MaNV = np.NhanVienID,
                           TenNhanVien = nv.HoTen,
                           TuNgay = np.TuNgay,
                           DenNgay = np.DenNgay,
                           LyDo = np.LyDo,
                           TrangThai = np.TrangThai ?? "Chờ duyệt"
                       };

            dgvNghiPhep.DataSource = data.ToList();
        }
        #endregion

        #region ===== DataGridView =====
        private void dgvNghiPhep_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvNghiPhep.Rows[e.RowIndex];

            if (row.Cells["TrangThai"].Value == null) return;

            string tt = row.Cells["TrangThai"].Value.ToString();

            row.DefaultCellStyle.ForeColor = Color.Black;

            if (tt == "Đã duyệt")
                row.DefaultCellStyle.BackColor = Color.LightGreen;
            else if (tt == "Từ chối")
                row.DefaultCellStyle.BackColor = Color.LightCoral;
            else
                row.DefaultCellStyle.BackColor = Color.LightYellow;
        }

        private void dgvNghiPhep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvNghiPhep.CurrentRow == null) return;

            var row = dgvNghiPhep.Rows[e.RowIndex];

            id = Convert.ToInt32(row.Cells["MaNghiPhep"].Value);
            cbNhanVien.SelectedValue = Convert.ToInt32(row.Cells["MaNV"].Value);

            txtTrangThai.Text = row.Cells["TrangThai"].Value?.ToString() ?? "Chờ duyệt";

            dtNgayBD.Value = Convert.ToDateTime(row.Cells["TuNgay"].Value);
            dtNgayKT.Value = Convert.ToDateTime(row.Cells["DenNgay"].Value);
            txtLyDo.Text = row.Cells["LyDo"].Value?.ToString() ?? "";

            xuLyThem = false;
        }
        #endregion

        #region ===== Lưu =====
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dtNgayBD.Value >= dtNgayKT.Value)
            {
                MessageBox.Show("Từ ngày phải nhỏ hơn Đến ngày!");
                return;
            }

            if (cbNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Chọn nhân viên!");
                return;
            }

            if (xuLyThem)
            {
                Quan_Ly_Nhan_Su.Data.NghiPhep np = new Quan_Ly_Nhan_Su.Data.NghiPhep();

                np.NhanVienID = Convert.ToInt32(cbNhanVien.SelectedValue);
                np.TuNgay = dtNgayBD.Value;
                np.DenNgay = dtNgayKT.Value;
                np.LyDo = txtLyDo.Text;
                np.TrangThai = "Chờ duyệt";

                context.NghiPhep.Add(np);
                context.SaveChanges();
            }
            else
            {
                var np = context.NghiPhep.FirstOrDefault(x => x.ID == id);

                if (np == null) return;

                if (np.TrangThai == "Đã duyệt")
                {
                    MessageBox.Show("Không sửa được đơn đã duyệt!");
                    return;
                }

                np.NhanVienID = Convert.ToInt32(cbNhanVien.SelectedValue);
                np.TuNgay = dtNgayBD.Value;
                np.DenNgay = dtNgayKT.Value;
                np.LyDo = txtLyDo.Text;
            }

            context.SaveChanges();
            MessageBox.Show("Lưu thành công!");

            LoadData();
            xuLyThem = false;
        }
        #endregion

        #region ===== Hủy / Reset =====
        private void btnHuy_Click(object sender, EventArgs e)
        {
            cbNhanVien.SelectedIndex = -1;

            if (txtTrangThai != null)
            {
                txtTrangThai.Clear();
            }

            txtLyDo.Clear();

            dtNgayBD.Value = DateTime.Now;
            dtNgayKT.Value = DateTime.Now;

            xuLyThem = false;
            id = -1;

            LoadData();

            MessageBox.Show("Đã làm mới dữ liệu!");
        }
        #endregion

        #region ===== Xuất Excel =====
        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất danh sách nghỉ phép";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "NghiPhep_" + DateTime.Now.ToString("dd_MM_yyyy");

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var dsNghiPhep = context.NghiPhep
                        .Include(np => np.NhanVien)
                        .ToList();

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add("NghiPhep");

                        sheet.Cell(1, 1).Value = "ID";
                        sheet.Cell(1, 2).Value = "Nhân viên";
                        sheet.Cell(1, 3).Value = "Từ ngày";
                        sheet.Cell(1, 4).Value = "Đến ngày";
                        sheet.Cell(1, 5).Value = "Lý do";
                        sheet.Cell(1, 6).Value = "Trạng thái";

                        var header = sheet.Range("A1:F1");
                        header.Style.Font.Bold = true;
                        header.Style.Fill.BackgroundColor = XLColor.LightGray;
                        header.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        int row = 2;

                        foreach (var np in dsNghiPhep)
                        {
                            sheet.Cell(row, 1).Value = np.ID;
                            sheet.Cell(row, 2).Value = np.NhanVien?.HoTen;
                            sheet.Cell(row, 3).Value = np.TuNgay.ToString("dd/MM/yyyy");
                            sheet.Cell(row, 4).Value = np.DenNgay.ToString("dd/MM/yyyy");
                            sheet.Cell(row, 5).Value = np.LyDo;
                            sheet.Cell(row, 6).Value = np.TrangThai;

                            if (np.TrangThai == "Chờ duyệt")
                                sheet.Range($"C{row}:F{row}").Style.Fill.BackgroundColor = XLColor.LightYellow;
                            else if (np.TrangThai == "Đã duyệt")
                                sheet.Range($"C{row}:F{row}").Style.Fill.BackgroundColor = XLColor.LightGreen;
                            else if (np.TrangThai == "Từ chối")
                                sheet.Range($"C{row}:F{row}").Style.Fill.BackgroundColor = XLColor.LightPink;

                            row++;
                        }

                        var range = sheet.Range($"A1:F{row - 1}");
                        range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                        sheet.Columns().AdjustToContents();

                        wb.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Xuất Excel nghỉ phép thành công!",
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
    }
}