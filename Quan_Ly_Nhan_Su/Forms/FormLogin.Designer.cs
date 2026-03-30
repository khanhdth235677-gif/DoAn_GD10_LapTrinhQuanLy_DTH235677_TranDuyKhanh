namespace Quan_Ly_Nhan_Su.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            label1 = new Label();
            txtPassword = new TextBox();
            chkShowPass = new CheckBox();
            btnThoat = new Button();
            label4 = new Label();
            label5 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtUsername = new TextBox();
            pnlCard = new Panel();
            btnDangNhap = new Button();
            pnlLinePass = new Panel();
            pnlLineUser = new Panel();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 76);
            label1.Name = "label1";
            label1.Size = new Size(188, 38);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG NHẬP";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 10.8F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(36, 196);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(219, 24);
            txtPassword.TabIndex = 5;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.BackColor = Color.Transparent;
            chkShowPass.ForeColor = Color.White;
            chkShowPass.Location = new Point(128, 238);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(127, 24);
            chkShowPass.TabIndex = 6;
            chkShowPass.Text = "Hiện mật khẩu";
            chkShowPass.UseVisualStyleBackColor = false;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Transparent;
            btnThoat.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(179, 279);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(76, 29);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát ";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // label4
            // 
            label4.Location = new Point(130, 148);
            label4.Name = "label4";
            label4.Size = new Size(125, 1);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.Location = new Point(130, 222);
            label5.Name = "label5";
            label5.Size = new Size(125, 1);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 10.8F);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(36, 140);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(219, 24);
            txtUsername.TabIndex = 11;
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.Transparent;
            pnlCard.Controls.Add(btnDangNhap);
            pnlCard.Controls.Add(pnlLinePass);
            pnlCard.Controls.Add(pnlLineUser);
            pnlCard.Controls.Add(label1);
            pnlCard.Controls.Add(txtUsername);
            pnlCard.Controls.Add(label5);
            pnlCard.Controls.Add(label4);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(btnThoat);
            pnlCard.Controls.Add(chkShowPass);
            pnlCard.Dock = DockStyle.Right;
            pnlCard.Location = new Point(511, 0);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(289, 455);
            pnlCard.TabIndex = 12;
            // 
            // btnDangNhap
            // 
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDangNhap.Location = new Point(54, 283);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(94, 29);
            btnDangNhap.TabIndex = 14;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // pnlLinePass
            // 
            pnlLinePass.BackColor = Color.DarkGray;
            pnlLinePass.Location = new Point(36, 220);
            pnlLinePass.Name = "pnlLinePass";
            pnlLinePass.Size = new Size(219, 1);
            pnlLinePass.TabIndex = 13;
            // 
            // pnlLineUser
            // 
            pnlLineUser.BackColor = Color.DarkGray;
            pnlLineUser.Location = new Point(36, 164);
            pnlLineUser.Name = "pnlLineUser";
            pnlLineUser.Size = new Size(219, 1);
            pnlLineUser.TabIndex = 12;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 455);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox txtPassword;
        private CheckBox chkShowPass;
        private Button btnLogin;
        private Button btnThoat;
        private Label label4;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtUsername;
        private Panel pnlCard;
        private Panel pnlLineUser;
        private Panel pnlLinePass;
        private Button btnDangNhap;
    }
}