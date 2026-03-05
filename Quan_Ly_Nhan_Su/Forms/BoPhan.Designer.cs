namespace Quan_Ly_Nhan_Su.Forms
{
    partial class BoPhan
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
            panelHeader = new Panel();
            label1 = new Label();
            panelInput = new Panel();
            txtHoTenNV = new TextBox();
            label3 = new Label();
            btnTimKiem = new Button();
            btnReset = new Button();
            btnXuat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtMoTa = new TextBox();
            cbTenPhongBan = new ComboBox();
            txtID = new TextBox();
            label5 = new Label();
            cbTenBoPhan = new Label();
            label2 = new Label();
            panelMain = new Panel();
            dgvBoPhan = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenPhongBan = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            panelInput.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBoPhan).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Teal;
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 50);
            panelHeader.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 9);
            label1.Name = "label1";
            label1.Size = new Size(225, 31);
            label1.TabIndex = 0;
            label1.Text = "Thông tin  bộ phận ";
            // 
            // panelInput
            // 
            panelInput.Controls.Add(txtHoTenNV);
            panelInput.Controls.Add(label3);
            panelInput.Controls.Add(btnTimKiem);
            panelInput.Controls.Add(btnReset);
            panelInput.Controls.Add(btnXuat);
            panelInput.Controls.Add(btnSua);
            panelInput.Controls.Add(btnXoa);
            panelInput.Controls.Add(btnThem);
            panelInput.Controls.Add(txtMoTa);
            panelInput.Controls.Add(cbTenPhongBan);
            panelInput.Controls.Add(txtID);
            panelInput.Controls.Add(label5);
            panelInput.Controls.Add(cbTenBoPhan);
            panelInput.Controls.Add(label2);
            panelInput.Dock = DockStyle.Top;
            panelInput.Location = new Point(0, 50);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(800, 186);
            panelInput.TabIndex = 3;
            // 
            // txtHoTenNV
            // 
            txtHoTenNV.Location = new Point(555, 12);
            txtHoTenNV.Name = "txtHoTenNV";
            txtHoTenNV.ReadOnly = true;
            txtHoTenNV.Size = new Size(172, 27);
            txtHoTenNV.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 19);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 21;
            label3.Text = "Họ và tên NV";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.DeepPink;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(674, 138);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(99, 35);
            btnTimKiem.TabIndex = 20;
            btnTimKiem.Text = "Tìm kiếm ";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.DeepPink;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(416, 138);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(83, 35);
            btnReset.TabIndex = 19;
            btnReset.Text = "Reset ";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.DeepPink;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXuat.ForeColor = Color.White;
            btnXuat.Location = new Point(539, 138);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(106, 35);
            btnXuat.TabIndex = 14;
            btnXuat.Text = "Xuất Excel ";
            btnXuat.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DeepPink;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(286, 138);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 35);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.DeepPink;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(151, 138);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 35);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DeepPink;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(25, 138);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 35);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(164, 96);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(573, 27);
            txtMoTa.TabIndex = 8;
            // 
            // cbTenPhongBan
            // 
            cbTenPhongBan.FormattingEnabled = true;
            cbTenPhongBan.Location = new Point(164, 53);
            cbTenPhongBan.Name = "cbTenPhongBan";
            cbTenPhongBan.Size = new Size(172, 28);
            cbTenPhongBan.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(164, 12);
            txtID.Name = "txtID";
            txtID.Size = new Size(172, 27);
            txtID.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 103);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 3;
            label5.Text = "Mô tả ";
            // 
            // cbTenBoPhan
            // 
            cbTenBoPhan.AutoSize = true;
            cbTenBoPhan.Location = new Point(53, 61);
            cbTenBoPhan.Name = "cbTenBoPhan";
            cbTenBoPhan.Size = new Size(95, 20);
            cbTenBoPhan.TabIndex = 2;
            cbTenBoPhan.Text = "Tên bộ phận ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 19);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã bộ phận ";
            // 
            // panelMain
            // 
            panelMain.Controls.Add(dgvBoPhan);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 236);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(800, 214);
            panelMain.TabIndex = 4;
            // 
            // dgvBoPhan
            // 
            dgvBoPhan.AllowUserToAddRows = false;
            dgvBoPhan.AllowUserToDeleteRows = false;
            dgvBoPhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBoPhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoPhan.Columns.AddRange(new DataGridViewColumn[] { ID, TenPhongBan, HoTen, MoTa });
            dgvBoPhan.Dock = DockStyle.Fill;
            dgvBoPhan.EnableHeadersVisualStyles = false;
            dgvBoPhan.Location = new Point(0, 0);
            dgvBoPhan.MultiSelect = false;
            dgvBoPhan.Name = "dgvBoPhan";
            dgvBoPhan.RowHeadersVisible = false;
            dgvBoPhan.RowHeadersWidth = 51;
            dgvBoPhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBoPhan.Size = new Size(800, 214);
            dgvBoPhan.TabIndex = 5;
            dgvBoPhan.CellClick += dgvBoPhan_CellClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "Mã bộ phận ";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenPhongBan
            // 
            TenPhongBan.DataPropertyName = "TenPhongBan";
            TenPhongBan.HeaderText = "Tên phòng ban";
            TenPhongBan.MinimumWidth = 6;
            TenPhongBan.Name = "TenPhongBan";
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ và tên NV";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            // 
            // MoTa
            // 
            MoTa.DataPropertyName = "MoTa";
            MoTa.HeaderText = "Mô tả";
            MoTa.MinimumWidth = 6;
            MoTa.Name = "MoTa";
            // 
            // BoPhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMain);
            Controls.Add(panelInput);
            Controls.Add(panelHeader);
            Name = "BoPhan";
            Text = "BoPhan";
            Load += BoPhan_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBoPhan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private Panel panelInput;
        private Button btnXuat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtMoTa;
        private ComboBox cbTenPhongBan;
        private TextBox txtID;
        private Label label5;
        private Label cbTenBoPhan;
        private Label label2;
        private Panel panelMain;
        private Button btnReset;
        private Button btnTimKiem;
        private TextBox txtHoTenNV;
        private Label label3;
        private DataGridView dgvBoPhan;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenPhongBan;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn MoTa;
    }
}