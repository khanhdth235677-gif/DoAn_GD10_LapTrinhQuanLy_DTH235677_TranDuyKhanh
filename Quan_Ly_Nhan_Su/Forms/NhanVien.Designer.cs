namespace Quan_Ly_Nhan_Su.Forms
{
    partial class NhanVien
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
            label4 = new Label();
            panelButton = new Panel();
            btnExcel = new Button();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panelGrid = new Panel();
            dgvNhanVien = new DataGridView();
            MaNV = new DataGridViewTextBoxColumn();
            MaPhong = new DataGridViewTextBoxColumn();
            MaLuong = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            DanToc = new DataGridViewTextBoxColumn();
            CMND = new DataGridViewTextBoxColumn();
            NoiCap = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            panelFilter = new Panel();
            btnTimKiem = new Button();
            txtHoTen = new TextBox();
            label3 = new Label();
            cbPhong = new ComboBox();
            label2 = new Label();
            cbBoPhan = new ComboBox();
            label1 = new Label();
            panelHeader.SuspendLayout();
            panelButton.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            panelFilter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Teal;
            panelHeader.Controls.Add(label4);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(774, 50);
            panelHeader.TabIndex = 3;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 9);
            label4.Name = "label4";
            label4.Size = new Size(236, 31);
            label4.TabIndex = 0;
            label4.Text = "Thông tin nhân viên ";
            // 
            // panelButton
            // 
            panelButton.BackColor = Color.WhiteSmoke;
            panelButton.Controls.Add(btnExcel);
            panelButton.Controls.Add(btnLamMoi);
            panelButton.Controls.Add(btnSua);
            panelButton.Controls.Add(btnXoa);
            panelButton.Controls.Add(btnThem);
            panelButton.Dock = DockStyle.Bottom;
            panelButton.Location = new Point(0, 378);
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(774, 90);
            panelButton.TabIndex = 6;
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(624, 28);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(115, 43);
            btnExcel.TabIndex = 4;
            btnExcel.Text = "Xuất Excel ";
            btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(479, 28);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(115, 43);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(336, 28);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(115, 43);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(179, 28);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(115, 43);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(23, 28);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(115, 43);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // panelGrid
            // 
            panelGrid.BackColor = Color.White;
            panelGrid.Controls.Add(dgvNhanVien);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 121);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(774, 347);
            panelGrid.TabIndex = 5;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { MaNV, MaPhong, MaLuong, HoTen, NgaySinh, GioiTinh, DanToc, CMND, NoiCap, ChucVu });
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 0);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(774, 347);
            dgvNhanVien.TabIndex = 0;
            // 
            // MaNV
            // 
            MaNV.DataPropertyName = "MaNV";
            MaNV.HeaderText = "Mã nhân viên";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            MaNV.ReadOnly = true;
            // 
            // MaPhong
            // 
            MaPhong.DataPropertyName = "MaPhong";
            MaPhong.HeaderText = "Mã phòng ";
            MaPhong.MinimumWidth = 6;
            MaPhong.Name = "MaPhong";
            MaPhong.ReadOnly = true;
            // 
            // MaLuong
            // 
            MaLuong.DataPropertyName = "MaLuong";
            MaLuong.HeaderText = "Mã lương";
            MaLuong.MinimumWidth = 6;
            MaLuong.Name = "MaLuong";
            MaLuong.ReadOnly = true;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            // 
            // DanToc
            // 
            DanToc.DataPropertyName = "DanToc";
            DanToc.HeaderText = "Dân tộc";
            DanToc.MinimumWidth = 6;
            DanToc.Name = "DanToc";
            DanToc.ReadOnly = true;
            // 
            // CMND
            // 
            CMND.DataPropertyName = "CMND";
            CMND.HeaderText = "CMND-CCCD";
            CMND.MinimumWidth = 6;
            CMND.Name = "CMND";
            CMND.ReadOnly = true;
            // 
            // NoiCap
            // 
            NoiCap.DataPropertyName = "NoiCap";
            NoiCap.HeaderText = "Nơi cấp";
            NoiCap.MinimumWidth = 6;
            NoiCap.Name = "NoiCap";
            NoiCap.ReadOnly = true;
            // 
            // ChucVu
            // 
            ChucVu.DataPropertyName = "ChucVu";
            ChucVu.HeaderText = "Chức vụ";
            ChucVu.MinimumWidth = 6;
            ChucVu.Name = "ChucVu";
            ChucVu.ReadOnly = true;
            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.WhiteSmoke;
            panelFilter.Controls.Add(btnTimKiem);
            panelFilter.Controls.Add(txtHoTen);
            panelFilter.Controls.Add(label3);
            panelFilter.Controls.Add(cbPhong);
            panelFilter.Controls.Add(label2);
            panelFilter.Controls.Add(cbBoPhan);
            panelFilter.Controls.Add(label1);
            panelFilter.Dock = DockStyle.Top;
            panelFilter.Location = new Point(0, 50);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(774, 71);
            panelFilter.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(668, 21);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm ";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = Color.White;
            txtHoTen.Font = new Font("Segoe UI", 10.2F);
            txtHoTen.Location = new Point(490, 21);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(166, 30);
            txtHoTen.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 26);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "Họ tên";
            // 
            // cbPhong
            // 
            cbPhong.BackColor = Color.White;
            cbPhong.FlatStyle = FlatStyle.Flat;
            cbPhong.Font = new Font("Segoe UI", 10.2F);
            cbPhong.FormattingEnabled = true;
            cbPhong.Location = new Point(279, 21);
            cbPhong.Name = "cbPhong";
            cbPhong.Size = new Size(120, 31);
            cbPhong.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 26);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 2;
            label2.Text = "Phòng";
            // 
            // cbBoPhan
            // 
            cbBoPhan.BackColor = Color.White;
            cbBoPhan.FlatStyle = FlatStyle.Flat;
            cbBoPhan.Font = new Font("Segoe UI", 10.2F);
            cbBoPhan.FormattingEnabled = true;
            cbBoPhan.Location = new Point(73, 21);
            cbBoPhan.Name = "cbBoPhan";
            cbBoPhan.Size = new Size(120, 31);
            cbBoPhan.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 26);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Bộ phận";
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(774, 468);
            Controls.Add(panelButton);
            Controls.Add(panelGrid);
            Controls.Add(panelFilter);
            Controls.Add(panelHeader);
            Name = "NhanVien";
            Text = "NhanVien";
            Load += NhanVien_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelButton.ResumeLayout(false);
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Label label4;
        private Panel panelButton;
        private Button btnExcel;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Panel panelGrid;
        private DataGridView dgvNhanVien;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn MaPhong;
        private DataGridViewTextBoxColumn MaLuong;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn DanToc;
        private DataGridViewTextBoxColumn CMND;
        private DataGridViewTextBoxColumn NoiCap;
        private DataGridViewTextBoxColumn ChucVu;
        private Panel panelFilter;
        private Button btnTimKiem;
        private TextBox txtHoTen;
        private Label label3;
        private ComboBox cbPhong;
        private Label label2;
        private ComboBox cbBoPhan;
        private Label label1;
    }
}