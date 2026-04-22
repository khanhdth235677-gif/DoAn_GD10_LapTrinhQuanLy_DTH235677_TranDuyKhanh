using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
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
using static Quan_Ly_Nhan_Su.Reports.QLNSDataSet;

namespace Quan_Ly_Nhan_Su.Reports
{
    public partial class fromThongKeDuAn : Form
    {  
        #region === FIELD / BIẾN TOÀN CỤC ===
        private QLNSDataContext context = new QLNSDataContext();
        private QLNSDataSet.DanhSachDuAnDataTable danhSachDuAnDataTable = new QLNSDataSet.DanhSachDuAnDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows7.0", "Reports");
        ComboBox cbNhanVien;
        ComboBox cbDuAn;
        Button btnLocKQ;
        Button btnHienTC;
        #endregion
        #region === CONSTRUCTOR ===
        public fromThongKeDuAn()
        {
            InitializeComponent();
        }
        #endregion
        #region === FORM LOAD ===
        private void fromThongKeDuAn_Load(object sender, EventArgs e)
        {
            SetupReportViewer();   // ✅ tạo trước
            LoadReportData();      // ✅ load sau
            LayTenNhanVienVaoComboBox();
            LayDuAnVaoComboBox();
        }
        #endregion
        #region === LOAD DỮ LIỆU COMBOBOX ===
        public void LayTenNhanVienVaoComboBox()
        {
            // Giả sử bảng của bạn tên là NhanVien
            var list = context.NhanVien
                .Select(nv => new
                {
                    ID = nv.ID,
                    HoTen = nv.HoTen
                }).ToList();

            cbNhanVien.DataSource = list;
            cbNhanVien.DisplayMember = "HoTen";
            cbNhanVien.ValueMember = "ID";
            cbNhanVien.SelectedIndex = -1; // Để trống mặc định khi mới load
        }
        public void LayDuAnVaoComboBox()
        {
            var list = context.DuAn
                .Select(da => new
                {
                    ID = da.ID,
                    TenDuAn = da.TenDuAn
                }).ToList();

            cbDuAn.DataSource = list;
            cbDuAn.DisplayMember = "TenDuAn";
            cbDuAn.ValueMember = "ID";
            cbDuAn.SelectedIndex = -1;
        }
        #endregion
        #region === SETUP UI REPORT VIEWER ===
        private void SetupReportViewer()
        {
            // --- 1. PANEL LỌC (TOP) ---
            Panel pnlFilter = new Panel();
            pnlFilter.Height = 85; // Tăng nhẹ để thoáng hơn
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.BackColor = Color.White;

            // Panel trung gian chứa các control lọc
            Panel pnlContent = new Panel();
            pnlContent.BackColor = Color.Transparent;
            pnlContent.AutoSize = true;
            pnlContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            Font fontLabel = new Font("Segoe UI", 10, FontStyle.Regular);
            Font fontButton = new Font("Segoe UI", 9, FontStyle.Bold);

            // Nhân viên
            Label lblNhanVien = new Label() { Text = "Nhân viên:", Left = 0, Top = 10, AutoSize = true, Font = fontLabel, ForeColor = Color.DimGray };
            cbNhanVien = new ComboBox() { Left = 90, Top = 7, Width = 180, FlatStyle = FlatStyle.Flat, Font = fontLabel, DropDownStyle = ComboBoxStyle.DropDownList };

            // Dự án
            Label lblDuAn = new Label() { Text = "Dự án:", Left = 290, Top = 10, AutoSize = true, Font = fontLabel, ForeColor = Color.DimGray };
            cbDuAn = new ComboBox() { Left = 350, Top = 7, Width = 180, FlatStyle = FlatStyle.Flat, Font = fontLabel, DropDownStyle = ComboBoxStyle.DropDownList };

            // Nút bấm
            btnLocKQ = new Button() { Text = "LỌC KẾT QUẢ", Left = 550, Top = 3, Width = 120, Height = 35, Cursor = Cursors.Hand, Font = fontButton, BackColor = Color.FromArgb(0, 122, 204), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
            btnLocKQ.FlatAppearance.BorderSize = 0;

            btnHienTC = new Button() { Text = "HIỂN THỊ TẤT CẢ", Left = 680, Top = 3, Width = 140, Height = 35, Cursor = Cursors.Hand, Font = fontButton, BackColor = Color.FromArgb(0, 122, 204), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
            btnHienTC.FlatAppearance.BorderSize = 0;

            pnlContent.Controls.AddRange(new Control[] { lblNhanVien, cbNhanVien, lblDuAn, cbDuAn, btnLocKQ, btnHienTC });
            pnlFilter.Controls.Add(pnlContent);

            // Đường kẻ mảnh phía dưới Panel lọc
            Label line = new Label() { Dock = DockStyle.Bottom, Height = 1, BackColor = Color.LightGray };
            pnlFilter.Controls.Add(line);

            // --- 2. VÙNG HIỂN THỊ REPORT (CENTER) ---
            // Panel này đóng vai trò làm "nền" phía sau báo cáo (thường dùng màu xám nhạt để nổi trang trắng)
            Panel pnlReportWrapper = new Panel();
            pnlReportWrapper.Dock = DockStyle.Fill;
            pnlReportWrapper.BackColor = Color.FromArgb(224, 224, 224);

            reportViewer1 = new ReportViewer();
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.BorderStyle = BorderStyle.None;
            reportViewer1.BackColor = Color.White; // Màu của chính trang báo cáo

            pnlReportWrapper.Controls.Add(reportViewer1);

            // --- 3. LOGIC CĂN GIỮA ĐỘNG (DÙNG CHO CẢ LỌC VÀ REPORT) ---
            void UpdateLayoutPositions()
            {
                // Căn giữa cụm nút lọc
                pnlContent.Left = (pnlFilter.Width - pnlContent.Width) / 2;
                pnlContent.Top = (pnlFilter.Height - pnlContent.Height) / 2;

                // Căn giữa ReportViewer bằng cách tạo Padding lề trái/phải
                // Giả sử chiều rộng lý tưởng của báo cáo là 1100px
                int idealReportWidth = 1430;
                if (pnlReportWrapper.Width > idealReportWidth)
                {
                    int horizontalPadding = (pnlReportWrapper.Width - idealReportWidth) / 2;
                    pnlReportWrapper.Padding = new Padding(horizontalPadding, 20, horizontalPadding, 20);
                }
                else
                {
                    pnlReportWrapper.Padding = new Padding(10, 10, 10, 10);
                }
            }

            // Đăng ký sự kiện thay đổi kích thước
            pnlFilter.SizeChanged += (s, e) => UpdateLayoutPositions();
            pnlReportWrapper.SizeChanged += (s, e) => UpdateLayoutPositions();

            // Gán sự kiện cho nút
            btnLocKQ.Click += btnLocKQ_Click;
            btnHienTC.Click += btnHienTC_Click;

            // Thêm các Panel vào Form theo đúng thứ tự
            this.Controls.Add(pnlReportWrapper); // Add Fill trước
            this.Controls.Add(pnlFilter);         // Add Top sau

            // Gọi lần đầu để tính toán vị trí ngay khi mở Form
            UpdateLayoutPositions();
        }
        #endregion
        #region === LOAD REPORT BAN ĐẦU ===
        public void LoadReportData()
        {
            try
            {
                var data = context.DuAn.Select(da => new
                {
                    ID = da.ID,
                    MaDuAn = da.MaDuAn,
                    TenDuAn = da.TenDuAn,
                    TenNhanVienQL = da.NguoiQuanLy.HoTen,
                    KhachHang = da.KhachHang,
                    TenPhongBan = da.PhongBan.TenPhongBan,
                    NgayBatDau = da.NgayBatDau,
                    NgayKetThucDuKien = da.NgayKetThucDuKien,
                    NgayKetThucThucTe = da.NgayKetThucThucTe,
                    GiaTriHopDong = da.GiaTriHopDong,
                    TinhTrang = da.TinhTrang,
                    TienDo = da.TienDo,
                    GhiChu = da.GhiChu
                }).ToList();

                danhSachDuAnDataTable.Clear();

                foreach (var row in data)
                {
                    danhSachDuAnDataTable.AddDanhSachDuAnRow(
                        row.ID,
                        row.MaDuAn,
                        row.TenDuAn,
                        row.TenNhanVienQL,
                        row.KhachHang,
                        row.TenPhongBan,
                        row.NgayBatDau ?? DateTime.Now,        // Nếu null thì lấy ngày hiện tại
                        row.NgayKetThucDuKien ?? DateTime.Now, // Nếu null thì lấy ngày hiện tại
                        row.NgayKetThucThucTe ?? DateTime.Now, // Nếu null thì lấy ngày hiện tại
                        row.GiaTriHopDong ?? 0,                // Xử lý luôn cho phần tiền nếu bị lỗi decimal?
                        row.TinhTrang,
                        row.TienDo ?? 0,                       // Xử lý cho phần tiến độ
                        row.GhiChu
                    );
                }

                // ✅ QUAN TRỌNG: dùng DataTable, KHÔNG dùng data
                ReportDataSource rds = new ReportDataSource(
                    "DanhSachDuAnDataset",
                    (DataTable)danhSachDuAnDataTable
                );

                reportViewer1.Reset();

                reportViewer1.LocalReport.EnableExternalImages = true;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                reportViewer1.LocalReport.ReportPath =
                    Path.Combine(Application.StartupPath, "Reports", "rptThongKeDuAn.rdlc");

                ReportParameter reportParameter = new ReportParameter("HienThiKetQua", "(Tất cả dự án)");
                reportViewer1.LocalReport.SetParameters(reportParameter);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                // Xem lỗi chi tiết ở đây
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }
        #endregion
        #region === BUTTON: HIỂN THỊ TẤT CẢ ===
        private void btnHienTC_Click(object sender, EventArgs e)
        {
            // 1. Reset ComboBox về rỗng
            cbNhanVien.SelectedIndex = -1;
            cbDuAn.SelectedIndex = -1;

            cbNhanVien.SelectedItem = null;
            cbDuAn.SelectedItem = null;

            cbNhanVien.Text = "";
            cbDuAn.Text = "";

            // 2. Load lại toàn bộ dữ liệu (KHÔNG filter)
            var data = context.DuAn.Select(da => new
            {
                ID = da.ID,
                MaDuAn = da.MaDuAn,
                TenDuAn = da.TenDuAn,
                TenNhanVienQL = da.NguoiQuanLy.HoTen,
                KhachHang = da.KhachHang,
                TenPhongBan = da.PhongBan.TenPhongBan,
                NgayBatDau = da.NgayBatDau,
                NgayKetThucDuKien = da.NgayKetThucDuKien,
                NgayKetThucThucTe = da.NgayKetThucThucTe,
                GiaTriHopDong = da.GiaTriHopDong,
                TinhTrang = da.TinhTrang,
                TienDo = da.TienDo,
                GhiChu = da.GhiChu
            }).ToList();

            danhSachDuAnDataTable.Clear();

            foreach (var row in data)
            {
                danhSachDuAnDataTable.AddDanhSachDuAnRow(
                    row.ID,
                    row.MaDuAn,
                    row.TenDuAn,
                    row.TenNhanVienQL,
                    row.KhachHang,
                    row.TenPhongBan,
                    row.NgayBatDau ?? DateTime.Now,        
                    row.NgayKetThucDuKien ?? DateTime.Now, 
                    row.NgayKetThucThucTe ?? DateTime.Now, 
                    row.GiaTriHopDong ?? 0,                
                    row.TinhTrang,
                    row.TienDo ?? 0,                     
                    row.GhiChu
                );
            }

            // 3. Gán lại Report
            ReportDataSource rds = new ReportDataSource(
                "DanhSachDuAnDataset",
                (DataTable)danhSachDuAnDataTable
            );

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            // (OPTION) reset mô tả
            ReportParameter p = new ReportParameter("HienThiKetQua", "Tất cả dự án");
            reportViewer1.LocalReport.SetParameters(p);

            reportViewer1.RefreshReport();
        }
        #endregion
        #region === BUTTON: LỌC KẾT QUẢ ===
        private void btnLocKQ_Click(object sender, EventArgs e)
        {
            // Bắt đầu truy vấn
            var query = context.DuAn
                .Include(da => da.NguoiQuanLy)
                .Include(da => da.PhongBan)
                .AsQueryable();

            // 1. Lọc theo nhân viên quản lý dự án
            if (cbNhanVien.SelectedIndex != -1 && cbNhanVien.SelectedValue != null)
            {
                // Sử dụng TryParse hoặc Convert để tránh lỗi ép kiểu từ SelectedValue
                if (int.TryParse(cbNhanVien.SelectedValue.ToString(), out int nvID))
                {
                    // Lọc những dự án có NguoiQuanLyID khớp với ID nhân viên được chọn
                    query = query.Where(da => da.NguoiQuanLyID == nvID);
                }
            }

            // 2. Lọc theo tên dự án cụ thể
            if (cbDuAn.SelectedIndex != -1 && cbDuAn.SelectedValue != null)
            {
                if (int.TryParse(cbDuAn.SelectedValue.ToString(), out int daID))
                {
                    // Lọc trực tiếp theo khóa chính ID của bảng Dự án
                    query = query.Where(da => da.ID == daID);
                }
            }

            var data = query.Select(da => new
            {
                ID = da.ID,
                MaDuAn = da.MaDuAn,
                TenDuAn = da.TenDuAn,
                TenNhanVienQL = da.NguoiQuanLy.HoTen,
                KhachHang = da.KhachHang,
                TenPhongBan = da.PhongBan.TenPhongBan,
                NgayBatDau = da.NgayBatDau,
                NgayKetThucDuKien = da.NgayKetThucDuKien,
                NgayKetThucThucTe = da.NgayKetThucThucTe,
                GiaTriHopDong = da.GiaTriHopDong,
                TinhTrang = da.TinhTrang,
                TienDo = da.TienDo,
                GhiChu = da.GhiChu
            }).ToList();

            danhSachDuAnDataTable.Clear();

            foreach (var row in data)
            {
                danhSachDuAnDataTable.AddDanhSachDuAnRow(
                    row.ID,
                    row.MaDuAn,
                    row.TenDuAn,
                    row.TenNhanVienQL,
                    row.KhachHang,
                    row.TenPhongBan,
                    row.NgayBatDau ?? DateTime.Now,
                    row.NgayKetThucDuKien ?? DateTime.Now,
                    row.NgayKetThucThucTe ?? DateTime.Now,
                    row.GiaTriHopDong ?? 0,
                    row.TinhTrang,
                    row.TienDo ?? 0,
                    row.GhiChu
                );
            }



            // 3. Gán lại Report
            ReportDataSource rds = new ReportDataSource(
                "DanhSachDuAnDataset",
                (DataTable)danhSachDuAnDataTable
            );

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();

        }
        #endregion
    }
}
