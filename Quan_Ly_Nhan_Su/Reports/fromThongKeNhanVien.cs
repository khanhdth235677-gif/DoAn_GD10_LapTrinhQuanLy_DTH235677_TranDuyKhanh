using Microsoft.Data.SqlClient; 
using Microsoft.Reporting.WinForms; 
using Quan_Ly_Nhan_Su.Data;
using Quan_Ly_Nhan_Su.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Nhan_Su.Reports
{
    public partial class fromThongKeNhanVien : Form
    {
        private QLNSDataContext context = new QLNSDataContext();
        private QLNSDataSet.DanhSachNhanVienDataTable danhSachNhanVienDataTable = new QLNSDataSet.DanhSachNhanVienDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows7.0", "Reports");
        ComboBox cbNhanVien;
        ComboBox cbDuAn;
        Button btnLocKQ;
        Button btnHienTC;
        public fromThongKeNhanVien()
        {
            InitializeComponent();
        }

        private void fromThongKeNhanVien_Load(object sender, EventArgs e)
        {
            SetupReportViewer();   // ✅ tạo trước
            LoadReportData();      // ✅ load sau
            LayTenNhanVienVaoComboBox();
            LayDuAnVaoComboBox();
        }
        public void LayTenNhanVienVaoComboBox()
        {
                var list = context.NhanVien
            .Select(nv => new
            {
                nv.ID,
                nv.HoTen
            }).ToList();

                cbNhanVien.DataSource = list;
                cbNhanVien.DisplayMember = "HoTen";
                cbNhanVien.ValueMember = "ID";
                cbNhanVien.SelectedIndex = -1;
        }
        public void LayDuAnVaoComboBox()
        {
                var list = context.DuAn
           .Select(da => new
           {
               da.ID,
               da.TenDuAn
           }).ToList();

                cbDuAn.DataSource = list;
                cbDuAn.DisplayMember = "TenDuAn";
                cbDuAn.ValueMember = "ID";
                cbDuAn.SelectedIndex = -1;
        }
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
                int idealReportWidth = 1000;
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
        public void LoadReportData()
        {
            try
            {
                var data = context.NhanVien.Select(nv => new
                {
                    ID = nv.ID,
                    MaNV = "NV" + nv.ID.ToString("D3"),
                    HoTen = nv.HoTen ?? "Chưa có tên",
                    TenPhongBan = nv.PhongBan != null ? nv.PhongBan.TenPhongBan : "Chưa có",
                    TenDuAn = nv.PhanCongDuAn.Select(pc => pc.DuAn.TenDuAn).FirstOrDefault() ?? "Không có",
                    VaiTro = nv.PhanCongDuAn.Select(pc => pc.VaiTro).FirstOrDefault() ?? "Nhân viên",
                    GiaTri = nv.PhanCongDuAn.Select(pc => (int?)pc.GiaTri).FirstOrDefault() ?? 0,
                    HinhAnh = nv.HinhAnh ?? ""
                }).ToList();


                danhSachNhanVienDataTable.Clear();


                foreach (var row in data)
                {
                    string hinhAnhChuan = GetImagePath(row.HinhAnh);
                    danhSachNhanVienDataTable.AddDanhSachNhanVienRow(
                        row.ID,
                        row.MaNV,
                        row.HoTen,
                        row.TenPhongBan,
                        row.TenDuAn,
                        row.VaiTro,
                        row.GiaTri,
                        hinhAnhChuan
                    );
                }

                // ✅ QUAN TRỌNG: dùng DataTable, KHÔNG dùng data
                ReportDataSource rds = new ReportDataSource(
                    "DanhSachNhanVienDataset",
                    (DataTable)danhSachNhanVienDataTable
                );

                reportViewer1.Reset();

                reportViewer1.LocalReport.EnableExternalImages = true;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                reportViewer1.LocalReport.ReportPath =
                    Path.Combine(Application.StartupPath, "Reports", "rptThongKeNhanVien.rdlc");

                ReportParameter reportParameter = new ReportParameter("KetQuaHienThi", "(Tất cả sản phẩm)");
                reportViewer1.LocalReport.SetParameters(reportParameter);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
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
            var data = context.NhanVien.Select(nv => new
            {
                ID = nv.ID,
                MaNV = "NV" + nv.ID.ToString("D3"),
                HoTen = nv.HoTen ?? "",
                TenPhongBan = nv.PhongBan.TenPhongBan,
                TenDuAn = nv.PhanCongDuAn.Select(pc => pc.DuAn.TenDuAn).FirstOrDefault() ?? "",
                VaiTro = nv.PhanCongDuAn.Select(pc => pc.VaiTro).FirstOrDefault() ?? "",
                GiaTri = nv.PhanCongDuAn.Select(pc => (int?)pc.GiaTri).FirstOrDefault() ?? 0,
                HinhAnh = nv.HinhAnh ?? ""
            }).ToList();

            danhSachNhanVienDataTable.Clear();

            foreach (var row in data)
            {
                danhSachNhanVienDataTable.AddDanhSachNhanVienRow(
                    row.ID,
                    row.MaNV,
                    row.HoTen,
                    row.TenPhongBan,
                    row.TenDuAn,
                    row.VaiTro,
                    row.GiaTri,
                    row.HinhAnh
                );
            }

            // 3. Gán lại Report
            ReportDataSource rds = new ReportDataSource(
                "DanhSachNhanVienDataset",
                (DataTable)danhSachNhanVienDataTable
            );

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            // (OPTION) reset mô tả
            ReportParameter p = new ReportParameter("KetQuaHienThi", "Tất cả nhân viên");
            reportViewer1.LocalReport.SetParameters(p);

            reportViewer1.RefreshReport();
        }
        private void btnLocKQ_Click(object sender, EventArgs e)
        {
            var query = context.NhanVien.AsQueryable();

            // Lọc theo nhân viên
            if (cbNhanVien.SelectedIndex != -1)
            {
                int nvID = (int)cbNhanVien.SelectedValue;
                query = query.Where(x => x.ID == nvID);
            }

            // Lọc theo dự án
            if (cbDuAn.SelectedIndex != -1)
            {
                int daID = (int)cbDuAn.SelectedValue;

                query = query.Where(nv =>
                    nv.PhanCongDuAn.Any(pc => pc.DuAnID == daID)
                );
            }

            var data = query.Select(nv => new
            {
                ID = nv.ID,
                MaNV = "NV" + nv.ID.ToString("D3"),
                HoTen = nv.HoTen ?? "",
                TenPhongBan = nv.PhongBan.TenPhongBan,
                TenDuAn = nv.PhanCongDuAn.Select(pc => pc.DuAn.TenDuAn).FirstOrDefault() ?? "",
                VaiTro = nv.PhanCongDuAn.Select(pc => pc.VaiTro).FirstOrDefault() ?? "",
                GiaTri = nv.PhanCongDuAn.Select(pc => (int?)pc.GiaTri).FirstOrDefault() ?? 0,
                HinhAnh = nv.HinhAnh ?? ""
            }).ToList();

            danhSachNhanVienDataTable.Clear();

            foreach (var row in data)
            {
                // XỬ LÝ ẢNH TRƯỚC KHI ADD VÀO DATATABLE
                string hinhAnhChuan = GetImagePath(row.HinhAnh);
                danhSachNhanVienDataTable.AddDanhSachNhanVienRow(
                    row.ID,
                    row.MaNV,
                    row.HoTen,
                    row.TenPhongBan,
                    row.TenDuAn,
                    row.VaiTro,
                    row.GiaTri,
                    hinhAnhChuan
                );
            }

            ReportDataSource rds = new ReportDataSource(
                "DanhSachNhanVienDataset",
                (DataTable)danhSachNhanVienDataTable
            );

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
           
        }
        // --- HÀM XỬ LÝ ĐƯỜNG DẪN ẢNH (QUAN TRỌNG) ---
        private string GetImagePath(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) return "";

            // Trỏ tới thư mục Images nằm cùng file chạy
            string folderPath = Path.Combine(Application.StartupPath, "Images");
            string fullPath = Path.Combine(folderPath, fileName);

            if (File.Exists(fullPath))
            {
                // Trả về định dạng file:///D:/...
                return new Uri(fullPath).AbsoluteUri;
            }
            return "";
        }
    }
}
