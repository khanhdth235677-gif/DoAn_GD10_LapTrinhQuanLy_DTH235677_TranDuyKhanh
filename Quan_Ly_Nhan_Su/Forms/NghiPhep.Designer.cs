namespace Quan_Ly_Nhan_Su.Forms
{
    partial class NghiPhep
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
            btnXuat = new Button();
            txtTrangThai = new TextBox();
            btnLuu = new Button();
            btnTimKiem = new Button();
            btnHuy = new Button();
            btnXoa = new Button();
            btnTuChoi = new Button();
            btnDuyet = new Button();
            btnThem = new Button();
            dtNgayKT = new DateTimePicker();
            dtNgayBD = new DateTimePicker();
            cbNhanVien = new ComboBox();
            txtLyDo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panelMain = new Panel();
            dgvNghiPhep = new DataGridView();
            MaNghiPhep = new DataGridViewTextBoxColumn();
            MaNV = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            TuNgay = new DataGridViewTextBoxColumn();
            DenNgay = new DataGridViewTextBoxColumn();
            LyDo = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            panelInput.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNghiPhep).BeginInit();
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
            panelHeader.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 9);
            label1.Name = "label1";
            label1.Size = new Size(246, 31);
            label1.TabIndex = 0;
            label1.Text = "Thông tin  nghỉ phép ";
            // 
            // panelInput
            // 
            panelInput.Controls.Add(btnXuat);
            panelInput.Controls.Add(txtTrangThai);
            panelInput.Controls.Add(btnLuu);
            panelInput.Controls.Add(btnTimKiem);
            panelInput.Controls.Add(btnHuy);
            panelInput.Controls.Add(btnXoa);
            panelInput.Controls.Add(btnTuChoi);
            panelInput.Controls.Add(btnDuyet);
            panelInput.Controls.Add(btnThem);
            panelInput.Controls.Add(dtNgayKT);
            panelInput.Controls.Add(dtNgayBD);
            panelInput.Controls.Add(cbNhanVien);
            panelInput.Controls.Add(txtLyDo);
            panelInput.Controls.Add(label6);
            panelInput.Controls.Add(label5);
            panelInput.Controls.Add(label4);
            panelInput.Controls.Add(label3);
            panelInput.Controls.Add(label2);
            panelInput.Dock = DockStyle.Top;
            panelInput.Location = new Point(0, 50);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(800, 188);
            panelInput.TabIndex = 4;
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.None;
            btnXuat.BackColor = Color.Silver;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXuat.ForeColor = Color.Black;
            btnXuat.Location = new Point(694, 137);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 35);
            btnXuat.TabIndex = 18;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Anchor = AnchorStyles.None;
            txtTrangThai.Location = new Point(148, 51);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.ReadOnly = true;
            txtTrangThai.Size = new Size(203, 27);
            txtTrangThai.TabIndex = 17;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.BackColor = Color.Silver;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLuu.ForeColor = Color.Black;
            btnLuu.Location = new Point(246, 137);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 35);
            btnLuu.TabIndex = 16;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.Location = new Point(644, 88);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 15;
            btnTimKiem.Text = "Tìm kiếm ";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.None;
            btnHuy.BackColor = Color.Silver;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnHuy.ForeColor = Color.Black;
            btnHuy.Location = new Point(586, 137);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 35);
            btnHuy.TabIndex = 14;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = Color.Silver;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(472, 137);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 35);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTuChoi
            // 
            btnTuChoi.Anchor = AnchorStyles.None;
            btnTuChoi.BackColor = Color.Silver;
            btnTuChoi.FlatStyle = FlatStyle.Flat;
            btnTuChoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnTuChoi.ForeColor = Color.Black;
            btnTuChoi.Location = new Point(361, 137);
            btnTuChoi.Name = "btnTuChoi";
            btnTuChoi.Size = new Size(94, 35);
            btnTuChoi.TabIndex = 12;
            btnTuChoi.Text = "Từ chối ";
            btnTuChoi.UseVisualStyleBackColor = false;
            btnTuChoi.Click += btnTuChoi_Click;
            // 
            // btnDuyet
            // 
            btnDuyet.Anchor = AnchorStyles.None;
            btnDuyet.BackColor = Color.Silver;
            btnDuyet.FlatStyle = FlatStyle.Flat;
            btnDuyet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDuyet.ForeColor = Color.Black;
            btnDuyet.Location = new Point(134, 137);
            btnDuyet.Name = "btnDuyet";
            btnDuyet.Size = new Size(94, 35);
            btnDuyet.TabIndex = 11;
            btnDuyet.Text = "Duyệt";
            btnDuyet.UseVisualStyleBackColor = false;
            btnDuyet.Click += btnDuyet_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = Color.Silver;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(20, 137);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 35);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dtNgayKT
            // 
            dtNgayKT.Anchor = AnchorStyles.None;
            dtNgayKT.Format = DateTimePickerFormat.Short;
            dtNgayKT.Location = new Point(535, 49);
            dtNgayKT.Name = "dtNgayKT";
            dtNgayKT.Size = new Size(203, 27);
            dtNgayKT.TabIndex = 9;
            // 
            // dtNgayBD
            // 
            dtNgayBD.Anchor = AnchorStyles.None;
            dtNgayBD.Format = DateTimePickerFormat.Short;
            dtNgayBD.Location = new Point(535, 10);
            dtNgayBD.Name = "dtNgayBD";
            dtNgayBD.Size = new Size(203, 27);
            dtNgayBD.TabIndex = 8;
            // 
            // cbNhanVien
            // 
            cbNhanVien.Anchor = AnchorStyles.None;
            cbNhanVien.FormattingEnabled = true;
            cbNhanVien.Location = new Point(148, 9);
            cbNhanVien.Name = "cbNhanVien";
            cbNhanVien.Size = new Size(203, 28);
            cbNhanVien.TabIndex = 7;
            // 
            // txtLyDo
            // 
            txtLyDo.Anchor = AnchorStyles.None;
            txtLyDo.Location = new Point(148, 88);
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(471, 27);
            txtLyDo.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(440, 56);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 4;
            label6.Text = "Đến ngày";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(446, 17);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 3;
            label5.Text = "Từ ngày ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(86, 95);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 2;
            label4.Text = "Lý do ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(55, 56);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 1;
            label3.Text = "Trạng thái ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(55, 17);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 0;
            label2.Text = "Nhân viên ";
            // 
            // panelMain
            // 
            panelMain.Controls.Add(dgvNghiPhep);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 238);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(800, 212);
            panelMain.TabIndex = 5;
            // 
            // dgvNghiPhep
            // 
            dgvNghiPhep.AllowUserToAddRows = false;
            dgvNghiPhep.AllowUserToDeleteRows = false;
            dgvNghiPhep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNghiPhep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNghiPhep.Columns.AddRange(new DataGridViewColumn[] { MaNghiPhep, MaNV, TenNhanVien, TuNgay, DenNgay, LyDo, TrangThai });
            dgvNghiPhep.Dock = DockStyle.Fill;
            dgvNghiPhep.EnableHeadersVisualStyles = false;
            dgvNghiPhep.Location = new Point(0, 0);
            dgvNghiPhep.MultiSelect = false;
            dgvNghiPhep.Name = "dgvNghiPhep";
            dgvNghiPhep.RowHeadersVisible = false;
            dgvNghiPhep.RowHeadersWidth = 51;
            dgvNghiPhep.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNghiPhep.Size = new Size(800, 212);
            dgvNghiPhep.TabIndex = 6;
            dgvNghiPhep.CellClick += dgvNghiPhep_CellClick;
            // 
            // MaNghiPhep
            // 
            MaNghiPhep.DataPropertyName = "MaNghiPhep";
            MaNghiPhep.HeaderText = "Mã Đơn";
            MaNghiPhep.MinimumWidth = 6;
            MaNghiPhep.Name = "MaNghiPhep";
            // 
            // MaNV
            // 
            MaNV.DataPropertyName = "MaNV";
            MaNV.HeaderText = "Mã nhân viên ";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            MaNV.Visible = false;
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Họ và tên ";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            // 
            // TuNgay
            // 
            TuNgay.DataPropertyName = "TuNgay";
            TuNgay.HeaderText = "Từ ngày";
            TuNgay.MinimumWidth = 6;
            TuNgay.Name = "TuNgay";
            // 
            // DenNgay
            // 
            DenNgay.DataPropertyName = "DenNgay";
            DenNgay.HeaderText = "Đến ngày";
            DenNgay.MinimumWidth = 6;
            DenNgay.Name = "DenNgay";
            // 
            // LyDo
            // 
            LyDo.DataPropertyName = "LyDo";
            LyDo.HeaderText = "Lý do";
            LyDo.MinimumWidth = 6;
            LyDo.Name = "LyDo";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng thái ";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            // 
            // NghiPhep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMain);
            Controls.Add(panelInput);
            Controls.Add(panelHeader);
            Name = "NghiPhep";
            Text = "NghiPhep";
            Load += NghiPhep_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNghiPhep).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private Panel panelInput;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnTuChoi;
        private Button btnDuyet;
        private Button btnThem;
        private DateTimePicker dtNgayKT;
        private DateTimePicker dtNgayBD;
        private ComboBox cbNhanVien;
        private TextBox txtLyDo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnTimKiem;
        private Panel panelMain;
        private DataGridView dgvNghiPhep;
        private Button btnLuu;
        private DataGridViewTextBoxColumn MaNghiPhep;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn TuNgay;
        private DataGridViewTextBoxColumn DenNgay;
        private DataGridViewTextBoxColumn LyDo;
        private DataGridViewTextBoxColumn TrangThai;
        private TextBox txtTrangThai;
        private Button btnXuat;
    }
}