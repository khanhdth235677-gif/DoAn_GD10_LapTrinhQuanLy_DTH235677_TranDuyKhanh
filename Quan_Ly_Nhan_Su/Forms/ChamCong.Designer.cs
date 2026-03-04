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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            label1 = new Label();
            panelInput = new Panel();
            label11 = new Label();
            txtSoGioThem = new TextBox();
            txtSoNgayCong = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtHoaHong = new TextBox();
            label7 = new Label();
            txtKyLuat = new TextBox();
            label6 = new Label();
            txtKhenThuong = new TextBox();
            label5 = new Label();
            txtPhuCapCV = new TextBox();
            label4 = new Label();
            txtLuongCoBan = new TextBox();
            label3 = new Label();
            cbMaLuong = new ComboBox();
            label2 = new Label();
            dgvChamCong = new DataGridView();
            MaNV = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            Thang = new DataGridViewTextBoxColumn();
            Nam = new DataGridViewTextBoxColumn();
            MaLuong = new DataGridViewTextBoxColumn();
            TienKhenThuong = new DataGridViewTextBoxColumn();
            TienKyLuat = new DataGridViewTextBoxColumn();
            panelButton = new Panel();
            btnXuatExcel = new Button();
            btnLamMoi = new Button();
            btnThem = new Button();
            btnTinhLuong = new Button();
            panelHeader.SuspendLayout();
            panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).BeginInit();
            panelButton.SuspendLayout();
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
            panelInput.Controls.Add(label11);
            panelInput.Controls.Add(txtSoGioThem);
            panelInput.Controls.Add(txtSoNgayCong);
            panelInput.Controls.Add(label10);
            panelInput.Controls.Add(label9);
            panelInput.Controls.Add(label8);
            panelInput.Controls.Add(txtHoaHong);
            panelInput.Controls.Add(label7);
            panelInput.Controls.Add(txtKyLuat);
            panelInput.Controls.Add(label6);
            panelInput.Controls.Add(txtKhenThuong);
            panelInput.Controls.Add(label5);
            panelInput.Controls.Add(txtPhuCapCV);
            panelInput.Controls.Add(label4);
            panelInput.Controls.Add(txtLuongCoBan);
            panelInput.Controls.Add(label3);
            panelInput.Controls.Add(cbMaLuong);
            panelInput.Controls.Add(label2);
            panelInput.Dock = DockStyle.Top;
            panelInput.Location = new Point(0, 50);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(774, 184);
            panelInput.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(532, 99);
            label11.Name = "label11";
            label11.Size = new Size(97, 20);
            label11.TabIndex = 17;
            label11.Text = "Số giờ thêm: ";
            // 
            // txtSoGioThem
            // 
            txtSoGioThem.Location = new Point(634, 99);
            txtSoGioThem.Name = "txtSoGioThem";
            txtSoGioThem.Size = new Size(125, 27);
            txtSoGioThem.TabIndex = 16;
            // 
            // txtSoNgayCong
            // 
            txtSoNgayCong.Location = new Point(631, 54);
            txtSoNgayCong.Name = "txtSoNgayCong";
            txtSoNgayCong.Size = new Size(125, 27);
            txtSoNgayCong.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(525, 19);
            label10.Name = "label10";
            label10.Size = new Size(240, 20);
            label10.TabIndex = 14;
            label10.Text = "Số ngày công mặc định 26 / tháng ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(647, 140);
            label9.Name = "label9";
            label9.Size = new Size(70, 28);
            label9.TabIndex = 13;
            label9.Text = "label9";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(532, 147);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 12;
            label8.Text = "Tổng lương: ";
            // 
            // txtHoaHong
            // 
            txtHoaHong.Location = new Point(384, 99);
            txtHoaHong.Name = "txtHoaHong";
            txtHoaHong.Size = new Size(125, 27);
            txtHoaHong.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(271, 99);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 10;
            label7.Text = "Hoa hồng DA: ";
            // 
            // txtKyLuat
            // 
            txtKyLuat.Location = new Point(384, 57);
            txtKyLuat.Name = "txtKyLuat";
            txtKyLuat.Size = new Size(125, 27);
            txtKyLuat.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(271, 57);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 8;
            label6.Text = "Kỷ luật: ";
            // 
            // txtKhenThuong
            // 
            txtKhenThuong.Location = new Point(384, 16);
            txtKhenThuong.Name = "txtKhenThuong";
            txtKhenThuong.Size = new Size(125, 27);
            txtKhenThuong.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(271, 16);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 6;
            label5.Text = "Khen thưởng: ";
            // 
            // txtPhuCapCV
            // 
            txtPhuCapCV.Location = new Point(127, 96);
            txtPhuCapCV.Name = "txtPhuCapCV";
            txtPhuCapCV.Size = new Size(125, 27);
            txtPhuCapCV.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 99);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 4;
            label4.Text = "Phụ cấp CV: ";
            // 
            // txtLuongCoBan
            // 
            txtLuongCoBan.Location = new Point(127, 54);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.Size = new Size(125, 27);
            txtLuongCoBan.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 57);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "Lương cơ bản: ";
            // 
            // cbMaLuong
            // 
            cbMaLuong.FormattingEnabled = true;
            cbMaLuong.Location = new Point(127, 16);
            cbMaLuong.Name = "cbMaLuong";
            cbMaLuong.Size = new Size(125, 28);
            cbMaLuong.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 16);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã lương: ";
            // 
            // dgvChamCong
            // 
            dgvChamCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvChamCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChamCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamCong.Columns.AddRange(new DataGridViewColumn[] { MaNV, HoTen, Thang, Nam, MaLuong, TienKhenThuong, TienKyLuat });
            dgvChamCong.Dock = DockStyle.Left;
            dgvChamCong.EnableHeadersVisualStyles = false;
            dgvChamCong.Location = new Point(0, 234);
            dgvChamCong.Name = "dgvChamCong";
            dgvChamCong.RowHeadersVisible = false;
            dgvChamCong.RowHeadersWidth = 51;
            dgvChamCong.Size = new Size(597, 234);
            dgvChamCong.TabIndex = 2;
            // 
            // MaNV
            // 
            MaNV.DataPropertyName = "MaNV";
            MaNV.HeaderText = "Mã nhân viên ";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ tên ";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            // 
            // Thang
            // 
            Thang.DataPropertyName = "Thang";
            Thang.HeaderText = "Tháng";
            Thang.MinimumWidth = 6;
            Thang.Name = "Thang";
            // 
            // Nam
            // 
            Nam.DataPropertyName = "Nam";
            Nam.HeaderText = "Năm";
            Nam.MinimumWidth = 6;
            Nam.Name = "Nam";
            // 
            // MaLuong
            // 
            MaLuong.DataPropertyName = "MaLuong";
            MaLuong.HeaderText = "Mã lương ";
            MaLuong.MinimumWidth = 6;
            MaLuong.Name = "MaLuong";
            // 
            // TienKhenThuong
            // 
            TienKhenThuong.DataPropertyName = "TienKhenThuong";
            TienKhenThuong.HeaderText = "Tiền khen thưởng";
            TienKhenThuong.MinimumWidth = 6;
            TienKhenThuong.Name = "TienKhenThuong";
            // 
            // TienKyLuat
            // 
            TienKyLuat.DataPropertyName = "TienKyLuat";
            TienKyLuat.HeaderText = "Tiên kỷ luật";
            TienKyLuat.MinimumWidth = 6;
            TienKyLuat.Name = "TienKyLuat";
            // 
            // panelButton
            // 
            panelButton.BackColor = Color.Transparent;
            panelButton.Controls.Add(btnXuatExcel);
            panelButton.Controls.Add(btnLamMoi);
            panelButton.Controls.Add(btnThem);
            panelButton.Controls.Add(btnTinhLuong);
            panelButton.Dock = DockStyle.Right;
            panelButton.Location = new Point(594, 234);
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(180, 234);
            panelButton.TabIndex = 3;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(46, 162);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(94, 29);
            btnXuatExcel.TabIndex = 3;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(46, 116);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(46, 71);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnTinhLuong
            // 
            btnTinhLuong.Location = new Point(46, 26);
            btnTinhLuong.Name = "btnTinhLuong";
            btnTinhLuong.Size = new Size(94, 29);
            btnTinhLuong.TabIndex = 0;
            btnTinhLuong.Text = "Tính lương";
            btnTinhLuong.UseVisualStyleBackColor = true;
            // 
            // ChamCong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(774, 468);
            Controls.Add(panelButton);
            Controls.Add(dgvChamCong);
            Controls.Add(panelInput);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ChamCong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChamCong";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).EndInit();
            panelButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private Panel panelInput;
        private TextBox txtKhenThuong;
        private Label label5;
        private TextBox txtPhuCapCV;
        private Label label4;
        private TextBox txtLuongCoBan;
        private Label label3;
        private ComboBox cbMaLuong;
        private Label label2;
        private Label label6;
        private TextBox txtHoaHong;
        private Label label7;
        private TextBox txtKyLuat;
        private Label label9;
        private Label label8;
        private Label label11;
        private TextBox txtSoGioThem;
        private TextBox txtSoNgayCong;
        private Label label10;
        private DataGridView dgvChamCong;
        private Panel panelButton;
        private Button btnXuatExcel;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnTinhLuong;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn Thang;
        private DataGridViewTextBoxColumn Nam;
        private DataGridViewTextBoxColumn MaLuong;
        private DataGridViewTextBoxColumn TienKhenThuong;
        private DataGridViewTextBoxColumn TienKyLuat;
    }
}