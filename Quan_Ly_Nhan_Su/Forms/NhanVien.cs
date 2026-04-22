using Quan_Ly_Nhan_Su.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;

namespace Quan_Ly_Nhan_Su.Forms
{
    public partial class NhanVien : Form
    {
        #region 1. Khai báo biến và Khởi tạo Form
        // Khởi tạo đối tượng kết nối cơ sở dữ liệu LINQ to SQL
        QLNSDataContext context = new QLNSDataContext();
        bool xuLyThem = false;
        int id; // Lưu ID nhân viên đang chọn

        // Đường dẫn thư mục ảnh
        string imagesFolder = Path.Combine(Application.StartupPath, @"..\..\..\Images");
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            UIStyle.ApplyStyle(this);
            // Gọi các hàm khởi tạo giao diện và nạp dữ liệu khi form mở lên
            StyleGrid();      // Định dạng DataGridView
            LoadPhongBan();   // Nạp ComboBox tìm kiếm
            LoadNhanVien();   // Nạp bảng danh sách chính
            LoadChucVu();     // Nạp ComboBox chức vụ tìm kiếm

            // Nạp dữ liệu cho các control bên Tab Chi tiết
            LoadPhongBanCT();
            LoadChucVuCT();
            LoadNhanVienCT();

            // Nạp dữ liệu cho Tab Nhân viên - Dự án
            LoadPhongBanDA();
            LoadDuAnDA();
            LoadVaiTro();
            HienThiDanhSach();
            BatTatChucNang(false);
            if (Session.Quyen == "Nhân viên")
            {
                btnLuu.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThemDA.Enabled = false;
                btnSuaDA.Enabled = false;
                btnXoaDA.Enabled = false;
                btnLuuDA.Enabled = false;
            }
        }
        /// <summary>
        /// Tùy chỉnh giao diện hiển thị cho DataGridView (Màu sắc, Font chữ)
        /// </summary>
        private void StyleGrid()
        {
            dgvNhanVien.BorderStyle = BorderStyle.None;
            dgvNhanVien.EnableHeadersVisualStyles = false;

            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvNhanVien.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvNhanVien.DefaultCellStyle.SelectionBackColor = Color.LightGray;

            dgvNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
        }
        #endregion

        #region 2. Xử lý Dữ liệu & Tìm kiếm (Tab Danh sách)

        // Nạp danh sách chức vụ không trùng lặp từ bảng Nhân viên vào ComboBox
        void LoadChucVu()
        {
            var data = context.NhanVien
                .Where(x => x.ChucVu != null && x.ChucVu != "")
                .Select(x => x.ChucVu)
                .Distinct()
                .ToList();

            cbChucVu.DataSource = data;
            cbChucVu.SelectedIndex = -1;
        }

        // Nạp danh sách Phòng ban từ database
        void LoadPhongBan()
        {
            var data = context.PhongBan
             .Select(x => new { x.ID, x.TenPhongBan }).ToList();

            cbPhong.DataSource = data;
            cbPhong.DisplayMember = "TenPhongBan";
            cbPhong.ValueMember = "ID";
            cbPhong.SelectedIndex = -1;
        }

