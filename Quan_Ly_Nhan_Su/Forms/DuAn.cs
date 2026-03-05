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
        QLNSDataContext context = new QLNSDataContext();
        bool xuLyThem = false;
        int id;
        public DuAn()
        {
            InitializeComponent();
        }

        private void DuAn_Load(object sender, EventArgs e)
        {
            // Load dữ liệu cho ComboBox tìm kiếm
            LoadComboTimKiem();

            // Load ComboBox phòng ban
            LoadComboPhongBan();

            // Hiển thị toàn bộ danh sách ban đầu
            LoadAllDuAn();

            tabControl1.SelectedTab = tabDanhSachDuAn;  // mở tab danh sách đầu tiên
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
        // ───────────────────────────────────────────────
        // Load dữ liệu cho ComboBox Mã DA và Tên DA (từ DB)
        // ───────────────────────────────────────────────
        private void LoadComboTimKiem()
        {
            // Lấy danh sách dự án duy nhất để tránh trùng
            var duAnList = context.DuAn
                .Where(d => !string.IsNullOrEmpty(d.MaDuAn) || !string.IsNullOrEmpty(d.TenDuAn))
                .Select(d => new
                {
                    d.MaDuAn,
                    d.TenDuAn
                })
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
        // ───────────────────────────────────────────────
        // Load ComboBox Tên phòng ban
        // ───────────────────────────────────────────────
        private void LoadComboPhongBan()
        {
            var phongBans = context.PhongBan
                .Select(p => new { p.ID, p.TenPhongBan })
                .ToList();

            cbTenPhongBan.DataSource = phongBans;
            cbTenPhongBan.DisplayMember = "TenPhongBan";
            cbTenPhongBan.ValueMember = "ID";
            cbTenPhongBan.SelectedIndex = -1;
        }
        // ───────────────────────────────────────────────
        // Load toàn bộ danh sách dự án ban đầu
        // ───────────────────────────────────────────────
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
                           TienDo = da.TienDo,
                           TinhTrang = da.TinhTrang,
                           GhiChu = da.GhiChu
                       };

            dgvDanhSachDuAn.DataSource = data.ToList();
        }

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
                            TienDo = da.TienDo,
                            TinhTrang = da.TinhTrang,
                            GhiChu = da.GhiChu,

                            // Thêm dòng này để có thể lọc theo phòng ban
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

            // Lọc theo Tên phòng ban - giờ đã có PhongBanID
            if (cbTenPhongBan.SelectedValue != null)
            {
                int phongID = Convert.ToInt32(cbTenPhongBan.SelectedValue);
                query = query.Where(x => x.PhongBanID == phongID);  // ← giờ hợp lệ
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
            Cursor = Cursors.WaitCursor; // con trỏ chờ
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
                Cursor = Cursors.Default; // trả lại con trỏ bình thường
            }
        }
        private void ResetForm()
        {
            // Xóa trắng các TextBox
            txtTenDuAn.Clear();
            txtTenKhachHang.Clear();
            txtGiaTri.Clear();
            txtTienDo.Clear();
            txtGhiChu.Clear();

            // Reset DateTimePicker về ngày hiện tại (hoặc giá trị mặc định bạn muốn)
            dtNgayBD.Value = DateTime.Today;
            dtNgayKTDK.Value = DateTime.Today;
            dtNgayKTTT.Value = DateTime.Today.AddMonths(3); // ví dụ: mặc định +3 tháng

            // Reset CheckBox
            chkHoanThanh.Checked = false;

            // Reset ComboBox
            if (cbTenNhanVienQL.Items.Count > 0)
                cbTenNhanVienQL.SelectedIndex = -1;

            if (cbPhongBan.Items.Count > 0)
                cbPhongBan.SelectedIndex = -1;

            // Focus vào trường đầu tiên
            txtTenDuAn.Focus();

            // (Tùy chọn) Reset biến trạng thái
            xuLyThem = true;
            id = 0;

            // (Tùy chọn) Đổi tiêu đề form hoặc label để rõ ràng
            this.Text = "Quản lý dự án - Thêm dự án mới";
            // lblTieuDe.Text = "THÊM DỰ ÁN MỚI";   // nếu bạn có label tiêu đề
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Chuyển sang tab nhập liệu / phân công
            tabControl1.SelectedTab = tabPhanCongDuAn; // Chuyển sang Tab nhập liệu

            // Reset toàn bộ form về trạng thái thêm mới
            ResetForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachDuAn.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dự án cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã dự án từ cột (giả sử cột tên "MaDA")
            string maDA = dgvDanhSachDuAn.CurrentRow.Cells["MaDA"].Value?.ToString()?.Trim();

            if (string.IsNullOrWhiteSpace(maDA))
            {
                MessageBox.Show("Không tìm thấy mã dự án!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tìm dự án theo MaDuAn (giả sử MaDuAn là unique)
            var duAn = context.DuAn.FirstOrDefault(d => d.MaDuAn == maDA);

            if (duAn == null)
            {
                MessageBox.Show("Không tìm thấy thông tin dự án!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chuyển sang tab chi tiết / nhập liệu
            tabControl1.SelectedTab = tabPhanCongDuAn;  // thay bằng tên tab thực tế của bạn

            // Đưa dữ liệu lên form (giả sử bạn có các control sau ở tab nhập liệu)
            txtMaDA.Text = duAn.MaDuAn;                    // giữ nguyên mã để biết là sửa
            txtTenDuAn.Text = duAn.TenDuAn ?? "";
            txtTenKhachHang.Text = duAn.KhachHang ?? "";
            txtGiaTri.Text = duAn.GiaTriHopDong?.ToString("N0") ?? "";
            txtTienDo.Text = duAn.TienDo ?? "";
            txtGhiChu.Text = duAn.GhiChu ?? "";

            dtNgayBD.Value = duAn.NgayBatDau ?? DateTime.Today;
            dtNgayKTDK.Value = duAn.NgayKetThucDuKien ?? DateTime.Today;
            dtNgayKTTT.Value = duAn.NgayKetThucThucTe ?? DateTime.Today;

            chkHoanThanh.Checked = (duAn.TinhTrang == "Hoàn thành" || duAn.TinhTrang == "1");

            // ComboBox phòng ban
            if (duAn.PhongBanID.HasValue)
                cbTenPhongBan.SelectedValue = duAn.PhongBanID.Value;
            else
                cbTenPhongBan.SelectedIndex = -1;

            // ComboBox nhân viên quản lý (nếu có)
            if (duAn.NguoiQuanLyID.HasValue)
                cbTenNhanVienQL.SelectedValue = duAn.NguoiQuanLyID.Value;
            else
                cbTenNhanVienQL.SelectedIndex = -1;

            // Focus vào tên dự án
            txtTenDuAn.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra ràng buộc dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtTenDuAn.Text)) { MessageBox.Show("Vui lòng nhập tên dự án!"); txtTenDuAn.Focus(); return; }
            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text)) { MessageBox.Show("Vui lòng nhập tên khách hàng!"); txtTenKhachHang.Focus(); return; }
            if (cbTenPhongBan.SelectedValue == null) { MessageBox.Show("Vui lòng chọn phòng ban!"); cbTenPhongBan.Focus(); return; }

            if (string.IsNullOrWhiteSpace(txtMaDA.Text))
            {
                // Logic THÊM MỚI
                var da = new Data.DuAn();
                da.MaDuAn = txtMaDA.Text;
                da.TenDuAn = txtTenDuAn.Text;
                da.KhachHang = txtTenKhachHang.Text;
                da.NguoiQuanLyID = cbTenNhanVienQL.Text;
                da.PhongBan = cbPhongBan.Text;
                da.NgayBatDau = dtNgayBD.Text;
                da.NgayKetThucDuKien = dtpNgaySinhCT.Value;
                da.NgayKetThucThucTe = radNamCT.Checked ? "Nam" : "Nữ";
                da.GiaTriHopDong = Convert.ToInt32(cbPhongBanCT.SelectedValue);
                da.TienDo = Convert.ToInt32(cbPhongBanCT.SelectedValue);
                da.TinhTrang = "Đang thực hiện"; // mặc định khi thêm mới
                da.GhiChu = txtGhiChu.Text;

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
            LoadNhanVien();
            LoadNhanVienCT();
            tabControl1.SelectedTab = tabDanhSachNhanVien;
        }
    }
}
