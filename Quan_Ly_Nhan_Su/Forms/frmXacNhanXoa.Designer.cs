namespace Quan_Ly_Nhan_Su.Forms
{
    partial class frmXacNhanXoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlCard = new Panel();
            btnXacNhan = new Button();
            pnlLinePass = new Panel();
            pnlLineUser = new Panel();
            label1 = new Label();
            txtUsername = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            btnThoat = new Button();
            chkShowPass = new CheckBox();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.Gray;
            pnlCard.Controls.Add(btnXacNhan);
            pnlCard.Controls.Add(pnlLinePass);
            pnlCard.Controls.Add(pnlLineUser);
            pnlCard.Controls.Add(label1);
            pnlCard.Controls.Add(txtUsername);
            pnlCard.Controls.Add(label5);
            pnlCard.Controls.Add(label4);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(btnThoat);
            pnlCard.Controls.Add(chkShowPass);
            pnlCard.Dock = DockStyle.Fill;
            pnlCard.Location = new Point(0, 0);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(361, 355);
            pnlCard.TabIndex = 13;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.Gainsboro;
            btnXacNhan.FlatAppearance.BorderSize = 0;
            btnXacNhan.FlatStyle = FlatStyle.Flat;
            btnXacNhan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnXacNhan.Location = new Point(80, 266);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 14;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // pnlLinePass
            // 
            pnlLinePass.BackColor = Color.DarkGray;
            pnlLinePass.Location = new Point(71, 203);
            pnlLinePass.Name = "pnlLinePass";
            pnlLinePass.Size = new Size(219, 1);
            pnlLinePass.TabIndex = 13;
            // 
            // pnlLineUser
            // 
            pnlLineUser.BackColor = Color.DarkGray;
            pnlLineUser.Location = new Point(71, 147);
            pnlLineUser.Name = "pnlLineUser";
            pnlLineUser.Size = new Size(219, 1);
            pnlLineUser.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(86, 59);
            label1.Name = "label1";
            label1.Size = new Size(188, 38);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG NHẬP";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 10.8F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(71, 123);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(219, 24);
            txtUsername.TabIndex = 11;
            txtUsername.Enter += txtUsername_Enter_1;
            txtUsername.Leave += txtUsername_Leave_1;
            // 
            // label5
            // 
            label5.Location = new Point(165, 205);
            label5.Name = "label5";
            label5.Size = new Size(125, 1);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.Location = new Point(165, 131);
            label4.Name = "label4";
            label4.Size = new Size(125, 1);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 10.8F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(71, 179);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(219, 24);
            txtPassword.TabIndex = 5;
            txtPassword.Enter += txtPassword_Enter_1;
            txtPassword.Leave += txtPassword_Leave_1;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.DimGray;
            btnThoat.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(205, 266);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(76, 29);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Hủy";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.BackColor = Color.Transparent;
            chkShowPass.ForeColor = Color.White;
            chkShowPass.Location = new Point(163, 221);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(127, 24);
            chkShowPass.TabIndex = 6;
            chkShowPass.Text = "Hiện mật khẩu";
            chkShowPass.UseVisualStyleBackColor = false;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // frmXacNhanXoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 355);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmXacNhanXoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmXacNhanXoa";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCard;
        private Button btnXacNhan;
        private Panel pnlLinePass;
        private Panel pnlLineUser;
        private Label label1;
        private TextBox txtUsername;
        private Label label5;
        private Label label4;
        private TextBox txtPassword;
        private Button btnThoat;
        private CheckBox chkShowPass;
    }
}