        // Truy vấn dữ liệu nhân viên kết hợp với tên phòng ban (Join)
        void LoadNhanVien()
        {
            var data = context.NhanVien
               .Join(context.PhongBan, nv => nv.PhongBanID, pb => pb.ID, (nv, pb) => new
               {
                   ID = "NV" + nv.ID.ToString("D3"), // Định dạng mã: NV001, NV002...
                   TenPhongBan = pb.TenPhongBan,
                   HoTen = nv.HoTen,
                   NgaySinh = nv.NgaySinh,
                   DiaChi = nv.DiaChi,
                   GioiTinh = nv.GioiTinh,
                   DanToc = nv.DanToc,
                   CCCD = nv.CCCD,
                   NoiCap = nv.NoiCap,
                   ChucVu = nv.ChucVu
               }).ToList();

            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = data;
            dgvNhanVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        // Hàm xử lý tìm kiếm đa điều kiện (Họ tên, Phòng ban, Chức vụ)
        void TimKiem()
        {
            var query = context.NhanVien
                .Join(context.PhongBan, nv => nv.PhongBanID, pb => pb.ID, (nv, pb) => new { nv, pb })
                .AsQueryable();

            if (cbPhong.SelectedValue != null)
            {
                int phongID = Convert.ToInt32(cbPhong.SelectedValue);
                query = query.Where(x => x.nv.PhongBanID == phongID);
            }

            if (!string.IsNullOrWhiteSpace(cbChucVu.Text))
            {
                string chucVu = cbChucVu.Text;
                query = query.Where(x => x.nv.ChucVu.Contains(chucVu));
            }

            if (!string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                string hoTen = txtHoTen.Text;
                query = query.Where(x => x.nv.HoTen.Contains(hoTen));
            }

            var data = query.Select(x => new
            {
                ID = x.nv.ID,
                TenPhongBan = x.pb.TenPhongBan,
                HoTen = x.nv.HoTen,
                NgaySinh = x.nv.NgaySinh,
                DiaChi = x.nv.DiaChi,
                GioiTinh = x.nv.GioiTinh,
                DanToc = x.nv.DanToc,
                CCCD = x.nv.CCCD,
                NoiCap = x.nv.NoiCap,
                ChucVu = x.nv.ChucVu
            }).ToList();

            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = data;
        }

        void ResetForm()
        {
            cbChucVu.SelectedIndex = -1;
            cbPhong.SelectedIndex = -1;
            txtHoTen.Clear();
            LoadNhanVien();
        }
        #endregion

        #region 3. Sự kiện Click Nút (Tab Danh sách)
        private void btnTimKiem_Click(object sender, EventArgs e) => TimKiem();

        private void btnLamMoi_Click(object sender, EventArgs e) => ResetForm();

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn dòng trên Grid chưa
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. GỌI FORM XÁC NHẬN MẬT KHẨU
            frmXacNhanXoa frm = new frmXacNhanXoa();
            frm.StartPosition = FormStartPosition.CenterParent; // Căn giữa màn hình

            // 3. NẾU NGƯỜI DÙNG NHẬP ĐÚNG TÀI KHOẢN & MẬT KHẨU
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lấy mã nhân viên và cắt bỏ chữ "NV" để lấy ID số
                    string maNV = dgvNhanVien.CurrentRow.Cells["ID"].Value.ToString();
                    int id = int.Parse(maNV.Replace("NV", ""));

                    // Tìm nhân viên trong DB
                    var nv = context.NhanVien.Find(id);

                    if (nv != null)
                    {
                        context.NhanVien.Remove(nv);
                        context.SaveChanges();

                        // Thông báo xóa thành công
                        MessageBox.Show("Đã xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu nhân viên này để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Tải lại toàn bộ giao diện theo đúng logic cũ của bạn
                    LoadNhanVien();        // Tab danh sách
                    LoadNhanVienCT();      // Tab chi tiết
                    HienThiDanhSach();     // Tab nhân viên - dự án
                }
                catch (Exception ex)
                {
                    // Bắt lỗi nếu nhân viên đang dính dữ liệu ở các bảng khác (Lương, Chấm công...)
                    MessageBox.Show("Không thể xóa nhân viên này vì dữ liệu đang được sử dụng ở nơi khác (ví dụ: đã có dữ liệu chấm công, tính lương, hoặc dự án).\n\nChi tiết lỗi: " + ex.Message,
                                    "Lỗi hệ thống",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            // Nếu form xác nhận trả về Cancel (bấm Hủy hoặc tắt form) thì code tự động bỏ qua, không xóa gì cả.
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetFormCT();
            txtMaNVCT.Clear();
            btnLuu.Enabled = true;
            tabControl1.SelectedTab = tabNhanVienChiTiet; // Chuyển sang Tab nhập liệu
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
                return;
            }

            string ID = dgvNhanVien.CurrentRow.Cells["ID"].Value.ToString();
            int id = int.Parse(ID.Replace("NV", ""));

            var nv = context.NhanVien.Find(id);
            if (nv == null) return;

            // Đưa dữ liệu từ DB lên các control ở Tab Chi tiết
            txtMaNVCT.Text = "NV" + nv.ID.ToString("D3");
            txtHoTenCT.Text = nv.HoTen;
            txtDiaChiCT.Text = nv.DiaChi;
            txtDanTocCT.Text = nv.DanToc;
            txtCCCDCT.Text = nv.CCCD;
            txtNoiCapCT.Text = nv.NoiCap;
            cbPhongBanCT.SelectedValue = nv.PhongBanID;
            cbChucVuCT.Text = nv.ChucVu;
            dtpNgaySinhCT.Value = nv.NgaySinh;
            if (nv.GioiTinh == "Nam") radNamCT.Checked = true; else radNuCT.Checked = true;

            tabControl1.SelectedTab = tabNhanVienChiTiet;
        }
        #endregion

        #region 4. Tab Nhân viên Chi tiết (Logic Thêm/Sửa/Lưu)
        void LoadPhongBanCT()
        {
            var phong = context.PhongBan.Select(pb => new { pb.ID, pb.TenPhongBan }).ToList();
            cbPhongBanCT.DataSource = phong;
            cbPhongBanCT.DisplayMember = "TenPhongBan";
            cbPhongBanCT.ValueMember = "ID";
        }

        void LoadChucVuCT()
        {
            var data = context.NhanVien
                .Where(x => x.ChucVu != null && x.ChucVu != "")
                .Select(x => x.ChucVu)
                .Distinct()
                .ToList();

            cbChucVuCT.DataSource = data;
            cbChucVuCT.SelectedIndex = -1;
        }

        void LoadNhanVienCT()
        {
            var data = context.NhanVien.Join(context.PhongBan, nv => nv.PhongBanID, pb => pb.ID, (nv, pb) => new
            {
                ID = "NV" + nv.ID.ToString("D3"),
                TenPhongBan = pb.TenPhongBan,
                HoTen = nv.HoTen,
                NgaySinh = nv.NgaySinh,
                DiaChi = nv.DiaChi,
                GioiTinh = nv.GioiTinh,
                DanToc = nv.DanToc,
                CCCD = nv.CCCD,
                NoiCap = nv.NoiCap,
                ChucVu = nv.ChucVu
            }).ToList();

            dgvChiTietNhanVien.AutoGenerateColumns = false;
            dgvChiTietNhanVien.DataSource = data;
            dgvChiTietNhanVien.Columns["NgaySinhCT"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        void ResetFormCT()
        {
            txtMaNVCT.Clear();
            txtHoTenCT.Clear();
            txtDiaChiCT.Clear();
            txtDanTocCT.Clear();
            txtCCCDCT.Clear();
            txtNoiCapCT.Clear();
            cbPhongBanCT.SelectedIndex = 0;
            cbChucVuCT.SelectedIndex = -1;
            radNamCT.Checked = true;
            dtpNgaySinhCT.Value = DateTime.Now;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra rỗng các TextBox bắt buộc
            if (string.IsNullOrWhiteSpace(txtHoTenCT.Text)) { MessageBox.Show("Vui lòng nhập Họ và tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHoTenCT.Focus(); return; }

            // --- ĐOẠN CODE MỚI THÊM VÀO: Kiểm tra Họ tên chỉ chứa chữ cái ---
            if (!txtHoTenCT.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Họ và tên chỉ được chứa chữ cái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenCT.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChiCT.Text)) { MessageBox.Show("Vui lòng nhập Địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtDiaChiCT.Focus(); return; }
            if (string.IsNullOrWhiteSpace(txtDanTocCT.Text)) { MessageBox.Show("Vui lòng nhập Dân tộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtDanTocCT.Focus(); return; }

            // --- ĐOẠN CODE MỚI THÊM VÀO: Kiểm tra Dân tộc chỉ chứa chữ cái ---
            if (!txtDanTocCT.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Dân tộc chỉ được chứa chữ cái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDanTocCT.Focus();
                return;
            }
            // ----------------------------------------------------------------

            if (string.IsNullOrWhiteSpace(txtNoiCapCT.Text)) { MessageBox.Show("Vui lòng nhập Nơi cấp CCCD!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtNoiCapCT.Focus(); return; }

            // 2. Kiểm tra Combobox (Phòng ban, Chức vụ)
            if (cbPhongBanCT.SelectedValue == null || cbPhongBanCT.SelectedIndex == -1) { MessageBox.Show("Vui lòng chọn Phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbPhongBanCT.Focus(); return; }
            if (cbChucVuCT.SelectedValue == null || cbChucVuCT.SelectedIndex == -1) { MessageBox.Show("Vui lòng chọn Chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbChucVuCT.Focus(); return; }

            // 3. Kiểm tra RadioButton (Giới tính)
            if (!radNamCT.Checked && !radNuCT.Checked) { MessageBox.Show("Vui lòng chọn Giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            // 4. Kiểm tra Ngày sinh (Đủ 18 tuổi)
            DateTime ngaySinh = dtpNgaySinhCT.Value;
            if (ngaySinh > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ (không được ở tương lai)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinhCT.Focus();
                return;
            }
            int age = DateTime.Now.Year - ngaySinh.Year;
            if (ngaySinh.Date > DateTime.Now.AddYears(-age)) age--;
            if (age < 18)
            {
                MessageBox.Show("Nhân viên phải từ đủ 18 tuổi trở lên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinhCT.Focus();
                return;
            }

            // 5. Kiểm tra CCCD (Đủ 12 số)
            if (string.IsNullOrWhiteSpace(txtCCCDCT.Text)) { MessageBox.Show("Vui lòng nhập CCCD!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtCCCDCT.Focus(); return; }
            if (txtCCCDCT.Text.Length != 12) { MessageBox.Show("CCCD phải đủ 12 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtCCCDCT.Focus(); return; }
            if (!txtCCCDCT.Text.All(char.IsDigit)) { MessageBox.Show("CCCD chỉ được chứa các chữ số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtCCCDCT.Focus(); return; }

            // 6. Kiểm tra trùng CCCD trong Database
            bool isAddingNew = string.IsNullOrWhiteSpace(txtMaNVCT.Text);

            if (isAddingNew)
            {
                var checkCCCD = context.NhanVien.FirstOrDefault(x => x.CCCD == txtCCCDCT.Text);
                if (checkCCCD != null)
                {
                    MessageBox.Show("CCCD này đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCCCDCT.Focus();
                    return;
                }
            }
            else
            {
                // Ràng buộc khi CẬP NHẬT (Bỏ qua việc check trùng CCCD với chính nhân viên đó)
                var checkCCCD = context.NhanVien.FirstOrDefault(x => x.CCCD == txtCCCDCT.Text);

                if (checkCCCD != null && txtMaNVCT.Text == "") { MessageBox.Show("CCCD đã tồn tại!"); return; }

                if (txtCCCDCT.Text.Length != 12) { MessageBox.Show("CCCD phải đủ 12 số!"); return; }
            }

            // NẾU VƯỢ QUA HẾT CÁC IF TRÊN THÌ THỰC HIỆN LƯU DATABASE Ở ĐÂY...
            if (string.IsNullOrWhiteSpace(txtMaNVCT.Text))
            {
                // Logic THÊM MỚI
                var nv = new Data.NhanVien();
                nv.HoTen = txtHoTenCT.Text;
                nv.DiaChi = txtDiaChiCT.Text;
                nv.DanToc = txtDanTocCT.Text;
                nv.CCCD = txtCCCDCT.Text;
                nv.NoiCap = txtNoiCapCT.Text;
                nv.ChucVu = cbChucVuCT.Text;
                nv.NgaySinh = dtpNgaySinhCT.Value;
                nv.GioiTinh = radNamCT.Checked ? "Nam" : "Nữ";
                nv.PhongBanID = Convert.ToInt32(cbPhongBanCT.SelectedValue);
                context.NhanVien.Add(nv);
            }
            else
            {
                // Logic CẬP NHẬT (SỬA)
                int id = int.Parse(txtMaNVCT.Text.Replace("NV", ""));
                var nv = context.NhanVien.Find(id);
                if (nv == null) return;

                nv.HoTen = txtHoTenCT.Text;
                nv.DiaChi = txtDiaChiCT.Text;
                nv.DanToc = txtDanTocCT.Text;
                nv.CCCD = txtCCCDCT.Text;
                nv.NoiCap = txtNoiCapCT.Text;
                nv.ChucVu = cbChucVuCT.Text;
                nv.NgaySinh = dtpNgaySinhCT.Value;
                nv.GioiTinh = radNamCT.Checked ? "Nam" : "Nữ";
                nv.PhongBanID = Convert.ToInt32(cbPhongBanCT.SelectedValue);
            }

            context.SaveChanges(); // Lưu thay đổi xuống Database
            MessageBox.Show("Lưu thành công!");
            LoadNhanVien();        // Tab danh sách
            LoadNhanVienCT();      // Tab chi tiết
            HienThiDanhSach();     // Tab nhân viên - dự án
            tabControl1.SelectedTab = tabDanhSachNhanVien;
        }

        private void btnHuy_Click(object sender, EventArgs e) => ResetFormCT();

        private void btnQuayLai_Click(object sender, EventArgs e) => tabControl1.SelectedTab = tabDanhSachNhanVien;

        private void dgvChiTietNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChiTietNhanVien.CurrentRow == null) return;
            txtMaNVCT.Text = dgvChiTietNhanVien.CurrentRow.Cells["IDCT"].Value.ToString();
            txtHoTenCT.Text = dgvChiTietNhanVien.CurrentRow.Cells["HoTenCT"].Value.ToString();
        }
        #endregion

        #region 5. Custom UI (Vẽ TabControl)
        /// <summary>
        /// Tự vẽ tiêu đề Tab để có hiệu ứng gạch chân và màu sắc hiện đại hơn
        /// </summary>
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            TabPage tabPage = tabControl1.TabPages[e.Index];
            Rectangle tabRect = tabControl1.GetTabRect(e.Index);
            bool isSelected = (e.Index == tabControl1.SelectedIndex);

            g.FillRectangle(new SolidBrush(Color.White), tabRect);
            Color textColor = isSelected ? Color.Teal : Color.Gray;

            TextRenderer.DrawText(g, tabPage.Text, new Font("Segoe UI", 10, FontStyle.Bold),
                tabRect, textColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            if (isSelected)
            {
                Pen pen = new Pen(Color.Teal, 3);
                g.DrawLine(pen, tabRect.Left + 10, tabRect.Bottom - 2, tabRect.Right - 10, tabRect.Bottom - 2);
            }
        }
        #endregion

        #region 6. Nhân viên - Dự án (Code mới hoàn chỉnh)

        // Hàm bật tắt các control để tránh người dùng bấm nhầm khi đang nhập liệu
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            // Các trường nhập liệu
            txtHoTen.Enabled = !giaTri;
            cbTenPhongBanDA.Enabled = giaTri;
            cbDuAn.Enabled = giaTri;
            cbVaiTro.Enabled = giaTri;
            txtGiaTri.Enabled = giaTri;

            // Các nút chức năng
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnDoiAnh.Enabled = giaTri; // Chỉ cho đổi ảnh khi đang Thêm hoặc Sửa
            btnXoay.Enabled = giaTri;
        }
        private void LoadPhongBanDA()
        {
            cbTenPhongBanDA.DataSource = context.PhongBan.ToList();
            cbTenPhongBanDA.DisplayMember = "TenPhongBan";
            cbTenPhongBanDA.ValueMember = "ID";
            cbTenPhongBanDA.SelectedIndex = -1;
        }

        private void LoadDuAnDA()
        {
            cbDuAn.DataSource = context.DuAn.ToList();
            cbDuAn.DisplayMember = "TenDuAn";
            cbDuAn.ValueMember = "ID";
            cbDuAn.SelectedIndex = -1;
        }
        private void LoadVaiTro()
        {
            // Lấy các tên vai trò không trùng lặp từ bảng phân công dự án
            var danhSachVaiTroDaCo = context.PhanCongDuAn
                                            .Where(pc => !string.IsNullOrEmpty(pc.VaiTro))
                                            .Select(pc => pc.VaiTro)
                                            .Distinct()
                                            .ToList();

            cbVaiTro.DataSource = danhSachVaiTroDaCo;
            cbVaiTro.SelectedIndex = -1;
        }
        private void HienThiDanhSach()
        {
            var data = context.PhanCongDuAn
                .Join(context.NhanVien, pc => pc.NhanVienID, nv => nv.ID, (pc, nv) => new { pc, nv })
                .Join(context.DuAn, x => x.pc.DuAnID, da => da.ID, (x, da) => new { x.pc, x.nv, da })
                .Join(context.PhongBan, x => x.nv.PhongBanID, pb => pb.ID, (x, pb) => new
                {
                    ID = x.pc.ID,
                    NhanVienID = x.nv.ID,
                    MaNV = "NV" + x.nv.ID.ToString("D3"),
                    HoTen = x.nv.HoTen ?? "",
                    TenPhongBan = pb.TenPhongBan ?? "",
                    TenDuAn = x.da.TenDuAn ?? "",
                    VaiTro = x.pc.VaiTro ?? "",
                    GiaTri = x.pc.GiaTri,
                    HinhAnh = x.nv.HinhAnh
                })
                .ToList();

            dgvNhanVienDuAn.AutoGenerateColumns = false;

            // Cột ẩn dùng cho logic (sửa, xóa, lấy ID...)
            dgvNhanVienDuAn.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID",
                DataPropertyName = "ID",
                Visible = false
            });
            dgvNhanVienDuAn.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNhanVienID",
                DataPropertyName = "NhanVienID",
                Visible = false
            });

            // Gán dữ liệu
            dgvNhanVienDuAn.DataSource = data;

            // Xử lý hiển thị ảnh nhỏ (resize 48x48 để gọn gàng)
            foreach (DataGridViewRow row in dgvNhanVienDuAn.Rows)
            {
                if (row.IsNewRow) continue;

                string fileName = row.Cells["HinhAnh"].Value?.ToString();
                if (string.IsNullOrWhiteSpace(fileName)) continue;

                string fullPath = Path.Combine(imagesFolder, fileName);
                if (File.Exists(fullPath))
                {
                    try
                    {
                        using (var original = Image.FromFile(fullPath))
                        {
                            row.Cells["HinhAnh"].Value = new Bitmap(original, 48, 48);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Optional: log lỗi nếu cần
                        // Console.WriteLine("Lỗi load ảnh: " + ex.Message);
                    }
                }
            }

            // Tùy chọn: điều chỉnh độ rộng cột tự động nếu muốn
            // dgvNhanVienDuAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        // Hiển thị ảnh trong grid
        private void dgvNhanVienDuAn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNhanVienDuAn.Columns[e.ColumnIndex].Name == "HinhAnh" && e.Value != null)
            {
                string fileName = e.Value.ToString();
                if (string.IsNullOrWhiteSpace(fileName)) return;

                string fullPath = Path.Combine(imagesFolder, fileName);
                if (File.Exists(fullPath))
                {
                    try
                    {
                        using (Image img = Image.FromFile(fullPath))
                        {
                            e.Value = new Bitmap(img, new Size(48, 48));  // kích thước nhỏ gọn
                        }
                        e.FormattingApplied = true;
                    }
                    catch { }
                }
            }
        }

        // ====================== NÚT THÊM ======================
        private void btnThemDA_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            // Tự động tạo mã NV mới (tăng dần)
            int maxID = 0;
            if (context.NhanVien.Any())
            {
                maxID = context.NhanVien.Max(nv => nv.ID);
            }
            string maMoi = "NV" + (maxID + 1).ToString("D3");  // NV001 → NV002 → ...

            txtMaNV.Text = maMoi;
            txtHoTenNV.Clear();              // Để người dùng nhập tên mới
            cbTenPhongBanDA.SelectedIndex = -1;  // Reset phòng ban
            cbDuAn.SelectedIndex = -1;
            cbVaiTro.SelectedIndex = -1;
            txtGiaTri.Clear();

            // Reset ảnh
            picHinhAnh.Image = null;
            picHinhAnh.ImageLocation = null;

            // Focus vào ô nhập tên nhân viên
            txtHoTenNV.Focus();

            // Optional: Thông báo để người dùng biết đang tạo nhân viên mới
            MessageBox.Show($"Đang thêm nhân viên mới với mã: {maMoi}\nVui lòng nhập đầy đủ thông tin!",
                            "Thêm mới", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ====================== NÚT SỬA ======================
        private void btnSuaDA_Click(object sender, EventArgs e)
        {
            if (dgvNhanVienDuAn.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            xuLyThem = false;
            BatTatChucNang(true);

            DataGridViewRow row = dgvNhanVienDuAn.CurrentRow;

            // Đổ dữ liệu từ dòng được chọn
            txtMaNV.Text = row.Cells["MaNV"].Value?.ToString() ?? "";
            txtMaNV.ReadOnly = true; // Không cho sửa mã khi sửa

            txtHoTenNV.Text = row.Cells["HoTenColumn"].Value?.ToString() ?? "";           // ← tên cột Họ tên NV
            cbTenPhongBanDA.Text = row.Cells["TenPhongBanColumn"].Value?.ToString() ?? ""; // ← tên cột Phòng ban

            // Dự án: dùng cột ẩn colDuAnID
            if (row.Cells["colID"] != null && row.Cells["colID"].Value != null)
            {
                cbDuAn.SelectedValue = Convert.ToInt32(row.Cells["colID"].Value);
            }
            else
            {
                cbDuAn.SelectedIndex = -1;
            }
            cbDuAn.Text = row.Cells["TenDuAn"].Value?.ToString() ?? "";
            cbVaiTro.Text = row.Cells["VaiTro"].Value?.ToString() ?? "";
            txtGiaTri.Text = row.Cells["GiaTri"].Value?.ToString() ?? "";

            // Ảnh
            string hinh = row.Cells["HinhAnh"].Value?.ToString();
            if (!string.IsNullOrEmpty(hinh))
            {
                string fullPath = Path.Combine(imagesFolder, hinh);
                if (File.Exists(fullPath))
                {
                    picHinhAnh.ImageLocation = fullPath;
                    picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    picHinhAnh.Image = null;
                }
            }
            else
            {
                picHinhAnh.Image = null;
            }

            // Lưu ID phân công để sửa
            id = Convert.ToInt32(row.Cells["colID"].Value ?? 0);
        }

        // ====================== NÚT LƯU ======================
        private void btnLuuDA_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
            {
                return;
            }

            // 2. NẾU KIỂM TRA THÀNH CÔNG, MỚI BẮT ĐẦU LƯU
            try
            {
                if (xuLyThem)
                {
                    // 1. Kiểm tra phòng ban hợp lệ để tránh lỗi FK (Foreign Key)
                    if (cbTenPhongBanDA.SelectedValue == null)
                    {
                        MessageBox.Show("Vui lòng chọn Phòng ban hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int selectedPBID = Convert.ToInt32(cbTenPhongBanDA.SelectedValue);

                    // 2. Tạo đối tượng NhanVien (Chỉ rõ Namespace để tránh trùng với tên cột HoTen)
                    // Thay 'Quan_Ly_Nhan_Su.Data' bằng namespace thực tế của project bạn
                    var nvDb = new Quan_Ly_Nhan_Su.Data.NhanVien
                    {
                        HoTen = txtHoTenNV.Text.Trim(),
                        PhongBanID = selectedPBID
                    };
                    // 3. Xử lý lưu tên file ảnh (nếu người dùng có chọn ảnh)
                    if (!string.IsNullOrEmpty(picHinhAnh.ImageLocation))
                    {
                        string sourcePath = picHinhAnh.ImageLocation;
                        string fileName = Path.GetFileName(sourcePath);
                        nvDb.HinhAnh = fileName; // Chỉ lưu tên file vào DB

                        // Copy ảnh vào thư mục Images của project nếu chưa có
                        string destPath = Path.Combine(imagesFolder, fileName);
                        if (!File.Exists(destPath))
                        {
                            File.Copy(sourcePath, destPath);
                        }
                    }
                    context.NhanVien.Add(nvDb);
                    context.SaveChanges(); // Lưu để SQL sinh ra ID tự động

                    // 3. Lấy ID vừa sinh ra để tạo Phân Công
                    int nhanVienIDMoi = nvDb.ID;

                    var pcMoi = new Quan_Ly_Nhan_Su.Data.PhanCongDuAn
                    {
                        NhanVienID = nhanVienIDMoi,
                        DuAnID = Convert.ToInt32(cbDuAn.SelectedValue),
                        VaiTro = cbVaiTro.Text.Trim(),
                        GiaTri = Convert.ToInt32(txtGiaTri.Text)
                    };

                    context.PhanCongDuAn.Add(pcMoi);
                }
                else
                {
                    // SỬA: Cập nhật phân công cũ
                    var pc = context.PhanCongDuAn.Find(id);
                    if (pc == null)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu để sửa!", "Lỗi");
                        return;
                    }

                    pc.DuAnID = Convert.ToInt32(cbDuAn.SelectedValue);
                    pc.VaiTro = cbVaiTro.Text.Trim();
                    pc.GiaTri = Convert.ToInt32(txtGiaTri.Text);

                    // Cập nhật lại thông tin nhân viên liên quan
                    int nhanVienID = int.Parse(txtMaNV.Text.Replace("NV", ""));
                    var nv = context.NhanVien.Find(nhanVienID);
                    if (nv != null)
                    {
                        nv.HoTen = txtHoTenNV.Text.Trim();
                        if (cbTenPhongBanDA.SelectedValue != null)
                            nv.PhongBanID = Convert.ToInt32(cbTenPhongBanDA.SelectedValue);
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSach();
                BatTatChucNang(false);
                xuLyThem = false;
                ResetFormPhanCong();
            }
            catch (Exception ex)
            {
                // Hiển thị chi tiết lỗi InnerException nếu có (giúp debug lỗi SQL nhanh hơn)
                string errorDetail = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Lỗi khi lưu: " + errorDetail, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ====================== NÚT XÓA ======================
        private void btnXoaDA_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem đã chọn dòng cần xóa chưa
            if (dgvNhanVienDuAn.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. GỌI FORM XÁC NHẬN MẬT KHẨU (Thay thế cho MessageBox cũ)
            frmXacNhanXoa frm = new frmXacNhanXoa();
            frm.StartPosition = FormStartPosition.CenterParent; // Tự động căn giữa màn hình hiện tại

            // 3. NẾU NGƯỜI DÙNG NHẬP ĐÚNG TÀI KHOẢN & MẬT KHẨU (Form trả về DialogResult.OK)
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lấy ID và tiến hành xóa dữ liệu
                    int phanCongID = Convert.ToInt32(dgvNhanVienDuAn.CurrentRow.Cells["colID"].Value);
                    var pc = context.PhanCongDuAn.Find(phanCongID);

                    if (pc != null)
                    {
                        context.PhanCongDuAn.Remove(pc);
                        context.SaveChanges();
                        MessageBox.Show("Đã xóa phân công dự án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Tải lại DataGridView để cập nhật danh sách mới
                    HienThiDanhSach();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi trong quá trình xóa dữ liệu: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Ngược lại, nếu nhập sai hoặc bấm nút Hủy thì code sẽ tự động bỏ qua phần xóa.
        }

        // ====================== NÚT HỦY ======================
        private void btnHuyBo_Click(object sender, EventArgs e)   // ← tên nút theo giao diện của bạn
        {
            ResetFormPhanCong();
            BatTatChucNang(false);
            xuLyThem = false;
        }

        // ====================== NÚT ĐỔI ẢNH ======================
        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên trước khi đổi ảnh!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.png;*.jpeg;*.gif";
            openFile.Title = "Chọn ảnh nhân viên";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = openFile.FileName;
                string fileName = Path.GetFileName(sourcePath);           // chỉ lấy tên file
                string destPath = Path.Combine(imagesFolder, fileName);

                // Copy ảnh vào thư mục Images (để sau này grid vẫn hiển thị được)
                try
                {
                    File.Copy(sourcePath, destPath, true);   // ghi đè nếu đã có
                }
                catch { }

                // Hiển thị ngay trên PictureBox
                picHinhAnh.ImageLocation = destPath;

                // Lưu tên ảnh vào bảng NhanVien (để dữ liệu được lưu vĩnh viễn)
                int nhanVienID = int.Parse(txtMaNV.Text.Replace("NV", ""));
                var nv = context.NhanVien.Find(nhanVienID);
                if (nv != null)
                {
                    nv.HinhAnh = fileName;
                    context.SaveChanges();

                    MessageBox.Show("Đổi ảnh thành công và đã lưu vào database!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HienThiDanhSach();   // reload grid để thấy ảnh mới
                }
            }
        }

        // ====================== HÀM HỖ TRỢ ======================
        private bool KiemTraDuLieu()
        {
            // 1. Kiểm tra Tên nhân viên (Rỗng và chỉ chứa chữ cái + khoảng trắng)
            if (string.IsNullOrWhiteSpace(txtHoTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenNV.Focus();
                return false;
            }
            if (!txtHoTenNV.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Tên nhân viên chỉ được chứa chữ cái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenNV.Focus();
                return false;
            }

            // 2. Kiểm tra Giá trị (Rỗng và chỉ chứa số)
            if (string.IsNullOrWhiteSpace(txtGiaTri.Text))
            {
                MessageBox.Show("Vui lòng nhập Giá trị dự án/lương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaTri.Focus();
                return false;
            }
            if (!txtGiaTri.Text.All(char.IsDigit))
            {
                MessageBox.Show("Giá trị chỉ được phép nhập số (không chứa chữ hoặc ký tự đặc biệt)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaTri.Focus();
                return false;
            }

            // 3. Kiểm tra Combobox Phòng ban
            if (cbTenPhongBanDA.SelectedValue == null || cbTenPhongBanDA.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbTenPhongBanDA.Focus();
                return false;
            }

            // 4. Kiểm tra Combobox Dự án
            if (cbDuAn.SelectedValue == null || cbDuAn.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Dự án!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbDuAn.Focus();
                return false;
            }

            // 5. Kiểm tra Vai trò (Dựa theo code bạn dùng cbVaiTro.Text nên có thể người dùng tự gõ hoặc chọn)
            if (string.IsNullOrWhiteSpace(cbVaiTro.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Vai trò trong dự án!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbVaiTro.Focus();
                return false;
            }

            // 6. Kiểm tra Mã nhân viên khi CẬP NHẬT (Không được để trống mã NV)
            if (!xuLyThem && string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Không xác định được Mã nhân viên để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Vượt qua hết các bài kiểm tra thì trả về true cho phép Lưu
            return true;
        }
        private void ResetFormPhanCong()
        {
            txtMaNV.Clear();
            txtHoTenNV.Clear();
            cbTenPhongBanDA.SelectedIndex = -1;
            cbDuAn.SelectedIndex = -1;
            cbVaiTro.SelectedIndex = -1;
            txtGiaTri.Clear();
            picHinhAnh.ImageLocation = null;
            picHinhAnh.Image = null;
        }

        #endregion

        #region 7. Tab Nhân viên - Dự án - Sự kiện CellClick (đổ dữ liệu khi click dòng)
        private void dgvNhanVienDuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bỏ qua nếu click vào header hoặc không có dòng nào
            if (e.RowIndex < 0 || dgvNhanVienDuAn.CurrentRow == null) return;

            DataGridViewRow row = dgvNhanVienDuAn.CurrentRow;

            // Đổ dữ liệu lên các ô nhập liệu
            txtMaNV.Text = row.Cells["MaNV"].Value?.ToString() ?? "";
            txtHoTenNV.Text = row.Cells["HoTenColumn"].Value?.ToString() ?? "";
            cbTenPhongBanDA.Text = row.Cells["TenPhongBanColumn"].Value?.ToString() ?? "";
            // ComboBox Dự án - dùng cột ẩn để lấy ID dự án
            // → Kiểm tra tên cột ẩn chính xác (thường là "colDuAnID" hoặc "DuAnID")
            string colDuAnID_Name = "colDuAnID";  // ← Nếu tên cột khác, sửa ở đây (ví dụ: "DuAnID", "colDuAn", "DuAnColumn")

            if (dgvNhanVienDuAn.Columns.Contains(colDuAnID_Name) &&
                row.Cells[colDuAnID_Name].Value != null &&
                row.Cells[colDuAnID_Name].Value != DBNull.Value)
            {
                cbDuAn.SelectedValue = Convert.ToInt32(row.Cells[colDuAnID_Name].Value);
            }
            else
            {
                cbDuAn.SelectedIndex = -1;  // Không tìm thấy → reset
            }
            cbVaiTro.Text = row.Cells["VaiTro"].Value?.ToString() ?? "";
            txtGiaTri.Text = row.Cells["GiaTri"].Value?.ToString() ?? "";
            // Hiển thị ảnh vào PictureBox
            string fileName = row.Cells["HinhAnh"].Value?.ToString();
            if (!string.IsNullOrWhiteSpace(fileName))
            {
                string fullPath = Path.Combine(imagesFolder, fileName);
                if (File.Exists(fullPath))
                {
                    try
                    {
                        picHinhAnh.ImageLocation = fullPath;
                        picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom; // hoặc StretchImage nếu muốn
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể load ảnh: " + ex.Message);
                        picHinhAnh.Image = null;
                    }
                }
                else
                {
                    picHinhAnh.Image = null; // hoặc ảnh mặc định
                }
            }
            else
            {
                picHinhAnh.Image = null;
            }

            // Optional: Chuyển trạng thái sang "Sửa" (nếu bạn muốn tự động sẵn sàng sửa)
            // xuLyThem = false;
            // BatTatChucNang(true);
            // id = Convert.ToInt32(row.Cells["colID"].Value); // lưu ID phân công để sửa
        }
        #endregion

        #region 8. Tab Nhân viên - Dự án - Nút Hủy / Reset form
        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            ResetFormPhanCong();
            BatTatChucNang(false);
            xuLyThem = false;
            if (dgvNhanVienDuAn.CurrentRow != null)
            {
                dgvNhanVienDuAn.CurrentRow.Selected = false;
            }
        }
        #endregion

        #region 9. Xuất Excel - Danh sách nhân viên (btnExcel_Click)
        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất danh sách nhân viên ra Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "NhanVien_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();

                    table.Columns.AddRange(new DataColumn[]
                    {
            new DataColumn("MaNV"),
            new DataColumn("TenPhong"),
            new DataColumn("HoTen"),
            new DataColumn("NgaySinh"),
            new DataColumn("DiaChi"),
            new DataColumn("GioiTinh"),
            new DataColumn("DanToc"),
            new DataColumn("CCCD"),
            new DataColumn("NoiCap"),
            new DataColumn("ChucVu")
                    });

                    var dsNhanVien = context.NhanVien
                        .Include(nv => nv.PhongBan)
                        .ToList();


                    foreach (var nv in dsNhanVien)
                    {
                        table.Rows.Add(
                            nv.ID,
                            nv.PhongBan?.TenPhongBan,     // nếu có liên kết bảng Phòng
                            nv.HoTen,
                            nv.NgaySinh.ToString("dd/MM/yyyy"),
                            nv.DiaChi,
                            nv.GioiTinh,
                            nv.DanToc,
                            nv.CCCD,
                            nv.NoiCap,
                            nv.ChucVu   // nếu có liên kết bảng Chức vụ
                        );
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhanVien");

                        // 🔥 Format đẹp hơn
                        sheet.Row(1).Style.Font.Bold = true; // tiêu đề in đậm
                        sheet.Columns().AdjustToContents(); // auto size

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

        #region 10. Xuất Excel - Nhân viên theo dự án (btnXuatDA_Click)
        private void btnXuatDA_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất Nhân viên - Dự án";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "NhanVien_DuAn_" + DateTime.Now.ToString("dd_MM_yyyy");

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();

                    table.Columns.Add("MaNV");
                    table.Columns.Add("HoTen");
                    table.Columns.Add("PhongBan");
                    table.Columns.Add("DuAn");
                    table.Columns.Add("VaiTro");
                    table.Columns.Add("GiaTri");
                    table.Columns.Add("HinhAnh");

                    // 🔥 Include để lấy dữ liệu liên kết
                    var ds = context.PhanCongDuAn
                        .Include(pc => pc.NhanVien)
                            .ThenInclude(nv => nv.PhongBan)
                        .Include(pc => pc.DuAn)
                        .ToList();

                    foreach (var pc in ds)
                    {
                        table.Rows.Add(
                            pc.NhanVien?.ID,
                            pc.NhanVien?.HoTen,
                            pc.NhanVien?.PhongBan?.TenPhongBan,
                            pc.DuAn?.TenDuAn,
                            pc.VaiTro,
                            pc.GiaTri,
                            pc.NhanVien?.HinhAnh // có thể là đường dẫn ảnh
                        );
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhanVien_DuAn");

                        // 🔥 Format đẹp
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
        #region 11. Nút xoay ảnh (btnXoay_Click) - Xoay 90 độ theo chiều kim đồng hồ
        private void btnXoay_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem PictureBox hiện tại có đang chứa ảnh nào không
            if (picHinhAnh.Image != null)
            {
                // 2. Thực hiện xoay ảnh 90 độ theo chiều kim đồng hồ (sang phải)
                picHinhAnh.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

                // 3. Làm mới PictureBox để hiển thị ngay lập tức hình ảnh sau khi xoay
                picHinhAnh.Refresh();
            }
            else
            {
                // Báo lỗi nhẹ nhàng nếu người dùng bấm xoay khi chưa chọn ảnh
                MessageBox.Show("Chưa có hình ảnh nào để xoay!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}