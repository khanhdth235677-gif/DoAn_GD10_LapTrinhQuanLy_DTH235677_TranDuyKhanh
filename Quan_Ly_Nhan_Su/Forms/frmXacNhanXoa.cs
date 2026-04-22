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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Nhan_Su.Forms
{
    public partial class frmXacNhanXoa : Form
    {
        #region === FIELD / BIẾN TOÀN CỤC ===
        Color primaryColor = Color.FromArgb(52, 152, 219); // Xanh dương
        Color placeholderColor = Color.Gray;
        Color textColor = Color.Black;
        #endregion

        // 2. DI CHUYỂN DLL IMPORT VÀO ĐÂY
        #region === DLL IMPORT (BO GÓC FORM) ===
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeft, int nTop, int nRight, int nBottom, int nWidth, int nHeight);
        #endregion
        public frmXacNhanXoa()
        {
            InitializeComponent();
        }
        #region === EVENT: USERNAME FOCUS ===
        private void txtUsername_Enter_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Tên đăng nhập")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = textColor;
            }
            pnlLineUser.BackColor = Color.FromArgb(0, 126, 249); // Đổi sang màu xanh nổi bật
            pnlLineUser.Height = 2; // Làm đường kẻ dày hơn một chút
        }

        private void txtUsername_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Tên đăng nhập";
                txtUsername.ForeColor = placeholderColor;
            }
            pnlLineUser.BackColor = Color.Gray; // Trả về màu xám trung tính
            pnlLineUser.Height = 1;
        }

        private void txtPassword_Enter_1(object sender, EventArgs e)
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

        private void txtPassword_Leave_1(object sender, EventArgs e)
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
        #region === EVENT: SHOW/HIDE PASSWORD ===
        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
        }
        #endregion
        #region === EVENT: NÚT BẤM ===
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string tk = txtUsername.Text.Trim();
            string mk = txtPassword.Text.Trim();

            // Kiểm tra xem người dùng có để trống hoặc chưa nhập gì không
            if (tk == "Tên đăng nhập" || string.IsNullOrWhiteSpace(tk) ||
                mk == "Mật khẩu" || string.IsNullOrWhiteSpace(mk))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var context = new QLNSDataContext())
                {
                    // 1. Dùng FirstOrDefault để lấy tài khoản từ DB dựa trên User/Pass
                    var taiKhoan = context.TaiKhoan.FirstOrDefault(x => x.TenDangNhap == tk && x.MatKhau == mk);

                    if (taiKhoan != null) // Nếu tài khoản và mật khẩu nhập ĐÚNG
                    {
                        // 2. KIỂM TRA QUYỀN QUẢN TRỊ
                        // ⚠️ LƯU Ý: Bạn hãy thay đổi chữ "Quyen" và "Admin" cho khớp với tên cột và dữ liệu trong DB của bạn nhé!
                        if (taiKhoan.Quyen == "Quản trị viên")
                        {
                            // Có quyền -> Cho phép xóa
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            // Sai quyền -> Chặn lại
                            MessageBox.Show("Chỉ có Quản trị viên mới được phép thực hiện thao tác xóa này!", "Từ chối truy cập", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else
                    {
                        // Đăng nhập sai (Không tìm thấy tài khoản hoặc sai mật khẩu)
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Text = ""; // Xóa trắng mật khẩu cũ
                        txtPassword.Focus();   // Yêu cầu nhập lại
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Hủy bỏ thao tác -> Báo trạng thái Cancel và đóng form
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}
