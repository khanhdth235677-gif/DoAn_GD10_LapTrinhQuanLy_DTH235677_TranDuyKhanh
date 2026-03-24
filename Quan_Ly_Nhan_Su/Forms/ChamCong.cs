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
    public partial class ChamCong : Form
    {
        #region ===== Khai báo biến =====
        QLNSDataContext context = new QLNSDataContext();
        bool xuLyThem = false;
        int id;
        bool daLoad = false;
        #endregion

        #region ===== Khởi tạo =====
        public ChamCong()
        {
            InitializeComponent();
        }
        #endregion

        #region ===== Load Form =====
        private void ChamCong_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            UIStyle.ApplyStyle(this);

            cbNhanVien.DataSource = context.NhanVien.ToList();
            cbNhanVien.DisplayMember = "HoTen";
            cbNhanVien.ValueMember = "ID";

            daLoad = true;
            if (Session.Quyen == "Nhân viên")
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }

            LoadChamCong();
        }
        #endregion

        #region ===== Xử lý UI =====
        void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnLamMoi.Enabled = giaTri;

            cbNhanVien.Enabled = giaTri;
            dtpNgay.Enabled = giaTri;
            cbTrangThai.Enabled = giaTri;
            numTangCa.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }
        #endregion

        #region ===== Load dữ liệu =====
        void LoadChamCong()
        {
            if (!daLoad) return;
            if (cbNhanVien.SelectedValue == null) return;

            int idNhanVien = Convert.ToInt32(cbNhanVien.SelectedValue);

            int thang = dtpThang.Value.Month;
            int nam = dtpThang.Value.Year;

            var data = context.ChamCong
                .Where(x => x.NhanVienID == idNhanVien
                    && x.Ngay.Month == thang
                    && x.Ngay.Year == nam)
                .Select(x => new
                {
                    x.ID,
                    TenNhanVien = x.NhanVien.HoTen,
                    x.Ngay,
                    x.TrangThai,
                    x.GioTangCa
                }).ToList();

            dgvChamCong.DataSource = data;

            dgvChamCong.Columns["Ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";

            TinhThongKe();
        }

        void LoadTatCaChamCong()
        {
            var data = context.ChamCong
                .Select(x => new
                {
                    x.ID,
                    TenNhanVien = x.NhanVien.HoTen,
                    x.Ngay,
                    x.TrangThai,
                    x.GioTangCa
                }).ToList();

            dgvChamCong.DataSource = data;

            dgvChamCong.Columns["Ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        #endregion

        #region ===== Thống kê =====
        void TinhThongKe()
        {
            if (cbNhanVien.SelectedValue == null) return;

            int idNhanVien = Convert.ToInt32(cbNhanVien.SelectedValue);

            int thang = dtpThang.Value.Month;
            int nam = dtpThang.Value.Year;

            int ngayCong = context.ChamCong
                .Where(x => x.NhanVienID == idNhanVien
                    && x.Ngay.Month == thang
                    && x.Ngay.Year == nam
                    && x.TrangThai == "đã chấm công")
                .Count();

            int tongTangCa = context.ChamCong
                .Where(x => x.NhanVienID == idNhanVien
                    && x.Ngay.Month == thang
                    && x.Ngay.Year == nam)
                .Sum(x => (int?)x.GioTangCa) ?? 0;

            lblNgayCongMacDinh.Text = "26";
            lblNgayCongThucTe.Text = ngayCong.ToString();
            lblTongTangCa.Text = tongTangCa.ToString();
        }
        #endregion

        #region ===== Thêm =====
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            cbTrangThai.Text = "";
            numTangCa.Value = 0;
        }
        #endregion

        #region ===== Sửa =====
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvChamCong.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dgvChamCong.CurrentRow.Cells["ID"].Value);
        }
        #endregion

        #region ===== Xóa =====
        private void btnXóa_Click(object sender, EventArgs e)
        {
            if (dgvChamCong.CurrentRow == null) return;

            if (MessageBox.Show("Xác nhận xóa?",
                 "Xóa",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvChamCong.CurrentRow.Cells["ID"].Value);

                Data.ChamCong cc = context.ChamCong.Find(id);

                if (cc != null)
                {
                    context.ChamCong.Remove(cc);
                    context.SaveChanges();
                }

                LoadChamCong();
            }
        }
        #endregion

        #region ===== Lưu =====
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
                return;
            }

            int idNhanVien = Convert.ToInt32(cbNhanVien.SelectedValue);

            if (xuLyThem)
            {
                bool tonTai = context.ChamCong.Any(x =>
                    x.NhanVienID == idNhanVien &&
                    x.Ngay.Date == dtpNgay.Value.Date);

                if (tonTai)
                {
                    MessageBox.Show("Nhân viên đã được chấm công ngày này!");
                    return;
                }

                Data.ChamCong cc = new Data.ChamCong();

                cc.NhanVienID = idNhanVien;
                cc.Ngay = dtpNgay.Value;
                cc.TrangThai = cbTrangThai.Text;
                cc.GioTangCa = (int)numTangCa.Value;

                context.ChamCong.Add(cc);
                context.SaveChanges();
            }
            else
            {
                Data.ChamCong cc = context.ChamCong.Find(id);

                if (cc != null)
                {
                    cc.NhanVienID = idNhanVien;
                    cc.Ngay = dtpNgay.Value;
                    cc.TrangThai = cbTrangThai.Text;
                    cc.GioTangCa = (int)numTangCa.Value;

                    context.SaveChanges();
                }
            }

            LoadChamCong();
            BatTatChucNang(false);
        }
        #endregion

        #region ===== Làm mới =====
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            cbNhanVien.SelectedIndex = -1;
            cbTrangThai.SelectedIndex = -1;
            dtpNgay.Value = DateTime.Now;
            numTangCa.Value = 0;

            lblNgayCongMacDinh.Text = "26";
            lblNgayCongThucTe.Text = "0";
            lblTongTangCa.Text = "0";

            LoadTatCaChamCong();
        }
        #endregion

        #region ===== DataGridView =====
        private void dgvChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            cbNhanVien.Text = dgvChamCong.Rows[e.RowIndex].Cells["TenNhanVien"].Value.ToString();

            dtpNgay.Value = Convert.ToDateTime(
                dgvChamCong.Rows[e.RowIndex].Cells["Ngay"].Value);

            cbTrangThai.Text =
                dgvChamCong.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();

            numTangCa.Value = Convert.ToInt32(
                dgvChamCong.Rows[e.RowIndex].Cells["GioTangCa"].Value);
        }
        #endregion

        #region ===== Sự kiện thay đổi =====
        private void cbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!daLoad) return;
            LoadChamCong();
        }

        private void dtpThang_ValueChanged(object sender, EventArgs e)
        {
            if (!daLoad) return;
            LoadChamCong();
        }
        #endregion

        #region ===== Xuất Excel =====
        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất bảng chấm công";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "ChamCong_" + DateTime.Now.ToString("dd_MM_yyyy");

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int thang = dtpThang.Value.Month;
                    int nam = dtpThang.Value.Year;

                    var dsChamCong = context.ChamCong
                        .Include(cc => cc.NhanVien)
                        .Where(cc => cc.Ngay.Month == thang && cc.Ngay.Year == nam)
                        .ToList();

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add("ChamCong");

                        sheet.Cell(1, 1).Value = "ID";
                        sheet.Cell(1, 2).Value = "Nhân viên";
                        sheet.Cell(1, 3).Value = "Ngày";
                        sheet.Cell(1, 4).Value = "Trạng thái";
                        sheet.Cell(1, 5).Value = "Giờ tăng ca";

                        var header = sheet.Range("A1:E1");
                        header.Style.Font.Bold = true;
                        header.Style.Fill.BackgroundColor = XLColor.LightGray;
                        header.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        int row = 2;

                        foreach (var cc in dsChamCong)
                        {
                            sheet.Cell(row, 1).Value = cc.ID;
                            sheet.Cell(row, 2).Value = cc.NhanVien?.HoTen;
                            sheet.Cell(row, 3).Value = cc.Ngay.ToString("dd/MM/yyyy");
                            sheet.Cell(row, 4).Value = cc.TrangThai;
                            sheet.Cell(row, 5).Value = cc.GioTangCa;

                            if (cc.TrangThai == "Nghỉ")
                                sheet.Row(row).Style.Fill.BackgroundColor = XLColor.LightPink;
                            else if (cc.TrangThai == "Đi làm")
                                sheet.Row(row).Style.Fill.BackgroundColor = XLColor.LightGreen;

                            row++;
                        }

                        sheet.Cell(row + 1, 4).Value = "Tổng giờ tăng ca:";
                        sheet.Cell(row + 1, 5).FormulaA1 = $"SUM(E2:E{row - 1})";

                        var range = sheet.Range($"A1:E{row - 1}");
                        range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                        sheet.Columns().AdjustToContents();

                        wb.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Xuất Excel thành công ",
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
        private void label6_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}