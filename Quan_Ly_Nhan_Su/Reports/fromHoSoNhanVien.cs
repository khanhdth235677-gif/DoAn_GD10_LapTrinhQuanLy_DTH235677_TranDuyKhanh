using Microsoft.Reporting.WinForms;
using Quan_Ly_Nhan_Su.Data;
using Quan_Ly_Nhan_Su.Forms;
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
    public partial class fromHoSoNhanVien : Form
    {
        #region === FIELD / BIẾN TOÀN CỤC ===
        private QLNSDataContext context = new QLNSDataContext();
        private QLNSDataSet.HoSoNhanVienDatasetDataTable hoSoNhanVienDataTable = new QLNSDataSet.HoSoNhanVienDatasetDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows7.0", "Reports");
        // Khai báo các biến UI
        private ComboBox cbNhanVien;
        private Button btnIn;
        private Panel pnlFilter;
        private Panel pnlContent;
        private Panel pnlReportWrapper;
        private int _idNhanVienBanDau;
        #endregion
        #region === CONSTRUCTOR ===
        public fromHoSoNhanVien(int id = 59)
        {
            InitializeComponent();
            this._idNhanVienBanDau = id;
        }
        #endregion
        #region === FORM LOAD ===
        private void fromHoSoNhanVien_Load(object sender, EventArgs e)
        {
            // 1. Xây dựng giao diện bằng code
            SetupReportViewer();

            // 2. Đổ dữ liệu vào ComboBox
            LoadComboBoxNhanVien();

            // 3. Chọn nhân viên mặc định và hiển thị báo cáo lần đầu
            cbNhanVien.SelectedValue = _idNhanVienBanDau;
            LoadHoSoNhanVien(_idNhanVienBanDau);
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

            Label lblNhanVien = new Label() { Text = "Mã nhân viên:", Left = 0, Top = 10, AutoSize = true };
            cbNhanVien = new ComboBox() { Left = 100, Top = 7, Width = 250, DropDownStyle = ComboBoxStyle.DropDownList };

            // Nút bấm
            btnIn = new Button() { Text = "IN KẾT QUẢ", Left = 400, Top = 3, Width = 120, Height = 35, Cursor = Cursors.Hand, Font = fontButton, BackColor = Color.FromArgb(0, 122, 204), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
            btnIn.FlatAppearance.BorderSize = 0;

            pnlContent.Controls.AddRange(new Control[] { lblNhanVien, cbNhanVien, btnIn });
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
                int idealReportWidth = 890;
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
            btnIn.Click += btnIn_Click;

            // Thêm các Panel vào Form theo đúng thứ tự
            this.Controls.Add(pnlReportWrapper); // Add Fill trước
            this.Controls.Add(pnlFilter);         // Add Top sau

            // Gọi lần đầu để tính toán vị trí ngay khi mở Form
            UpdateLayoutPositions();
        }
        #endregion
        #region === LOAD COMBOBOX NHÂN VIÊN ===
        private void LoadComboBoxNhanVien()
        {
            try
            {
                var ds = context.NhanVien
                    .OrderBy(x => x.ID)
                    .Select(x => new {
                        ID = x.ID,
                        HienThi = "NV" + x.ID.ToString("D3") + " - " + x.HoTen
                    }).ToList();

                cbNhanVien.DataSource = ds;
                cbNhanVien.DisplayMember = "HienThi";
                cbNhanVien.ValueMember = "ID";
            }
            catch (Exception ex) { MessageBox.Show("Lỗi ComboBox: " + ex.Message); }
        }
        #endregion
        #region === LOAD HỒ SƠ NHÂN VIÊN ===
        public void LoadHoSoNhanVien(int idNhanVien)
        {
            try
            {
                // 1. Lấy dữ liệu nhân viên
                var nv = context.NhanVien
                    .Where(x => x.ID == idNhanVien)
                    .Select(x => new {
                        x.ID,
                        x.HoTen,
                        x.ChucVu,
                        x.NgaySinh,
                        x.GioiTinh,
                        x.CCCD,
                        x.DiaChi,
                        x.NoiCap,
                        x.DanToc,
                        x.DienThoai,
                        x.Email,
                        x.NgayVaoLam,
                        x.TrangThai,
                        x.HinhAnh,
                        TenPhongBan = x.PhongBan != null ? x.PhongBan.TenPhongBan : ""
                    }).FirstOrDefault();

                if (nv == null) return;
                #region === XỬ LÝ ẢNH NHÂN VIÊN ===

                string fileName = nv.HinhAnh;

                // 2. Tạo đường dẫn tuyệt đối đến thư mục chứa ảnh của bạn
                // Ví dụ: Thư mục Images nằm trong bin/Debug
                string folderPath = Path.Combine(Application.StartupPath, "Images");
                string fullPath = Path.Combine(folderPath, fileName);

                string pathHinhAnh = "";

                // 3. Kiểm tra xem file có thực sự tồn tại ở đường dẫn đó không
                if (!string.IsNullOrEmpty(fileName) && File.Exists(fullPath))
                {
                    // Chuyển thành định dạng chuẩn file:///D:/...
                    pathHinhAnh = new Uri(fullPath).AbsoluteUri;
                }
                else
                {
                    // Nếu không tìm thấy, bạn có thể gán một ảnh mặc định "no-image.png"
                    MessageBox.Show("Không tìm thấy file ảnh tại: " + fullPath);
                }

                // 2. Đổ dữ liệu vào DataTable
                hoSoNhanVienDataTable.Clear();
                hoSoNhanVienDataTable.AddHoSoNhanVienDatasetRow(
                    nv.ID, nv.HoTen, nv.ChucVu, nv.TenPhongBan, nv.NgaySinh,
                    nv.GioiTinh, nv.CCCD, nv.DiaChi, nv.NoiCap, nv.DanToc,
                    nv.DienThoai, nv.Email, nv.NgayVaoLam, nv.TrangThai,
                    pathHinhAnh, // Truyền chuỗi đã có file:/// vào đây
                    "NV" + nv.ID.ToString("D3")
                );

                // 3. Cấu hình ReportViewer
                reportViewer1.Reset();

                // BẬT CÁI NÀY LÊN THÌ ẢNH MỚI HIỆN
                reportViewer1.LocalReport.EnableExternalImages = true;

                string rdlcPath = Path.Combine(Application.StartupPath, "Reports", "rptInHoSoNhanVien.rdlc");
                reportViewer1.LocalReport.ReportPath = rdlcPath;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("HoSoNhanVienDataset", (DataTable)hoSoNhanVienDataTable));

                reportViewer1.RefreshReport();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        #endregion
        #region === BUTTON: IN KẾT QUẢ ===
        private void btnIn_Click(object sender, EventArgs e)
        {
            // Khi nhấn nút, lấy ID từ ComboBox và nạp lại báo cáo
            if (cbNhanVien.SelectedValue != null)
            {
                int idSelected = (int)cbNhanVien.SelectedValue;
                LoadHoSoNhanVien(idSelected);
            }
        }
        #endregion
    }
}
