using Quan_Ly_Nhan_Su.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BangLuongModel = Quan_Ly_Nhan_Su.Data.BangLuong;
namespace Quan_Ly_Nhan_Su.Forms
{
    public partial class FormBangLuong : Form
    {
        QLNSDataContext context = new QLNSDataContext();

        bool xuLyThem = false;
        int id;
        public FormBangLuong()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BangLuong_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadNhanVien();
            LoadBangLuong();
        }
        private void LoadNhanVien()
        {
            var dsNhanVien = context.NhanVien.ToList();

            cbMaNV.DataSource = dsNhanVien;
            cbMaNV.DisplayMember = "MaNV";   // hiển thị mã nhân viên
            cbMaNV.ValueMember = "ID";       // giá trị lưu
            cbMaNV.SelectedIndex = -1;
        }
        private void LoadBangLuong()
        {
            dgvBangLuong.AutoGenerateColumns = false;

            var ds = from bl in context.BangLuong
                     join nv in context.NhanVien
                     on bl.NhanVienID equals nv.ID
                     select new
                     {
                         bl.ID,
                         MaNV = nv.ID,
                         TenNV = nv.HoTen,
                         Thang = bl.ThangNam,
                         bl.LuongCoBan,
                         bl.PhuCap,
                         bl.Thuong,
                         bl.KhauTru,
                         bl.TongLuong
                     };

            dgvBangLuong.DataSource = ds.ToList();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnTinhLuong.Enabled = !giaTri;
            btnThem.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;

            btnLuu.Enabled = giaTri;

            txtLuongCoBan.Enabled = giaTri;
            txtPhuCap.Enabled = giaTri;
            txtThuong.Enabled = giaTri;
            txtKhauTru.Enabled = giaTri;

            cbMaNV.Enabled = giaTri;
            dtThangNam.Enabled = giaTri;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            cbMaNV.SelectedIndex = -1;

            txtLuongCoBan.Clear();
            txtPhuCap.Clear();
            txtThuong.Clear();
            txtKhauTru.Clear();

            dtThangNam.Value = DateTime.Now;

            txtLuongCoBan.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvBangLuong.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                return;
            }

            xuLyThem = false;

            id = Convert.ToInt32(dgvBangLuong.CurrentRow.Cells["MaLuong"].Value);

            BatTatChucNang(true);

            cbMaNV.Enabled = true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbMaNV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!");
                return;
            }

            decimal luong;
            if (!decimal.TryParse(txtLuongCoBan.Text, out luong))
            {
                MessageBox.Show("Lương cơ bản không hợp lệ!");
                return;
            }

            decimal phucap = string.IsNullOrWhiteSpace(txtPhuCap.Text) ? 0 : decimal.Parse(txtPhuCap.Text);
            decimal thuong = string.IsNullOrWhiteSpace(txtThuong.Text) ? 0 : decimal.Parse(txtThuong.Text);
            decimal khautru = string.IsNullOrWhiteSpace(txtKhauTru.Text) ? 0 : decimal.Parse(txtKhauTru.Text);

            decimal tongLuong = luong + phucap + thuong - khautru;

            if (xuLyThem)
            {
                BangLuongModel bl = new BangLuongModel();

                bl.NhanVienID = Convert.ToInt32(cbMaNV.SelectedValue);
                bl.LuongCoBan = luong;
                bl.PhuCap = phucap;
                bl.Thuong = thuong;
                bl.KhauTru = khautru;
                bl.TongLuong = tongLuong;
                bl.ThangNam = dtThangNam.Value;

                context.BangLuong.Add(bl);
            }
            else
            {
                BangLuongModel bl = context.BangLuong.Find(id);

                if (bl != null)
                {
                    bl.NhanVienID = Convert.ToInt32(cbMaNV.SelectedValue);
                    bl.LuongCoBan = luong;
                    bl.PhuCap = phucap;
                    bl.Thuong = thuong;
                    bl.KhauTru = khautru;
                    bl.TongLuong = tongLuong;
                    bl.ThangNam = dtThangNam.Value;
                }
            }

            context.SaveChanges();

            BatTatChucNang(false);
            LoadBangLuong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvBangLuong.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            int id = Convert.ToInt32(dgvBangLuong.CurrentRow.Cells["MaLuong"].Value);

            BangLuong bl = context.BangLuong.Find(id);

            if (bl != null)
            {
                context.BangLuong.Remove(bl);
                context.SaveChanges();
            }

            LoadBangLuong();
        }
        void ResetForm()
        {
            cbMaNV.SelectedIndex = -1;
            txtLuongCoBan.Clear();
            txtPhuCap.Clear();
            txtThuong.Clear();
            txtKhauTru.Clear();
            dtThangNam.Value = DateTime.Now;
            lblTongLuong.Text = "Tổng lương: 0 VND";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadBangLuong();
            ResetForm();
        }
        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            decimal tong = 0;

            foreach (DataGridViewRow row in dgvBangLuong.Rows)
            {
                if (!row.IsNewRow && row.Cells["TongLuong"].Value != null)
                {
                    tong += Convert.ToDecimal(row.Cells["TongLuong"].Value);
                }
            }

            lblTongLuong.Text = "Tổng lương: " + tong.ToString("N0") + " VND";
        }

        private void dgvBangLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void dgvBangLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBangLuong.CurrentRow != null)
            {
                cbMaNV.Text = dgvBangLuong.CurrentRow.Cells["MaNV"].Value?.ToString();
                txtLuongCoBan.Text = dgvBangLuong.CurrentRow.Cells["LuongCoBan"].Value?.ToString();
                txtPhuCap.Text = dgvBangLuong.CurrentRow.Cells["PhuCap"].Value?.ToString();
                txtThuong.Text = dgvBangLuong.CurrentRow.Cells["Thuong"].Value?.ToString();
                txtKhauTru.Text = dgvBangLuong.CurrentRow.Cells["KhauTru"].Value?.ToString();
            }
        }
    }
}
