using DocumentFormat.OpenXml.InkML;
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
using System.Security.Cryptography;

namespace Quan_Ly_Nhan_Su.Forms
{
    public partial class FormLogin : Form
    {
        QLNSDataContext context = new QLNSDataContext();
        public FormLogin()
        {
            InitializeComponent();
            // BONUS
            this.AcceptButton = btnLogin;
            this.CancelButton = btnThoat;
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!");
                return;
            }

            // 🔐 HASH PASSWORD
            string passHash = Hash(pass);

            var tk = context.TaiKhoan
                .FirstOrDefault(x => x.TenDangNhap == user && x.MatKhau == passHash);

            if (tk != null)
            {
                MessageBox.Show("Đăng nhập thành công!");

                // 🔥 LƯU THÔNG TIN
                Session.TenDangNhap = tk.TenDangNhap;
                Session.Quyen = tk.Quyen;

                // 🔥 MỞ TRANG CHỦ
                TrangChu frm = new TrangChu();

                // 🔥 TRUYỀN DỮ LIỆU
                Session.TenDangNhap = tk.TenDangNhap;
                Session.Quyen = tk.Quyen;

                // 🔥 ĐÓNG APP KHI ĐÓNG TRANG CHỦ
                frm.FormClosed += (s, args) => Application.Exit();

                frm.Show();

                // 🔥 ẨN LOGIN
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // 🔐 Hàm mã hóa mật khẩu
        string Hash(string input)
        {
            using (SHA256 sha = SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Convert.ToBase64String(bytes);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }
    }
}
