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
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            chkShowPass = new CheckBox();
            btnLogin = new Button();
            btnThoat = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(507, 87);
            label1.Name = "label1";
            label1.Size = new Size(188, 38);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG NHẬP";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(481, 156);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(514, 210);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu ";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(30, 30, 30);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 10.8F);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(601, 152);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 24);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(30, 30, 30);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 10.8F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(601, 206);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 24);
            txtPassword.TabIndex = 5;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.BackColor = Color.Transparent;
            chkShowPass.ForeColor = Color.White;
            chkShowPass.Location = new Point(601, 247);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(127, 24);
            chkShowPass.TabIndex = 6;
            chkShowPass.Text = "Hiện mật khẩu";
            chkShowPass.UseVisualStyleBackColor = false;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(507, 286);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 29);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Transparent;
            btnThoat.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(630, 286);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(96, 29);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát ";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // label4
            // 
            label4.Location = new Point(601, 175);
            label4.Name = "label4";
            label4.Size = new Size(125, 1);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.Location = new Point(601, 229);
            label5.Name = "label5";
            label5.Size = new Size(125, 1);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnThoat);
            Controls.Add(btnLogin);
            Controls.Add(chkShowPass);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private CheckBox chkShowPass;
        private Button btnLogin;
        private Button btnThoat;
        private Label label4;
        private Label label5;
    }
}