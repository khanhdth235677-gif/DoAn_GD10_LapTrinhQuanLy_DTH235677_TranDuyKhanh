namespace Quan_Ly_Nhan_Su.Forms
{
    partial class ChamCong
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
            dtpThang = new DateTimePicker();
            label9 = new Label();
            lblTongTangCa = new Label();
            lblNgayCongThucTe = new Label();
            lblNgayCongMacDinh = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            numTangCa = new NumericUpDown();
            cbTrangThai = new ComboBox();
            dtpNgay = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cbNhanVien = new ComboBox();
            label2 = new Label();
            panelButton = new Panel();
            btnXuat = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            panelMain = new Panel();
            dgvChamCong = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            Ngay = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            GioTangCa = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTangCa).BeginInit();
            panelButton.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Teal;
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(774, 50);
            panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 9);
            label1.Name = "label1";
            label1.Size = new Size(302, 31);
            label1.TabIndex = 0;
            label1.Text = "Thông tin bảng chấm công";
            // 
            // panelInput
            // 
            panelInput.BackColor = Color.WhiteSmoke;
            panelInput.Controls.Add(dtpThang);
            panelInput.Controls.Add(label9);
            panelInput.Controls.Add(lblTongTangCa);
            panelInput.Controls.Add(lblNgayCongThucTe);
            panelInput.Controls.Add(lblNgayCongMacDinh);
            panelInput.Controls.Add(label8);
            panelInput.Controls.Add(label7);
            panelInput.Controls.Add(label6);
            panelInput.Controls.Add(numTangCa);
            panelInput.Controls.Add(cbTrangThai);
            panelInput.Controls.Add(dtpNgay);
            panelInput.Controls.Add(label5);
            panelInput.Controls.Add(label4);
            panelInput.Controls.Add(label3);
            panelInput.Controls.Add(cbNhanVien);
            panelInput.Controls.Add(label2);
            panelInput.Dock = DockStyle.Top;
            panelInput.Location = new Point(0, 50);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(774, 184);
            panelInput.TabIndex = 1;
            // 
            // dtpThang
            // 
            dtpThang.Anchor = AnchorStyles.None;
            dtpThang.CustomFormat = "MM/yyyy";
            dtpThang.Format = DateTimePickerFormat.Custom;
            dtpThang.Location = new Point(569, 12);
            dtpThang.Name = "dtpThang";
            dtpThang.ShowUpDown = true;
            dtpThang.Size = new Size(185, 27);
            dtpThang.TabIndex = 28;
            dtpThang.ValueChanged += dtpThang_ValueChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(461, 18);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 27;
            label9.Text = "Tháng";
            // 
            // lblTongTangCa
            // 
            lblTongTangCa.Anchor = AnchorStyles.None;
            lblTongTangCa.AutoSize = true;
            lblTongTangCa.Location = new Point(609, 138);
            lblTongTangCa.Name = "lblTongTangCa";
            lblTongTangCa.Size = new Size(119, 20);
            lblTongTangCa.TabIndex = 26;
            lblTongTangCa.Text = "tổng giờ tăng ca";
            // 
            // lblNgayCongThucTe
            // 
            lblNgayCongThucTe.Anchor = AnchorStyles.None;
            lblNgayCongThucTe.AutoSize = true;
            lblNgayCongThucTe.Location = new Point(609, 99);
            lblNgayCongThucTe.Name = "lblNgayCongThucTe";
            lblNgayCongThucTe.Size = new Size(113, 20);
            lblNgayCongThucTe.TabIndex = 25;
            lblNgayCongThucTe.Text = "tổng ngày công";
            // 
            // lblNgayCongMacDinh
            // 
            lblNgayCongMacDinh.Anchor = AnchorStyles.None;
            lblNgayCongMacDinh.AutoSize = true;
            lblNgayCongMacDinh.Location = new Point(609, 58);
            lblNgayCongMacDinh.Name = "lblNgayCongMacDinh";
            lblNgayCongMacDinh.Size = new Size(25, 20);
            lblNgayCongMacDinh.TabIndex = 24;
            lblNgayCongMacDinh.Text = "26";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(452, 138);
            label8.Name = "label8";
            label8.Size = new Size(129, 20);
            label8.TabIndex = 23;
            label8.Text = "Tổng giờ tăng ca: ";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(443, 99);
            label7.Name = "label7";
            label7.Size = new Size(138, 20);
            label7.TabIndex = 22;
            label7.Text = "Ngày công thực tế: ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(428, 58);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 21;
            label6.Text = "Ngày công mặc định: ";
            label6.Click += label6_Click;
            // 
            // numTangCa
            // 
            numTangCa.Anchor = AnchorStyles.None;
            numTangCa.Location = new Point(140, 133);
            numTangCa.Name = "numTangCa";
            numTangCa.Size = new Size(185, 27);
            numTangCa.TabIndex = 20;
            // 
            // cbTrangThai
            // 
            cbTrangThai.Anchor = AnchorStyles.None;
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Items.AddRange(new object[] { "đã chấm công", "nghỉ", "nghỉ phép" });
            cbTrangThai.Location = new Point(140, 91);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(185, 28);
            cbTrangThai.TabIndex = 19;
            // 
            // dtpNgay
            // 
            dtpNgay.Anchor = AnchorStyles.None;
            dtpNgay.CustomFormat = "dd/MM/yyyy";
            dtpNgay.Format = DateTimePickerFormat.Custom;
            dtpNgay.Location = new Point(140, 53);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(185, 27);
            dtpNgay.TabIndex = 18;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(20, 140);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 6;
            label5.Text = "Giờ tăng ca";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(20, 99);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 4;
            label4.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(20, 60);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày";
            // 
            // cbNhanVien
            // 
            cbNhanVien.Anchor = AnchorStyles.None;
            cbNhanVien.FormattingEnabled = true;
            cbNhanVien.Location = new Point(140, 11);
            cbNhanVien.Name = "cbNhanVien";
            cbNhanVien.Size = new Size(185, 28);
            cbNhanVien.TabIndex = 1;
            cbNhanVien.SelectedIndexChanged += cbNhanVien_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(20, 19);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 0;
            label2.Text = "Nhân viên ";
            // 
            // panelButton
            // 
            panelButton.BackColor = Color.Transparent;
            panelButton.Controls.Add(btnXuat);
            panelButton.Controls.Add(btnLuu);
            panelButton.Controls.Add(btnSua);
            panelButton.Controls.Add(btnLamMoi);
            panelButton.Controls.Add(btnThem);
            panelButton.Controls.Add(btnXoa);
            panelButton.Dock = DockStyle.Right;
            panelButton.Location = new Point(631, 234);
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(143, 234);
            panelButton.TabIndex = 3;
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.None;
            btnXuat.BackColor = Color.DeepPink;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXuat.ForeColor = Color.White;
            btnXuat.Location = new Point(27, 191);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 5;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.BackColor = Color.DeepPink;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(27, 156);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = Color.DeepPink;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(27, 121);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.None;
            btnLamMoi.BackColor = Color.DeepPink;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(27, 86);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = Color.DeepPink;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(27, 51);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = Color.DeepPink;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(27, 16);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXóa_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(dgvChamCong);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 234);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(631, 234);
            panelMain.TabIndex = 4;
            // 
            // dgvChamCong
            // 
            dgvChamCong.AllowUserToAddRows = false;
            dgvChamCong.AllowUserToDeleteRows = false;
            dgvChamCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChamCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamCong.Columns.AddRange(new DataGridViewColumn[] { ID, TenNhanVien, Ngay, TrangThai, GioTangCa });
            dgvChamCong.Dock = DockStyle.Fill;
            dgvChamCong.EnableHeadersVisualStyles = false;
            dgvChamCong.Location = new Point(0, 0);
            dgvChamCong.MultiSelect = false;
            dgvChamCong.Name = "dgvChamCong";
            dgvChamCong.RowHeadersVisible = false;
            dgvChamCong.RowHeadersWidth = 51;
            dgvChamCong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChamCong.Size = new Size(631, 234);
            dgvChamCong.TabIndex = 5;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Nhân viên ";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            // 
            // Ngay
            // 
            Ngay.DataPropertyName = "Ngay";
            Ngay.HeaderText = "Ngày";
            Ngay.MinimumWidth = 6;
            Ngay.Name = "Ngay";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng thái ";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            // 
            // GioTangCa
            // 
            GioTangCa.DataPropertyName = "GioTangCa";
            GioTangCa.HeaderText = "Giờ tăng ca";
            GioTangCa.MinimumWidth = 6;
            GioTangCa.Name = "GioTangCa";
            // 
            // ChamCong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(774, 468);
            Controls.Add(panelMain);
            Controls.Add(panelButton);
            Controls.Add(panelInput);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ChamCong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChamCong";
            Load += ChamCong_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTangCa).EndInit();
            panelButton.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private Panel panelInput;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cbNhanVien;
        private Label label2;
        private Panel panelButton;
        private Button btnSua;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnXoa;
        private Panel panelMain;
        private NumericUpDown numTangCa;
        private ComboBox cbTrangThai;
        private DateTimePicker dtpNgay;
        private Label lblTongTangCa;
        private Label lblNgayCongThucTe;
        private Label lblNgayCongMacDinh;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnLuu;
        private DataGridView dgvChamCong;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn Ngay;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewTextBoxColumn GioTangCa;
        private DateTimePicker dtpThang;
        private Label label9;
        private Button btnXuat;
    }
}