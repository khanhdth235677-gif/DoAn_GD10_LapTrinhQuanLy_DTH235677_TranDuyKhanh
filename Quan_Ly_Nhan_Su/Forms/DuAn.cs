using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using Quan_Ly_Nhan_Su.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quan_Ly_Nhan_Su.Forms
{
    public partial class DuAn : Form
    {
        #region Khai báo biến & khởi tạo

        private readonly QLNSDataContext context = new QLNSDataContext();
        private bool xuLyThem = false;
        private int id;

        public DuAn()
        {
            InitializeComponent();
        }

        #endregion

        #region Sự kiện Form & TabControl

        private void DuAn_Load(object sender, EventArgs e)
        {
            dgvDanhSachDuAn.AutoGenerateColumns = false;
            dgvPhanCongDuAn.AutoGenerateColumns = false;
            UIStyle.ApplyStyle(this);
            // Load dữ liệu cho các ComboBox
            LoadComboTimKiem();
            LoadComboPhongBanDS();
            LoadComboPhongBanPC();
            LoadComboNhanVienQL();
            LoadTienDo();

            // Load dữ liệu ban đầu
            LoadAllDuAn();
            LoadDuAnPhanCong();

            tabControl1.SelectedTab = tabDanhSachDuAn; // mở tab danh sách đầu tiên
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            TabPage tabPage = tabControl1.TabPages[e.Index];
            Rectangle tabRect = tabControl1.GetTabRect(e.Index);
            bool isSelected = (e.Index == tabControl1.SelectedIndex);

            // vẽ nền
            g.FillRectangle(new SolidBrush(Color.White), tabRect);

            // màu chữ
            Color textColor = isSelected ? Color.Teal : Color.Gray;
            TextRenderer.DrawText(
                g,
                tabPage.Text,
                new Font("Segoe UI", 10, FontStyle.Bold),
                tabRect,
                textColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );

            // gạch chân tab đang chọn
            if (isSelected)
            {
                Pen pen = new Pen(Color.Teal, 3);
                g.DrawLine(pen,
                    tabRect.Left + 10,
                    tabRect.Bottom - 2,
                    tabRect.Right - 10,
                    tabRect.Bottom - 2);
            }
        }

        #endregion

        #region Load dữ liệu ComboBox

        /// <summary>
        /// Load dữ liệu cho ComboBox tìm kiếm (Mã DA & Tên DA)
        /// </summary>
        private void LoadComboTimKiem()
        {
            var duAnList = context.DuAn
                .Where(d => !string.IsNullOrEmpty(d.MaDuAn) || !string.IsNullOrEmpty(d.TenDuAn))
                .Select(d => new { d.MaDuAn, d.TenDuAn })
                .Distinct()
                .ToList();

            // ComboBox Mã DA
            cbMaDA.DataSource = duAnList;
            cbMaDA.DisplayMember = "MaDuAn";
            cbMaDA.ValueMember = "MaDuAn";
            cbMaDA.SelectedIndex = -1;

            // ComboBox Tên DA
            cbTenDA.DataSource = duAnList;
            cbTenDA.DisplayMember = "TenDuAn";
            cbTenDA.ValueMember = "TenDuAn";
            cbTenDA.SelectedIndex = -1;
        }

        private void LoadComboPhongBanDS()
        {
            var phongBans = context.PhongBan
                .Select(p => new { p.ID, p.TenPhongBan })
                .ToList();

            cbTenPhongBan.DataSource = phongBans;
            cbTenPhongBan.DisplayMember = "TenPhongBan";
            cbTenPhongBan.ValueMember = "ID";
            cbTenPhongBan.SelectedIndex = -1;
        }

        private void LoadComboPhongBanPC()
        {
            var listPB = context.PhongBan
                .Select(p => new { p.ID, p.TenPhongBan })
                .ToList();

            cbPhongBan.DataSource = listPB;
            cbPhongBan.DisplayMember = "TenPhongBan";
            cbPhongBan.ValueMember = "ID";
            cbPhongBan.SelectedIndex = -1;
        }

        private void LoadComboNhanVienQL()
        {
            var listNV = context.NhanVien
                .Select(n => new { n.ID, n.HoTen })
                .ToList();

            cbTenNhanVienQL.DataSource = listNV;
            cbTenNhanVienQL.DisplayMember = "HoTen";
            cbTenNhanVienQL.ValueMember = "ID";
            cbTenNhanVienQL.SelectedIndex = -1;
        }
        private void LoadTienDo()
        {
            cbTienDo.Items.Clear();

            cbTienDo.Items.Add("0");
            cbTienDo.Items.Add("25");
            cbTienDo.Items.Add("50");
            cbTienDo.Items.Add("75");
            cbTienDo.Items.Add("100");

            cbTienDo.SelectedIndex = -1;
        }

        #endregion

        #region Load & Hiển thị dữ liệu DataGridView

        private void LoadAllDuAn()
        {
            var data = from da in context.DuAn
                       join pb in context.PhongBan on da.PhongBanID equals pb.ID into pbGroup
                       from pb in pbGroup.DefaultIfEmpty()
                       join nv in context.NhanVien on da.NguoiQuanLyID equals nv.ID into nvGroup
                       from nv in nvGroup.DefaultIfEmpty()
                       select new
                       {
                           MaDA = da.MaDuAn,
                           TenDA = da.TenDuAn,
                           KhachHang = da.KhachHang,
                           TenNVQL = nv != null ? nv.HoTen : "",
                           PhongBan = pb != null ? pb.TenPhongBan : "",
                           NgayBD = da.NgayBatDau,
                           NgayKTTT = da.NgayKetThucThucTe,
                           NgayKTDK = da.NgayKetThucDuKien,
                           GiaTri = da.GiaTriHopDong,
                           TienDo = da.TienDo.HasValue ? da.TienDo + " %" : "",
                           TinhTrang = da.TinhTrang == "Hoàn thành",
                           GhiChu = da.GhiChu
                       };

            dgvDanhSachDuAn.DataSource = data.ToList();
        }

        private void LoadDuAnPhanCong()
        {
            var data = from da in context.DuAn
                       join pb in context.PhongBan on da.PhongBanID equals pb.ID into pbGroup
                       from pb in pbGroup.DefaultIfEmpty()
                       join nv in context.NhanVien on da.NguoiQuanLyID equals nv.ID into nvGroup
                       from nv in nvGroup.DefaultIfEmpty()
                       select new
                       {
                           MaDA = da.MaDuAn,
                           TenDA = da.TenDuAn,
                           KhachHang = da.KhachHang,
                           TenNVQL = nv != null ? nv.HoTen : "",
                           PhongBan = pb != null ? pb.TenPhongBan : "",
                           NgayBD = da.NgayBatDau,
                           NgayKTTT = da.NgayKetThucThucTe,
                           NgayKTDK = da.NgayKetThucDuKien,
                           GiaTri = da.GiaTriHopDong,
                           TienDo = da.TienDo.HasValue ? da.TienDo + " %" : "",
                           TinhTrang = da.TinhTrang == "Hoàn thành",
                           GhiChu = da.GhiChu
                       };

            dgvPhanCongDuAn.DataSource = data.ToList();
        }

        #endregion

        #region Tìm kiếm & Làm mới

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var query = from da in context.DuAn
                        join pb in context.PhongBan on da.PhongBanID equals pb.ID into pbGroup
                        from pb in pbGroup.DefaultIfEmpty()
                        join nv in context.NhanVien on da.NguoiQuanLyID equals nv.ID into nvGroup
                        from nv in nvGroup.DefaultIfEmpty()
                        select new
                        {
                            MaDA = da.MaDuAn,
                            TenDA = da.TenDuAn,
                            KhachHang = da.KhachHang,
                            TenNVQL = nv != null ? nv.HoTen : "",
                            PhongBan = pb != null ? pb.TenPhongBan : "",
                            NgayBD = da.NgayBatDau,
                            NgayKTTT = da.NgayKetThucThucTe,
                            NgayKTDK = da.NgayKetThucDuKien,
                            GiaTri = da.GiaTriHopDong,
                            TienDo = da.TienDo.HasValue ? da.TienDo + " %" : "",
                            TinhTrang = da.TinhTrang == "Hoàn thành",
                            GhiChu = da.GhiChu,
                            PhongBanID = da.PhongBanID
                        };

            // Lọc theo Mã DA
            if (cbMaDA.SelectedValue != null && !string.IsNullOrWhiteSpace(cbMaDA.Text))
            {
                string ma = cbMaDA.Text.Trim();
                query = query.Where(x => x.MaDA == ma);
            }

            // Lọc theo Tên DA
            if (cbTenDA.SelectedValue != null && !string.IsNullOrWhiteSpace(cbTenDA.Text))
            {
                string ten = cbTenDA.Text.Trim();
                query = query.Where(x => x.TenDA == ten);
            }

            // Lọc theo Phòng ban
            if (cbTenPhongBan.SelectedValue != null)
            {
                int phongID = Convert.ToInt32(cbTenPhongBan.SelectedValue);
                query = query.Where(x => x.PhongBanID == phongID);
            }

            var result = query.ToList();
            dgvDanhSachDuAn.DataSource = result;

            if (result.Count == 0)
            {
                MessageBox.Show("Không tìm thấy dự án nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                cbMaDA.SelectedIndex = -1;
                cbMaDA.Text = "";
                cbTenDA.SelectedIndex = -1;
                cbTenDA.Text = "";
                cbTenPhongBan.SelectedIndex = -1;
                cbTenPhongBan.Text = "";
                LoadAllDuAn();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        #endregion

        #region Xử lý Thêm / Sửa / Xóa dự án

        private void ResetForm()
        {
            txtTenDuAn.Clear();
            txtTenKhachHang.Clear();
            txtGiaTri.Clear();
            txtGhiChu.Clear();

            dtNgayBD.Value = DateTime.Today;
            dtNgayKTDK.Value = DateTime.Today;
            dtNgayKTTT.Value = DateTime.Today.AddMonths(3);

            chkHoanThanh.Checked = false;

            if (cbTenNhanVienQL.Items.Count > 0) cbTenNhanVienQL.SelectedIndex = -1;
            if (cbPhongBan.Items.Count > 0) cbPhongBan.SelectedIndex = -1;
            cbTienDo.SelectedIndex = -1;

            txtTenDuAn.Focus();

            xuLyThem = true;
            id = 0;

            this.Text = "Quản lý dự án - Thêm dự án mới";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn hủy thao tác hiện tại không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            ResetForm();
            xuLyThem = false;
            id = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPhanCongDuAn;
            ResetForm();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(txtTenDuAn.Text)) { MessageBox.Show("Vui lòng nhập tên dự án!"); txtTenDuAn.Focus(); return; }
            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text)) { MessageBox.Show("Vui lòng nhập tên khách hàng!"); txtTenKhachHang.Focus(); return; }
            if (cbPhongBan.SelectedValue == null) { MessageBox.Show("Vui lòng chọn phòng ban!"); cbPhongBan.Focus(); return; }

            try
            {
                Quan_Ly_Nhan_Su.Data.DuAn da;

                if (xuLyThem)
                {
                    da = new Quan_Ly_Nhan_Su.Data.DuAn();
                    int soThuTu = context.DuAn.Count() + 1;
                    da.MaDuAn = "DA" + soThuTu.ToString("D3");
                    context.DuAn.Add(da);
                }
                else
                {
                    da = context.DuAn.FirstOrDefault(x => x.ID == id);
                    if (da == null) return;
                }

                // Gán dữ liệu
                da.TenDuAn = txtTenDuAn.Text.Trim();
                da.KhachHang = txtTenKhachHang.Text.Trim();
                da.NguoiQuanLyID = (int?)cbTenNhanVienQL.SelectedValue;
                da.PhongBanID = (int?)cbPhongBan.SelectedValue;

                da.NgayBatDau = dtNgayBD.Value;
                da.NgayKetThucDuKien = dtNgayKTDK.Value;
                da.NgayKetThucThucTe = chkHoanThanh.Checked ? dtNgayKTTT.Value : (DateTime?)null;

                if (decimal.TryParse(txtGiaTri.Text, out decimal giaTri)) da.GiaTriHopDong = giaTri;
                if (cbTienDo.SelectedItem != null)
                {
                    da.TienDo = int.Parse(cbTienDo.SelectedItem.ToString());
                }

                da.TinhTrang = chkHoanThanh.Checked ? "Hoàn thành" : "Đang thực hiện";
                da.GhiChu = txtGhiChu.Text.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }

            context.SaveChanges();
            MessageBox.Show("Lưu thành công!", "Thông báo");

            LoadAllDuAn();
            LoadDuAnPhanCong();
            tabControl1.SelectedTab = tabDanhSachDuAn;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachDuAn.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dự án cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maDA = dgvDanhSachDuAn.CurrentRow.Cells["MaDA"].Value?.ToString()?.Trim();
            if (string.IsNullOrWhiteSpace(maDA))
            {
                MessageBox.Show("Không tìm thấy mã dự án!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var duAn = context.DuAn.FirstOrDefault(d => d.MaDuAn == maDA);
            if (duAn == null)
            {
                MessageBox.Show("Không tìm thấy thông tin dự án!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            id = duAn.ID;
            xuLyThem = false;

            tabControl1.SelectedTab = tabPhanCongDuAn;

            // Đổ dữ liệu
            txtTenDuAn.Text = duAn.TenDuAn ?? "";
            txtTenKhachHang.Text = duAn.KhachHang ?? "";
            txtGiaTri.Text = duAn.GiaTriHopDong?.ToString("N0") ?? "";
            txtGhiChu.Text = duAn.GhiChu ?? "";
            if (duAn.TienDo.HasValue)
                cbTienDo.SelectedItem = duAn.TienDo.Value.ToString();
            else
                cbTienDo.SelectedIndex = -1;

            dtNgayBD.Value = duAn.NgayBatDau ?? DateTime.Today;
            dtNgayKTDK.Value = duAn.NgayKetThucDuKien ?? DateTime.Today;
            dtNgayKTTT.Value = duAn.NgayKetThucThucTe ?? DateTime.Today;

            chkHoanThanh.Checked = (duAn.TinhTrang == "Hoàn thành");

            if (duAn.PhongBanID.HasValue)
                cbPhongBan.SelectedValue = duAn.PhongBanID.Value;
            else
                cbPhongBan.SelectedIndex = -1;

            if (duAn.NguoiQuanLyID.HasValue)
                cbTenNhanVienQL.SelectedValue = duAn.NguoiQuanLyID.Value;
            else
                cbTenNhanVienQL.SelectedIndex = -1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachDuAn.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dự án cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maDA = dgvDanhSachDuAn.CurrentRow.Cells["MaDA"].Value?.ToString()?.Trim();
            if (string.IsNullOrWhiteSpace(maDA))
            {
                MessageBox.Show("Không lấy được mã dự án!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa dự án này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            try
            {
                var duAn = context.DuAn.FirstOrDefault(d => d.MaDuAn == maDA);
                if (duAn == null)
                {
                    MessageBox.Show("Không tìm thấy dự án!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                context.DuAn.Remove(duAn);
                context.SaveChanges();

                MessageBox.Show("Xóa dự án thành công!", "Thông báo");

                LoadAllDuAn();
                LoadDuAnPhanCong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        #endregion

        #region Điều hướng & Sự kiện phụ

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabDanhSachDuAn;
        }

        private void dgvPhanCongDuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvPhanCongDuAn.Rows[e.RowIndex];

            txtTenDuAn.Text = row.Cells["TenDA1"].Value?.ToString();
            txtTenKhachHang.Text = row.Cells["KhachHang1"].Value?.ToString();
            txtGiaTri.Text = row.Cells["GiaTri1"].Value?.ToString();
            txtGhiChu.Text = row.Cells["GhiChu1"].Value?.ToString();
        }

        #endregion

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất danh sách dự án";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "DuAn_" + DateTime.Now.ToString("dd_MM_yyyy");

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var dsDuAn = context.DuAn
                        .Include(da => da.PhongBan)
                        .Include(da => da.NguoiQuanLy)
                        .ToList();

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add("DuAn");

                        // Header
                        sheet.Cell(1, 1).Value = "Mã DA";
                        sheet.Cell(1, 2).Value = "Tên DA";
                        sheet.Cell(1, 3).Value = "Khách hàng";
                        sheet.Cell(1, 4).Value = "Quản lý";
                        sheet.Cell(1, 5).Value = "Phòng ban";
                        sheet.Cell(1, 6).Value = "Ngày bắt đầu";
                        sheet.Cell(1, 7).Value = "Ngày KT dự kiến";
                        sheet.Cell(1, 8).Value = "Ngày KT thực tế";
                        sheet.Cell(1, 9).Value = "Giá trị";
                        sheet.Cell(1, 10).Value = "Tiến độ (%)";
                        sheet.Cell(1, 11).Value = "Tình trạng";
                        sheet.Cell(1, 12).Value = "Ghi chú";

                        var header = sheet.Range("A1:L1");
                        header.Style.Font.Bold = true;
                        header.Style.Fill.BackgroundColor = XLColor.LightGray;
                        header.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        int row = 2;

                        foreach (var da in dsDuAn)
                        {
                            sheet.Cell(row, 1).Value = da.MaDuAn;
                            sheet.Cell(row, 2).Value = da.TenDuAn;
                            sheet.Cell(row, 3).Value = da.KhachHang;
                            sheet.Cell(row, 4).Value = da.NguoiQuanLy?.HoTen;
                            sheet.Cell(row, 5).Value = da.PhongBan?.TenPhongBan;

                            sheet.Cell(row, 6).Value = da.NgayBatDau?.ToString("dd/MM/yyyy");
                            sheet.Cell(row, 7).Value = da.NgayKetThucDuKien?.ToString("dd/MM/yyyy");
                            sheet.Cell(row, 8).Value = da.NgayKetThucThucTe?.ToString("dd/MM/yyyy");

                            sheet.Cell(row, 9).Value = da.GiaTriHopDong;
                            sheet.Cell(row, 10).Value = da.TienDo;

                            // ===== CHECKBOX TÌNH TRẠNG =====
                            bool hoanThanh = da.TinhTrang == "Hoàn thành";

                            var cellTrangThai = sheet.Cell(row, 11);
                            cellTrangThai.Value = hoanThanh ? "✔ Hoàn thành" : "✘ Chưa hoàn thành";

                            // Tô màu
                            if (hoanThanh)
                                cellTrangThai.Style.Fill.BackgroundColor = XLColor.LightGreen;
                            else
                                cellTrangThai.Style.Fill.BackgroundColor = XLColor.LightPink;
                            // ================================

                            sheet.Cell(row, 12).Value = da.GhiChu;

                            // Format tiền
                            sheet.Cell(row, 9).Style.NumberFormat.Format = "#,##0 \"đ\"";

                            // Format tiến độ %
                            sheet.Cell(row, 10).Style.NumberFormat.Format = "0\"%\"";

                            // Căn giữa tình trạng + tiến độ
                            cellTrangThai.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            sheet.Cell(row, 10).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                            row++;
                        }

                        // Border
                        var range = sheet.Range($"A1:L{row - 1}");
                        range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                        sheet.Columns().AdjustToContents();

                        wb.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Xuất Excel dự án thành công!",
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
    }
}