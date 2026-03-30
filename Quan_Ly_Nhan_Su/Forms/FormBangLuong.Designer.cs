namespace Quan_Ly_Nhan_Su.Forms
{
    partial class FormBangLuong
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dgvBangLuong = new DataGridView();
            MaLuong = new DataGridViewTextBoxColumn();
            MaNV = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            Thang = new DataGridViewTextBoxColumn();
            LuongCoBan = new DataGridViewTextBoxColumn();
            PhuCap = new DataGridViewTextBoxColumn();
            Thuong = new DataGridViewTextBoxColumn();
            KhauTru = new DataGridViewTextBoxColumn();
            TongLuong = new DataGridViewTextBoxColumn();
            panelHeader = new Panel();
            label1 = new Label();
            panelInput = new Panel();
            btnReset = new Button();
            btnXuat = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnTinhLuong = new Button();
            dtThangNam = new DateTimePicker();
            txtThuong = new TextBox();
            txtLuongCoBan = new TextBox();
            txtKhauTru = new TextBox();
            txtPhuCap = new TextBox();
            cbMaNV = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panelFooter = new Panel();
            lblTongLuong = new Label();
            panelMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvBangLuong).BeginInit();
            panelHeader.SuspendLayout();
            panelInput.SuspendLayout();
            panelFooter.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBangLuong
            // 
            dgvBangLuong.AllowUserToAddRows = false;
            dgvBangLuong.AllowUserToDeleteRows = false;
            dgvBangLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBangLuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBangLuong.Columns.AddRange(new DataGridViewColumn[] { MaLuong, MaNV, TenNV, Thang, LuongCoBan, PhuCap, Thuong, KhauTru, TongLuong });
            dgvBangLuong.Dock = DockStyle.Fill;
            dgvBangLuong.EnableHeadersVisualStyles = false;
            dgvBangLuong.Location = new Point(0, 0);
            dgvBangLuong.MultiSelect = false;
            dgvBangLuong.Name = "dgvBangLuong";
            dgvBangLuong.RowHeadersVisible = false;
            dgvBangLuong.RowHeadersWidth = 51;
            dgvBangLuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBangLuong.Size = new Size(800, 180);
            dgvBangLuong.TabIndex = 4;
            dgvBangLuong.CellClick += dgvBangLuong_CellClick;
            dgvBangLuong.CellContentClick += dgvBangLuong_CellContentClick;
            // 
            // MaLuong
            // 
            MaLuong.DataPropertyName = "ID";
            MaLuong.HeaderText = "ID";
            MaLuong.MinimumWidth = 6;
            MaLuong.Name = "MaLuong";
            // 
            // MaNV
            // 
            MaNV.DataPropertyName = "MaNV";
            MaNV.HeaderText = "Mã NV";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            TenNV.DataPropertyName = "TenNV";
            TenNV.HeaderText = "Tên NV";
            TenNV.MinimumWidth = 6;
            TenNV.Name = "TenNV";
            // 
            // Thang
            // 
            Thang.DataPropertyName = "Thang";
            Thang.HeaderText = "Tháng";
            Thang.MinimumWidth = 6;
            Thang.Name = "Thang";
            // 
            // LuongCoBan
            // 
            LuongCoBan.DataPropertyName = "LuongCoBan";
            dataGridViewCellStyle1.Format = "N0";
            LuongCoBan.DefaultCellStyle = dataGridViewCellStyle1;
            LuongCoBan.HeaderText = "Lương cơ bản ";
            LuongCoBan.MinimumWidth = 6;
            LuongCoBan.Name = "LuongCoBan";
            // 
            // PhuCap
            // 
            PhuCap.DataPropertyName = "PhuCap";
            dataGridViewCellStyle2.Format = "N0";
            PhuCap.DefaultCellStyle = dataGridViewCellStyle2;
            PhuCap.HeaderText = "Phụ cấp ";
            PhuCap.MinimumWidth = 6;
            PhuCap.Name = "PhuCap";
            // 
            // Thuong
            // 
            Thuong.DataPropertyName = "Thuong";
            dataGridViewCellStyle3.Format = "N0";
            Thuong.DefaultCellStyle = dataGridViewCellStyle3;
            Thuong.HeaderText = "Thưởng";
            Thuong.MinimumWidth = 6;
            Thuong.Name = "Thuong";
            // 
            // KhauTru
            // 
            KhauTru.DataPropertyName = "KhauTru";
            dataGridViewCellStyle4.Format = "N0";
            KhauTru.DefaultCellStyle = dataGridViewCellStyle4;
            KhauTru.HeaderText = "Khấu trừ ";
            KhauTru.MinimumWidth = 6;
            KhauTru.Name = "KhauTru";
            // 
            // TongLuong
            // 
            TongLuong.DataPropertyName = "TongLuong";
            dataGridViewCellStyle5.Format = "N0";
            TongLuong.DefaultCellStyle = dataGridViewCellStyle5;
            TongLuong.HeaderText = "Tổng lương";
            TongLuong.MinimumWidth = 6;
            TongLuong.Name = "TongLuong";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Teal;
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 50);
            panelHeader.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 31);
            label1.TabIndex = 0;
            label1.Text = "Thông tin bảng lương ";
            // 
            // panelInput
            // 
            panelInput.Controls.Add(btnReset);
            panelInput.Controls.Add(btnXuat);
            panelInput.Controls.Add(btnLuu);
            panelInput.Controls.Add(btnSua);
            panelInput.Controls.Add(btnXoa);
            panelInput.Controls.Add(btnThem);
            panelInput.Controls.Add(btnTinhLuong);
            panelInput.Controls.Add(dtThangNam);
            panelInput.Controls.Add(txtThuong);
            panelInput.Controls.Add(txtLuongCoBan);
            panelInput.Controls.Add(txtKhauTru);
            panelInput.Controls.Add(txtPhuCap);
            panelInput.Controls.Add(cbMaNV);
            panelInput.Controls.Add(label7);
            panelInput.Controls.Add(label6);
            panelInput.Controls.Add(label5);
            panelInput.Controls.Add(label4);
            panelInput.Controls.Add(label3);
            panelInput.Controls.Add(label2);
            panelInput.Dock = DockStyle.Top;
            panelInput.Location = new Point(0, 50);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(800, 180);
            panelInput.TabIndex = 2;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.None;
            btnReset.BackColor = Color.Silver;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(596, 135);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(83, 35);
            btnReset.TabIndex = 18;
            btnReset.Text = "Reset ";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.None;
            btnXuat.BackColor = Color.Silver;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXuat.ForeColor = Color.Black;
            btnXuat.Location = new Point(694, 135);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 35);
            btnXuat.TabIndex = 17;
            btnXuat.Text = "Xuất Excel    ";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.BackColor = Color.Silver;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLuu.ForeColor = Color.Black;
            btnLuu.Location = new Point(486, 135);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 35);
            btnLuu.TabIndex = 16;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = Color.Silver;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(376, 135);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 35);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = Color.Silver;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(261, 135);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 35);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = Color.Silver;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(149, 135);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 35);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnTinhLuong
            // 
            btnTinhLuong.Anchor = AnchorStyles.None;
            btnTinhLuong.BackColor = Color.Silver;
            btnTinhLuong.FlatStyle = FlatStyle.Flat;
            btnTinhLuong.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnTinhLuong.ForeColor = Color.Black;
            btnTinhLuong.Location = new Point(15, 135);
            btnTinhLuong.Name = "btnTinhLuong";
            btnTinhLuong.Size = new Size(111, 35);
            btnTinhLuong.TabIndex = 12;
            btnTinhLuong.Text = "Tính lương ";
            btnTinhLuong.UseVisualStyleBackColor = false;
            btnTinhLuong.Click += btnTinhLuong_Click;
            // 
            // dtThangNam
            // 
            dtThangNam.Anchor = AnchorStyles.None;
            dtThangNam.Format = DateTimePickerFormat.Short;
            dtThangNam.Location = new Point(566, 94);
            dtThangNam.Name = "dtThangNam";
            dtThangNam.Size = new Size(151, 27);
            dtThangNam.TabIndex = 11;
            // 
            // txtThuong
            // 
            txtThuong.Anchor = AnchorStyles.None;
            txtThuong.BackColor = Color.White;
            txtThuong.Font = new Font("Segoe UI", 10.2F);
            txtThuong.Location = new Point(566, 54);
            txtThuong.Name = "txtThuong";
            txtThuong.Size = new Size(151, 30);
            txtThuong.TabIndex = 10;
            // 
            // txtLuongCoBan
            // 
            txtLuongCoBan.Anchor = AnchorStyles.None;
            txtLuongCoBan.BackColor = Color.White;
            txtLuongCoBan.Font = new Font("Segoe UI", 10.2F);
            txtLuongCoBan.Location = new Point(566, 16);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.Size = new Size(151, 30);
            txtLuongCoBan.TabIndex = 9;
            // 
            // txtKhauTru
            // 
            txtKhauTru.Anchor = AnchorStyles.None;
            txtKhauTru.BackColor = Color.White;
            txtKhauTru.Font = new Font("Segoe UI", 10.2F);
            txtKhauTru.Location = new Point(174, 94);
            txtKhauTru.Name = "txtKhauTru";
            txtKhauTru.Size = new Size(151, 30);
            txtKhauTru.TabIndex = 8;
            // 
            // txtPhuCap
            // 
            txtPhuCap.Anchor = AnchorStyles.None;
            txtPhuCap.BackColor = Color.White;
            txtPhuCap.Font = new Font("Segoe UI", 10.2F);
            txtPhuCap.Location = new Point(174, 54);
            txtPhuCap.Name = "txtPhuCap";
            txtPhuCap.Size = new Size(151, 30);
            txtPhuCap.TabIndex = 7;
            // 
            // cbMaNV
            // 
            cbMaNV.Anchor = AnchorStyles.None;
            cbMaNV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaNV.FormattingEnabled = true;
            cbMaNV.Items.AddRange(new object[] { "DTH235677", "DTH235708", "DTH235555" });
            cbMaNV.Location = new Point(174, 15);
            cbMaNV.Name = "cbMaNV";
            cbMaNV.Size = new Size(151, 28);
            cbMaNV.TabIndex = 6;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(449, 101);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 5;
            label7.Text = "Tháng/Năm";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(477, 61);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 4;
            label6.Text = "Thưởng";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(437, 23);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 3;
            label5.Text = "Lương cơ bản";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(61, 104);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 2;
            label4.Text = "Khấu trừ";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(77, 61);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 1;
            label3.Text = "Phụ cấp";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(41, 23);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã nhân viên";
            // 
            // panelFooter
            // 
            panelFooter.Controls.Add(lblTongLuong);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 410);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(800, 40);
            panelFooter.TabIndex = 4;
            // 
            // lblTongLuong
            // 
            lblTongLuong.AutoSize = true;
            lblTongLuong.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTongLuong.Location = new Point(20, 10);
            lblTongLuong.Name = "lblTongLuong";
            lblTongLuong.Size = new Size(0, 23);
            lblTongLuong.TabIndex = 0;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(dgvBangLuong);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 230);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(800, 180);
            panelMain.TabIndex = 5;
            // 
            // FormBangLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMain);
            Controls.Add(panelFooter);
            Controls.Add(panelInput);
            Controls.Add(panelHeader);
            Name = "FormBangLuong";
            Text = "BangLuong";
            Load += BangLuong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBangLuong).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private Panel panelInput;
        private DateTimePicker dtThangNam;
        private TextBox txtThuong;
        private TextBox txtLuongCoBan;
        private TextBox txtKhauTru;
        private TextBox txtPhuCap;
        private ComboBox cbMaNV;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnXuat;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Button btnTinhLuong;
        private Panel panelFooter;
        private Label lblTongLuong;
        private Panel panelMain;
        private DataGridView dgvBangLuong;
        private Button btnReset;
        private DataGridViewTextBoxColumn MaLuong;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn Thang;
        private DataGridViewTextBoxColumn LuongCoBan;
        private DataGridViewTextBoxColumn PhuCap;
        private DataGridViewTextBoxColumn Thuong;
        private DataGridViewTextBoxColumn KhauTru;
        private DataGridViewTextBoxColumn TongLuong;
    }
}