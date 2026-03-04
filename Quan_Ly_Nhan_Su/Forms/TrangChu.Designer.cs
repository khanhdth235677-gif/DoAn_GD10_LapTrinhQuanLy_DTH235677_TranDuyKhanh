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
            button1 = new Button();
            btnTrangChu = new Button();
            btnNhanVien = new Button();
            btnBoPhan = new Button();
            btnChamCong = new Button();
            btnBangLuong = new Button();
            btnDuAn = new Button();
            btnNghiPhep = new Button();
            panelMain = new Panel();
            panelStatus = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            fadeTimer = new System.Windows.Forms.Timer(components);
            panelSidebar.SuspendLayout();
            panelMain.SuspendLayout();
            panelStatus.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Gainsboro;
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(button1);
            panelSidebar.Controls.Add(btnTrangChu);
            panelSidebar.Controls.Add(btnNhanVien);
            panelSidebar.Controls.Add(btnBoPhan);
            panelSidebar.Controls.Add(btnChamCong);
            panelSidebar.Controls.Add(btnBangLuong);
            panelSidebar.Controls.Add(btnDuAn);
            panelSidebar.Controls.Add(btnNghiPhep);
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
            // button1
            // 
            button1.BackColor = Color.MediumAquamarine;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(25, 69);
            button1.Margin = new Padding(25, 3, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(200, 40);
            button1.TabIndex = 1;
            button1.Text = "ADMIN ▼";
            button1.UseVisualStyleBackColor = false;
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
            btnTrangChu.Text = "Trang Chủ";
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
            btnNhanVien.Text = "Nhân viên";
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
            btnBoPhan.Text = "Bộ phận";
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
            btnChamCong.Text = "Chấm công";
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
            btnBangLuong.Text = "Bảng lương";
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
            btnDuAn.Text = "Dự án";
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
            btnNghiPhep.Text = "Nghỉ phép";
            btnNghiPhep.TextAlign = ContentAlignment.MiddleLeft;
            btnNghiPhep.UseVisualStyleBackColor = false;
            btnNghiPhep.Click += btnNghiPhep_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.BackgroundImage = (Image)resources.GetObject("panelMain.BackgroundImage");
            panelMain.BackgroundImageLayout = ImageLayout.Zoom;
            panelMain.Controls.Add(panelStatus);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(792, 515);
            panelMain.TabIndex = 1;
            // 
            // panelStatus
            // 
            panelStatus.BackColor = Color.WhiteSmoke;
            panelStatus.Controls.Add(label4);
            panelStatus.Controls.Add(label3);
            panelStatus.Controls.Add(label2);
            panelStatus.Dock = DockStyle.Bottom;
            panelStatus.Location = new Point(0, 475);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(792, 40);
            panelStatus.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(679, 11);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 2;
            label4.Text = "24/02/2024";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(283, 11);
            label3.Name = "label3";
            label3.Size = new Size(202, 20);
            label3.TabIndex = 1;
            label3.Text = "Quyền hạn: Quản trị hệ thống";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(24, 11);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 0;
            label2.Text = "Nhân viên: ADMIN";
            // 
            // fadeTimer
            // 
            fadeTimer.Interval = 20;
            fadeTimer.Tick += fadeTimer_Tick;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 515);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Name = "TrangChu";
            Text = "Trang chủ ";
            Load += MainForm_Load;
            panelSidebar.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelSidebar;
        private Label label1;
        private Button button1;
        private Button btnTrangChu;
        private Button btnNhanVien;
        private Button btnBoPhan;
        private Button btnChamCong;
        private Button btnBangLuong;
        private Button btnDuAn;
        private Button btnNghiPhep;
        private Panel panelMain;
        private Panel panelStatus;
        private Label label2;
        private Label label4;
        private Label label3;
        private System.Windows.Forms.Timer fadeTimer;
    }
}