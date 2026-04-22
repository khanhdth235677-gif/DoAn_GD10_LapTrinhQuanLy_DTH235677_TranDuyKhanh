using DocumentFormat.OpenXml.InkML;
using Guna.UI2.WinForms;
using Quan_Ly_Nhan_Su.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Nhan_Su.Forms
{
    public partial class FormLogin : Form
    {
        #region === FIELD / BIẾN TOÀN CỤC ===
        QLNSDataContext context = new QLNSDataContext();
        // Cấu hình màu sắc chuyên nghiệp
        Color primaryColor = Color.FromArgb(52, 152, 219); // Xanh dương
        Color placeholderColor = Color.Gray;
        Color textColor = Color.Black;
        #endregion
        #region === DLL IMPORT (BO GÓC FORM) ===
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeft, int nTop, int nRight, int nBottom, int nWidth, int nHeight);
        #endregion
        #region === FORM LOAD OVERRIDE ===
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // 1. Bo góc toàn bộ Form
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));

            // 2. Định dạng các nút và panel
            StyleLoginElements();
        }
        #endregion
        #region === SETUP UI (PLACEHOLDER) ===
        private void SetupUI()
        {
            // Thiết lập ban đầu cho TextBox để làm Placeholder
            txtUsername.Text = "Tên đăng nhập";
            txtUsername.ForeColor = placeholderColor;

            txtPassword.Text = "Mật khẩu";
            txtPassword.ForeColor = placeholderColor;
            txtPassword.UseSystemPasswordChar = false; // Hiện chữ "Mật khẩu"
        }
        #endregion
        #region === CONSTRUCTOR ===
        public FormLogin()
        {
            InitializeComponent();
            // BONUS
            this.AcceptButton = btnDangNhap;
            this.CancelButton = btnThoat;
            SetupUI();
        }
        #endregion
        #region === EVENT: SHOW/HIDE PASSWORD ===
        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
        }
        #endregion
        #region === EVENT: THOÁT ===
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region === HASH PASSWORD ===
        // 🔐 Hàm mã hóa mật khẩu
        string Hash(string input)
        {
            using (SHA256 sha = SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Convert.ToBase64String(bytes);
            }
        }
        #endregion
        #region === STYLE UI LOGIN ===
        private void StyleLoginElements()
        {
            // Định dạng Panel chứa nội dung (giả sử tên là pnlCard)
            pnlCard.BackColor = Color.FromArgb(180, 255, 255, 255);// Trắng trong suốt nhẹ
            pnlCard.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlCard.Width, pnlCard.Height, 20, 20));

            // Định dạng nút Đăng Nhập
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.BackColor = primaryColor;
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDangNhap.Width, btnDangNhap.Height, 15, 15));

            // Định dạng nút Thoát (trong suốt, viền mỏng)
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.FlatAppearance.BorderColor = primaryColor;
            btnThoat.BackColor = Color.Transparent;
            btnThoat.ForeColor = primaryColor;
            btnThoat.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnThoat.Width, btnThoat.Height, 15, 15));
        }
        #endregion

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //UIStyleLogin.ApplyLoginStyle(this);
        }
        #region === EVENT: USERNAME FOCUS ===
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Tên đăng nhập")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = textColor;
            }
            pnlLineUser.BackColor = Color.FromArgb(0, 126, 249); // Đổi sang màu xanh nổi bật
            pnlLineUser.Height = 2; // Làm đường kẻ dày hơn một chút
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Tên đăng nhập";
                txtUsername.ForeColor = placeholderColor;
            }
            pnlLineUser.BackColor = Color.Gray; // Trả về màu xám trung tính
            pnlLineUser.Height = 1;
        }
        #endregion
        #region === EVENT: PASSWORD FOCUS ===
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mật khẩu")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = textColor;
                txtPassword.UseSystemPasswordChar = true; // Ẩn mật khẩu khi gõ
            }
            pnlLinePass.BackColor = Color.FromArgb(0, 126, 249); // Đổi sang màu xanh nổi bật
            pnlLinePass.Height = 2; // Làm đường kẻ dày hơn một chút
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Mật khẩu";
                txtPassword.ForeColor = placeholderColor;
                txtPassword.UseSystemPasswordChar = false; // Hiện lại chữ "Mật khẩu"
            }
            pnlLinePass.BackColor = Color.Gray; // Trả về màu xám trung tính
            pnlLinePass.Height = 1;
        }
        #endregion
        #region === LOGIN LOGIC ===
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu và kiểm tra Placeholder
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (user == "Tên đăng nhập" || pass == "Mật khẩu" || string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!");
                return;
            }

            // 2. TẠM THỜI: Thử cả 2 cách (Hash và Không Hash) để bạn đăng nhập được ngay
            string passHash = Hash(pass);

            // Tìm tài khoản khớp với User và (Mật khẩu thuần HOẶC Mật khẩu Hash)
            var tk = context.TaiKhoan
                .FirstOrDefault(x => x.TenDangNhap == user && (x.MatKhau == passHash || x.MatKhau == pass));

            if (tk != null)
            {
                MessageBox.Show($"Chào mừng {tk.TenDangNhap}!");

                // Lưu thông tin phiên làm việc
                Session.TenDangNhap = tk.TenDangNhap;
                Session.Quyen = tk.Quyen;

                // Mở trang chủ
                TrangChu frm = new TrangChu();
                frm.FormClosed += (s, args) => Application.Exit();
                frm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }
        #endregion
    }
}
