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

        private readonly QLNSDataContext context = new QLNSDataContext();
        private bool xuLyThem = false;
        private int id;
        public NghiPhep()
        {
            InitializeComponent();
        }
        private void NghiPhep_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            LoadData();
            dgvNghiPhep.RowPrePaint += dgvNghiPhep_RowPrePaint;
        }

        // ================= LOAD =================
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
                           // Đảm bảo np.TrangThai không bị null, nếu null thì hiện "Chờ duyệt"
                           TrangThai = np.TrangThai ?? "Chờ duyệt"
                       };

            dgvNghiPhep.DataSource = data.ToList();
        }
        // ================= THÊM =================
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            cbNhanVien.SelectedIndex = -1;
            txtLyDo.Clear();

            // Reset trạng thái hiển thị
            txtTrangThai.Text = "Chờ duyệt";
        }
        // ================= DUYỆT =================
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
        // ================= TỪ CHỐI =================
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
        // ================= XÓA =================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var np = context.NghiPhep.FirstOrDefault(x => x.ID == id);

            if (np == null) return;

            if (np.TrangThai == "Đã duyệt")
            {
                MessageBox.Show("Không xóa đơn đã duyệt!");
                return;
            }
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa dự án này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;
            context.NghiPhep.Remove(np);
            context.SaveChanges();

            LoadData();
        }
        // ================= TÌM KIẾM =================
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
                           // Đảm bảo np.TrangThai không bị null, nếu null thì hiện "Chờ duyệt"
                           TrangThai = np.TrangThai ?? "Chờ duyệt"
                       };

            dgvNghiPhep.DataSource = data.ToList();
        }
        // ================= TÔ MÀU =================
        private void dgvNghiPhep_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvNghiPhep.Rows[e.RowIndex];

            // Kiểm tra cột TrangThai có tồn tại và có giá trị không
            if (row.Cells["TrangThai"].Value == null) return;

            string tt = row.Cells["TrangThai"].Value.ToString();

            // Reset lại màu mặc định trước khi tô màu mới
            row.DefaultCellStyle.ForeColor = Color.Black;

            if (tt == "Đã duyệt")
                row.DefaultCellStyle.BackColor = Color.LightGreen;
            else if (tt == "Từ chối")
                row.DefaultCellStyle.BackColor = Color.LightCoral;
            else
                row.DefaultCellStyle.BackColor = Color.LightYellow;
        }
        // ================= CLICK GRID =================
        private void dgvNghiPhep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvNghiPhep.CurrentRow == null) return;

            var row = dgvNghiPhep.Rows[e.RowIndex];

            // ... (Giữ nguyên phần ID và ComboBox Nhân viên) ...
            id = Convert.ToInt32(row.Cells["MaNghiPhep"].Value);
            cbNhanVien.SelectedValue = Convert.ToInt32(row.Cells["MaNV"].Value);

            // Cập nhật trạng thái vào TextBox
            txtTrangThai.Text = row.Cells["TrangThai"].Value?.ToString() ?? "Chờ duyệt";

            dtNgayBD.Value = Convert.ToDateTime(row.Cells["TuNgay"].Value);
            dtNgayKT.Value = Convert.ToDateTime(row.Cells["DenNgay"].Value);
            txtLyDo.Text = row.Cells["LyDo"].Value?.ToString() ?? "";

            xuLyThem = false;
        }
        // ================= LƯU =================
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
                // THÊM
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
                // SỬA
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
    }
}
