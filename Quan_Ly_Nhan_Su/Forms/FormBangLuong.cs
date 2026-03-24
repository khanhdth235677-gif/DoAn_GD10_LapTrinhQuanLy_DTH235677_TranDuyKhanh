using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
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
        #region ===== Khai báo biến =====
        QLNSDataContext context = new QLNSDataContext();
        bool xuLyThem = false;
        int id;
        #endregion

        #region ===== Khởi tạo =====
        public FormBangLuong()
        {
            InitializeComponent();
        }
        #endregion

        #region ===== Load Form =====
        private void BangLuong_Load(object sender, EventArgs e)
        {
            UIStyle.ApplyStyle(this);
            BatTatChucNang(false);
            LoadNhanVien();
            LoadBangLuong();}
        }
        #endregion

        #region ===== Load dữ liệu =====
        private void LoadNhanVien()
        {
            var dsNhanVien = context.NhanVien.ToList();

            cbMaNV.DataSource = dsNhanVien;
            cbMaNV.DisplayMember = "MaNV";
            cbMaNV.ValueMember = "ID";
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
        #endregion

        #region ===== Xử lý UI =====
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
        #endregion

        #region ===== Thêm =====
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
        #endregion

        #region ===== Sửa =====
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
        #endregion

        #region ===== Lưu =====
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
        #endregion

        #region ===== Xóa =====
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
        #endregion

        #region ===== Reset =====
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
        #endregion

        #region ===== Tính tổng =====
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
        #endregion

        #region ===== DataGridView =====
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

        private void dgvBangLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }
        #endregion

        #region ===== Xuất Excel =====
        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất bảng lương";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "BangLuong_" + DateTime.Now.ToString("MM_yyyy");

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int thang = dtThangNam.Value.Month;
                    int nam = dtThangNam.Value.Year;

                    var dsLuong = context.BangLuong
                        .Include(bl => bl.NhanVien)
                        .Where(bl => bl.ThangNam.Month == thang && bl.ThangNam.Year == nam)
                        .ToList();

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add("BangLuong");

                        sheet.Cell(1, 1).Value = "ID";
                        sheet.Cell(1, 2).Value = "Mã NV";
                        sheet.Cell(1, 3).Value = "Tên NV";
                        sheet.Cell(1, 4).Value = "Tháng";
                        sheet.Cell(1, 5).Value = "Lương cơ bản";
                        sheet.Cell(1, 6).Value = "Phụ cấp";
                        sheet.Cell(1, 7).Value = "Thưởng";
                        sheet.Cell(1, 8).Value = "Khấu trừ";
                        sheet.Cell(1, 9).Value = "Tổng lương";

                        var header = sheet.Range("A1:I1");
                        header.Style.Font.Bold = true;
                        header.Style.Fill.BackgroundColor = XLColor.LightGray;
                        header.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        int row = 2;

                        foreach (var bl in dsLuong)
                        {
                            sheet.Cell(row, 1).Value = bl.ID;
                            sheet.Cell(row, 2).Value = bl.NhanVienID;
                            sheet.Cell(row, 3).Value = bl.NhanVien?.HoTen;
                            sheet.Cell(row, 4).Value = bl.ThangNam.ToString("MM/yyyy");

                            sheet.Cell(row, 5).Value = bl.LuongCoBan;
                            sheet.Cell(row, 6).Value = bl.PhuCap;
                            sheet.Cell(row, 7).Value = bl.Thuong;
                            sheet.Cell(row, 8).Value = bl.KhauTru;
                            sheet.Cell(row, 9).Value = bl.TongLuong;

                            sheet.Range(row, 5, row, 9).Style.NumberFormat.Format = "#,##0";

                            row++;
                        }

                        sheet.Cell(row + 1, 8).Value = "Tổng:";
                        sheet.Cell(row + 1, 9).FormulaA1 = $"SUM(I2:I{row - 1})";

                        var range = sheet.Range($"A1:I{row - 1}");
                        range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                        sheet.Columns().AdjustToContents();

                        wb.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Xuất Excel bảng lương thành công!",
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
        private void label4_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}