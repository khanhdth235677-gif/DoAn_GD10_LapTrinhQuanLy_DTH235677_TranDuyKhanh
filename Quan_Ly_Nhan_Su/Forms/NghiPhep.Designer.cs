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
            btnTimKiem = new Button();
            btnXuat = new Button();
            btnXoa = new Button();
            btnTuChoi = new Button();
            btnDuyet = new Button();
            btnThem = new Button();
            dtNgayKT = new DateTimePicker();
            dtNgayBD = new DateTimePicker();
            cbTenNV = new ComboBox();
            cbTrangThai = new ComboBox();
            txtLyDo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panelMain = new Panel();
            dgvNghiPhep = new DataGridView();
            MaNghiPhep = new DataGridViewTextBoxColumn();
            MaNhanVien = new DataGridViewTextBoxColumn();
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
            panelInput.Controls.Add(btnTimKiem);
            panelInput.Controls.Add(btnXuat);
            panelInput.Controls.Add(btnXoa);
            panelInput.Controls.Add(btnTuChoi);
            panelInput.Controls.Add(btnDuyet);
            panelInput.Controls.Add(btnThem);
            panelInput.Controls.Add(dtNgayKT);
            panelInput.Controls.Add(dtNgayBD);
            panelInput.Controls.Add(cbTenNV);
            panelInput.Controls.Add(cbTrangThai);
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
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(644, 88);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 15;
            btnTimKiem.Text = "Tìm kiếm ";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.DeepPink;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXuat.ForeColor = Color.White;
            btnXuat.Location = new Point(644, 137);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 35);
            btnXuat.TabIndex = 14;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.DeepPink;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(504, 137);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 35);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnTuChoi
            // 
            btnTuChoi.BackColor = Color.DeepPink;
            btnTuChoi.FlatStyle = FlatStyle.Flat;
            btnTuChoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnTuChoi.ForeColor = Color.White;
            btnTuChoi.Location = new Point(358, 137);
            btnTuChoi.Name = "btnTuChoi";
            btnTuChoi.Size = new Size(94, 35);
            btnTuChoi.TabIndex = 12;
            btnTuChoi.Text = "Từ chối ";
            btnTuChoi.UseVisualStyleBackColor = false;
            // 
            // btnDuyet
            // 
            btnDuyet.BackColor = Color.DeepPink;
            btnDuyet.FlatStyle = FlatStyle.Flat;
            btnDuyet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDuyet.ForeColor = Color.White;
            btnDuyet.Location = new Point(211, 137);
            btnDuyet.Name = "btnDuyet";
            btnDuyet.Size = new Size(94, 35);
            btnDuyet.TabIndex = 11;
            btnDuyet.Text = "Duyệt";
            btnDuyet.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DeepPink;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(55, 137);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 35);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // dtNgayKT
            // 
            dtNgayKT.Format = DateTimePickerFormat.Short;
            dtNgayKT.Location = new Point(535, 49);
            dtNgayKT.Name = "dtNgayKT";
            dtNgayKT.Size = new Size(203, 27);
            dtNgayKT.TabIndex = 9;
            // 
            // dtNgayBD
            // 
            dtNgayBD.Format = DateTimePickerFormat.Short;
            dtNgayBD.Location = new Point(535, 10);
            dtNgayBD.Name = "dtNgayBD";
            dtNgayBD.Size = new Size(203, 27);
            dtNgayBD.TabIndex = 8;
            // 
            // cbTenNV
            // 
            cbTenNV.FormattingEnabled = true;
            cbTenNV.Location = new Point(148, 9);
            cbTenNV.Name = "cbTenNV";
            cbTenNV.Size = new Size(203, 28);
            cbTenNV.TabIndex = 7;
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(148, 48);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(203, 28);
            cbTrangThai.TabIndex = 6;
            // 
            // txtLyDo
            // 
            txtLyDo.Location = new Point(148, 88);
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(471, 27);
            txtLyDo.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(440, 56);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 4;
            label6.Text = "Đến ngày";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(446, 17);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 3;
            label5.Text = "Từ ngày ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 95);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 2;
            label4.Text = "Lý do ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 56);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 1;
            label3.Text = "Trạng thái ";
            // 
            // label2
            // 
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
            dgvNghiPhep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNghiPhep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNghiPhep.Columns.AddRange(new DataGridViewColumn[] { MaNghiPhep, MaNhanVien, TenNhanVien, TuNgay, DenNgay, LyDo, TrangThai });
            dgvNghiPhep.Dock = DockStyle.Fill;
            dgvNghiPhep.Location = new Point(0, 0);
            dgvNghiPhep.Name = "dgvNghiPhep";
            dgvNghiPhep.RowHeadersVisible = false;
            dgvNghiPhep.RowHeadersWidth = 51;
            dgvNghiPhep.Size = new Size(800, 212);
            dgvNghiPhep.TabIndex = 6;
            // 
            // MaNghiPhep
            // 
            MaNghiPhep.DataPropertyName = "MaNghiPhep";
            MaNghiPhep.HeaderText = "Mã nghỉ phép";
            MaNghiPhep.MinimumWidth = 6;
            MaNghiPhep.Name = "MaNghiPhep";
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Mã NV";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Tên nhân viên ";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            // 
            // TuNgay
            // 
            TuNgay.DataPropertyName = "TuNgay";
            TuNgay.HeaderText = "Từ ngày ";
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
            LyDo.HeaderText = "Lý do ";
            LyDo.MinimumWidth = 6;
            LyDo.Name = "LyDo";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng Thái ";
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
        private Button btnXuat;
        private Button btnXoa;
        private Button btnTuChoi;
        private Button btnDuyet;
        private Button btnThem;
        private DateTimePicker dtNgayKT;
        private DateTimePicker dtNgayBD;
        private ComboBox cbTenNV;
        private ComboBox cbTrangThai;
        private TextBox txtLyDo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnTimKiem;
        private Panel panelMain;
        private DataGridView dgvNghiPhep;
        private DataGridViewTextBoxColumn MaNghiPhep;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn TuNgay;
        private DataGridViewTextBoxColumn DenNgay;
        private DataGridViewTextBoxColumn LyDo;
        private DataGridViewTextBoxColumn TrangThai;
    }
}