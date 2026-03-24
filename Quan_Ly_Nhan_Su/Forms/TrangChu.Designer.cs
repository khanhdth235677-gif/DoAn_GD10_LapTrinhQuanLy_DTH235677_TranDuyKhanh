namespace Quan_Ly_Nhan_Su.Forms
{
    partial class TrangChu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            panelSidebar = new FlowLayoutPanel();
            label1 = new Label();
            btnQuyen = new Button();
            btnTrangChu = new Button();
            btnNhanVien = new Button();
            btnBoPhan = new Button();
            btnChamCong = new Button();
            btnBangLuong = new Button();
            btnDuAn = new Button();
            btnNghiPhep = new Button();
            btnThoat = new Button();
            panelMain = new Panel();
            panelStatus = new Panel();
            lblUser = new Label();
            lblTime = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panelSidebar.SuspendLayout();
            panelMain.SuspendLayout();
            panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Gainsboro;
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(btnQuyen);
            panelSidebar.Controls.Add(btnTrangChu);
            panelSidebar.Controls.Add(btnNhanVien);
            panelSidebar.Controls.Add(btnBoPhan);
            panelSidebar.Controls.Add(btnChamCong);
            panelSidebar.Controls.Add(btnBangLuong);
            panelSidebar.Controls.Add(btnDuAn);
            panelSidebar.Controls.Add(btnNghiPhep);
            panelSidebar.Controls.Add(btnThoat);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(250, 515);
            panelSidebar.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(70, 5);
            label1.Margin = new Padding(70, 5, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 61);
            label1.TabIndex = 0;
            label1.Text = "QLNS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnQuyen
            // 
            btnQuyen.BackColor = Color.MediumAquamarine;
            btnQuyen.Enabled = false;
            btnQuyen.FlatAppearance.BorderSize = 0;
            btnQuyen.FlatStyle = FlatStyle.Flat;
            btnQuyen.ForeColor = Color.White;
            btnQuyen.Location = new Point(25, 69);
            btnQuyen.Margin = new Padding(25, 3, 3, 3);
            btnQuyen.Name = "btnQuyen";
            btnQuyen.Size = new Size(200, 40);
            btnQuyen.TabIndex = 1;
            btnQuyen.Text = "ADMIN ▼";
            btnQuyen.UseVisualStyleBackColor = false;
            btnQuyen.Click += btnQuyen_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.Transparent;
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Location = new Point(25, 115);
            btnTrangChu.Margin = new Padding(25, 3, 3, 3);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(200, 40);
            btnTrangChu.TabIndex = 7;
            btnTrangChu.Text = "🏠 Trang chủ";
            btnTrangChu.TextAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.Transparent;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Location = new Point(25, 161);
            btnNhanVien.Margin = new Padding(25, 3, 3, 3);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(200, 40);
            btnNhanVien.TabIndex = 6;
            btnNhanVien.Text = "👤 Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnBoPhan
            // 
            btnBoPhan.BackColor = Color.Transparent;
            btnBoPhan.FlatAppearance.BorderSize = 0;
            btnBoPhan.FlatStyle = FlatStyle.Flat;
            btnBoPhan.Location = new Point(25, 207);
            btnBoPhan.Margin = new Padding(25, 3, 3, 3);
            btnBoPhan.Name = "btnBoPhan";
            btnBoPhan.Size = new Size(200, 40);
            btnBoPhan.TabIndex = 5;
            btnBoPhan.Text = "🏢 Bộ phận";
            btnBoPhan.TextAlign = ContentAlignment.MiddleLeft;
            btnBoPhan.UseVisualStyleBackColor = false;
            btnBoPhan.Click += btnBoPhan_Click;
            // 
            // btnChamCong
            // 
            btnChamCong.BackColor = Color.Transparent;
            btnChamCong.FlatAppearance.BorderSize = 0;
            btnChamCong.FlatStyle = FlatStyle.Flat;
            btnChamCong.Location = new Point(25, 253);
            btnChamCong.Margin = new Padding(25, 3, 3, 3);
            btnChamCong.Name = "btnChamCong";
            btnChamCong.Size = new Size(200, 40);
            btnChamCong.TabIndex = 4;
            btnChamCong.Text = "⏱ Chấm công";
            btnChamCong.TextAlign = ContentAlignment.MiddleLeft;
            btnChamCong.UseVisualStyleBackColor = false;
            btnChamCong.Click += btnChamCong_Click;
            // 
            // btnBangLuong
            // 
            btnBangLuong.BackColor = Color.Transparent;
            btnBangLuong.FlatAppearance.BorderSize = 0;
            btnBangLuong.FlatStyle = FlatStyle.Flat;
            btnBangLuong.Location = new Point(25, 299);
            btnBangLuong.Margin = new Padding(25, 3, 3, 3);
            btnBangLuong.Name = "btnBangLuong";
            btnBangLuong.Size = new Size(200, 40);
            btnBangLuong.TabIndex = 3;
            btnBangLuong.Text = "💰 Bảng lương";
            btnBangLuong.TextAlign = ContentAlignment.MiddleLeft;
            btnBangLuong.UseVisualStyleBackColor = false;
            btnBangLuong.Click += btnBangLuong_Click;
            // 
            // btnDuAn
            // 
            btnDuAn.BackColor = Color.Transparent;
            btnDuAn.FlatAppearance.BorderSize = 0;
            btnDuAn.FlatStyle = FlatStyle.Flat;
            btnDuAn.Location = new Point(25, 345);
            btnDuAn.Margin = new Padding(25, 3, 3, 3);
            btnDuAn.Name = "btnDuAn";
            btnDuAn.Size = new Size(200, 40);
            btnDuAn.TabIndex = 2;
            btnDuAn.Text = "📁 Dự án";
            btnDuAn.TextAlign = ContentAlignment.MiddleLeft;
            btnDuAn.UseVisualStyleBackColor = false;
            btnDuAn.Click += btnDuAn_Click;
            // 
            // btnNghiPhep
            // 
            btnNghiPhep.BackColor = Color.Transparent;
            btnNghiPhep.FlatAppearance.BorderSize = 0;
            btnNghiPhep.FlatStyle = FlatStyle.Flat;
            btnNghiPhep.Location = new Point(25, 391);
            btnNghiPhep.Margin = new Padding(25, 3, 3, 3);
            btnNghiPhep.Name = "btnNghiPhep";
            btnNghiPhep.Size = new Size(200, 40);
            btnNghiPhep.TabIndex = 1;
            btnNghiPhep.Text = "📅 Nghỉ phép";
            btnNghiPhep.TextAlign = ContentAlignment.MiddleLeft;
            btnNghiPhep.UseVisualStyleBackColor = false;
            btnNghiPhep.Click += btnNghiPhep_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Transparent;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Location = new Point(25, 437);
            btnThoat.Margin = new Padding(25, 3, 3, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(200, 40);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "🚪 Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleLeft;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.BackgroundImageLayout = ImageLayout.Zoom;
            panelMain.Controls.Add(panelStatus);
            panelMain.Controls.Add(pictureBox1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(792, 515);
            panelMain.TabIndex = 1;
            // 
            // panelStatus
            // 
            panelStatus.BackColor = Color.WhiteSmoke;
            panelStatus.Controls.Add(lblUser);
            panelStatus.Controls.Add(lblTime);
            panelStatus.Dock = DockStyle.Bottom;
            panelStatus.Location = new Point(0, 475);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(792, 40);
            panelStatus.TabIndex = 0;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(26, 14);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 20);
            lblUser.TabIndex = 1;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.Location = new Point(730, 11);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(0, 20);
            lblTime.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(792, 515);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 515);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            IsMdiContainer = true;
            Name = "TrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ ";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            panelSidebar.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelSidebar;
        private Label label1;
        private Button btnQuyen;
        private Button btnTrangChu;
        private Button btnNhanVien;
        private Button btnBoPhan;
        private Button btnChamCong;
        private Button btnBangLuong;
        private Button btnDuAn;
        private Button btnNghiPhep;
        private Panel panelMain;
        private Panel panelStatus;
        private Button btnThoat;
        private Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Label lblUser;
        private Label lblQuyen;
    }
}