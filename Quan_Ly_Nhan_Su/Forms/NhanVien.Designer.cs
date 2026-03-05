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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            tabControl1 = new TabControl();
            tabDanhSachNhanVien = new TabPage();
            panelMain = new Panel();
            dgvNhanVien = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenPhongBan = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            DanToc = new DataGridViewTextBoxColumn();
            CCCD = new DataGridViewTextBoxColumn();
            NoiCap = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            panelFilter = new Panel();
            btnTimKiem = new Button();
            txtHoTen = new TextBox();
            label3 = new Label();
            cbPhong = new ComboBox();
            label2 = new Label();
            cbChucVu = new ComboBox();
            label1 = new Label();
            panelButton = new Panel();
            btnExcel = new Button();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panelHeader = new Panel();
            label4 = new Label();
            tabNhanVienDuAn = new TabPage();
            panelMain1 = new Panel();
            dgvNhanVienDuAn = new DataGridView();
            MaNV = new DataGridViewTextBoxColumn();
            HoTenColumn = new DataGridViewTextBoxColumn();
            TenPhongBanColumn = new DataGridViewTextBoxColumn();
            TenDuAn = new DataGridViewTextBoxColumn();
            VaiTro = new DataGridViewTextBoxColumn();
            GiaTri = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            panelButton2 = new Panel();
            btnHuyBo = new Button();
            btnXuatDA = new Button();
            btnLuuDA = new Button();
            btnSuaDA = new Button();
            btnXoaDA = new Button();
            btnThemDA = new Button();
            panelInput = new Panel();
            cbDuAn = new ComboBox();
            cbVaiTro = new ComboBox();
            label9 = new Label();
            txtGiaTri = new TextBox();
            btnXoay = new Button();
            btnDoiAnh = new Button();
            picHinhAnh = new PictureBox();
            label11 = new Label();
            label10 = new Label();
            cbTenPhongBanDA = new ComboBox();
            label8 = new Label();
            txtHoTenNV = new TextBox();
            label7 = new Label();
            txtMaNV = new TextBox();
            label6 = new Label();
            panelHeader1 = new Panel();
            label5 = new Label();
            tabNhanVienChiTiet = new TabPage();
            panelMain2 = new Panel();
            dgvChiTietNhanVien = new DataGridView();
            IDCT = new DataGridViewTextBoxColumn();
            TenPhongBanCT = new DataGridViewTextBoxColumn();
            HoTenCT = new DataGridViewTextBoxColumn();
            NgaySinhCT = new DataGridViewTextBoxColumn();
            DiaChiCT = new DataGridViewTextBoxColumn();
            GioiTinhCT = new DataGridViewTextBoxColumn();
            DanTocCT = new DataGridViewTextBoxColumn();
            CCCDCT = new DataGridViewTextBoxColumn();
            NoiCapCT = new DataGridViewTextBoxColumn();
            ChucVuCT = new DataGridViewTextBoxColumn();
            panelButton1 = new Panel();
            btnQuayLai = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            panelInput1 = new Panel();
            cbChucVuCT = new ComboBox();
            txtCCCDCT = new TextBox();
            txtDanTocCT = new TextBox();
            radNuCT = new RadioButton();
            radNamCT = new RadioButton();
            txtDiaChiCT = new TextBox();
            txtNoiCapCT = new TextBox();
            dtpNgaySinhCT = new DateTimePicker();
            cbPhongBanCT = new ComboBox();
            txtHoTenCT = new TextBox();
            txtMaNVCT = new TextBox();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            panelHeader2 = new Panel();
            label13 = new Label();
            tabControl1.SuspendLayout();
            tabDanhSachNhanVien.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            panelFilter.SuspendLayout();
            panelButton.SuspendLayout();
            panelHeader.SuspendLayout();
            tabNhanVienDuAn.SuspendLayout();
            panelMain1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVienDuAn).BeginInit();
            panelButton2.SuspendLayout();
            panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            panelHeader1.SuspendLayout();
            tabNhanVienChiTiet.SuspendLayout();
            panelMain2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietNhanVien).BeginInit();
            panelButton1.SuspendLayout();
            panelInput1.SuspendLayout();
            panelHeader2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabDanhSachNhanVien);
            tabControl1.Controls.Add(tabNhanVienDuAn);
            tabControl1.Controls.Add(tabNhanVienChiTiet);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.ItemSize = new Size(230, 30);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(774, 468);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            tabControl1.DrawItem += tabControl1_DrawItem;
            // 
            // tabDanhSachNhanVien
            // 
            tabDanhSachNhanVien.Controls.Add(panelMain);
            tabDanhSachNhanVien.Controls.Add(panelFilter);
            tabDanhSachNhanVien.Controls.Add(panelButton);
            tabDanhSachNhanVien.Controls.Add(panelHeader);
            tabDanhSachNhanVien.Location = new Point(4, 34);
            tabDanhSachNhanVien.Name = "tabDanhSachNhanVien";
            tabDanhSachNhanVien.Padding = new Padding(3);
            tabDanhSachNhanVien.Size = new Size(766, 430);
            tabDanhSachNhanVien.TabIndex = 0;
            tabDanhSachNhanVien.Text = "Danh sách nhân viên ";
            tabDanhSachNhanVien.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(dgvNhanVien);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(3, 124);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(760, 239);
            panelMain.TabIndex = 11;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { ID, TenPhongBan, HoTen, NgaySinh, DiaChi, GioiTinh, DanToc, CCCD, NoiCap, ChucVu });
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.Location = new Point(0, 0);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(760, 239);
            dgvNhanVien.TabIndex = 5;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "Mã NV";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenPhongBan
            // 
            TenPhongBan.DataPropertyName = "TenPhongBan";
            TenPhongBan.HeaderText = "Tên phòng ";
            TenPhongBan.MinimumWidth = 6;
            TenPhongBan.Name = "TenPhongBan";
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ tên ";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày sinh ";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới tính ";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            // 
            // DanToc
            // 
            DanToc.DataPropertyName = "DanToc";
            DanToc.HeaderText = "Dân tộc";
            DanToc.MinimumWidth = 6;
            DanToc.Name = "DanToc";
            // 
            // CCCD
            // 
            CCCD.DataPropertyName = "CCCD";
            CCCD.HeaderText = "CCCD";
            CCCD.MinimumWidth = 6;
            CCCD.Name = "CCCD";
            // 
            // NoiCap
            // 
            NoiCap.DataPropertyName = "NoiCap";
            NoiCap.HeaderText = "Nơi cấp ";
            NoiCap.MinimumWidth = 6;
            NoiCap.Name = "NoiCap";
            // 
            // ChucVu
            // 
            ChucVu.DataPropertyName = "ChucVu";
            ChucVu.HeaderText = "Chức vụ";
            ChucVu.MinimumWidth = 6;
            ChucVu.Name = "ChucVu";
            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.WhiteSmoke;
            panelFilter.Controls.Add(btnTimKiem);
            panelFilter.Controls.Add(txtHoTen);
            panelFilter.Controls.Add(label3);
            panelFilter.Controls.Add(cbPhong);
            panelFilter.Controls.Add(label2);
            panelFilter.Controls.Add(cbChucVu);
            panelFilter.Controls.Add(label1);
            panelFilter.Dock = DockStyle.Top;
            panelFilter.Location = new Point(3, 53);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(760, 71);
            panelFilter.TabIndex = 8;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(660, 21);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm ";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = Color.White;
            txtHoTen.Font = new Font("Segoe UI", 10.2F);
            txtHoTen.Location = new Point(482, 21);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(166, 30);
            txtHoTen.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(422, 26);
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
            // cbChucVu
            // 
            cbChucVu.BackColor = Color.White;
            cbChucVu.FlatStyle = FlatStyle.Flat;
            cbChucVu.Font = new Font("Segoe UI", 10.2F);
            cbChucVu.FormattingEnabled = true;
            cbChucVu.Location = new Point(73, 21);
            cbChucVu.Name = "cbChucVu";
            cbChucVu.Size = new Size(120, 31);
            cbChucVu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 26);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Chức vụ";
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
            panelButton.Location = new Point(3, 363);
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(760, 64);
            panelButton.TabIndex = 10;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.DeepPink;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnExcel.ForeColor = Color.White;
            btnExcel.Location = new Point(624, 12);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(115, 43);
            btnExcel.TabIndex = 4;
            btnExcel.Text = "Xuất Excel ";
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.DeepPink;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(479, 12);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(115, 43);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DeepPink;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(336, 12);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(115, 43);
            btnSua.TabIndex = 2;
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
            btnXoa.Location = new Point(179, 12);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(115, 43);
            btnXoa.TabIndex = 1;
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
            btnThem.Location = new Point(23, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(115, 43);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Teal;
            panelHeader.Controls.Add(label4);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(3, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(760, 50);
            panelHeader.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 9);
            label4.Name = "label4";
            label4.Size = new Size(241, 31);
            label4.TabIndex = 0;
            label4.Text = "Danh sách nhân viên ";
            // 
            // tabNhanVienDuAn
            // 
            tabNhanVienDuAn.Controls.Add(panelMain1);
            tabNhanVienDuAn.Controls.Add(panelButton2);
            tabNhanVienDuAn.Controls.Add(panelInput);
            tabNhanVienDuAn.Controls.Add(panelHeader1);
            tabNhanVienDuAn.Location = new Point(4, 34);
            tabNhanVienDuAn.Name = "tabNhanVienDuAn";
            tabNhanVienDuAn.Padding = new Padding(3);
            tabNhanVienDuAn.Size = new Size(766, 430);
            tabNhanVienDuAn.TabIndex = 1;
            tabNhanVienDuAn.Text = "Nhân viên - dự án ";
            tabNhanVienDuAn.UseVisualStyleBackColor = true;
            // 
            // panelMain1
            // 
            panelMain1.Controls.Add(dgvNhanVienDuAn);
            panelMain1.Dock = DockStyle.Fill;
            panelMain1.Location = new Point(3, 212);
            panelMain1.Name = "panelMain1";
            panelMain1.Size = new Size(760, 164);
            panelMain1.TabIndex = 5;
            // 
            // dgvNhanVienDuAn
            // 
            dgvNhanVienDuAn.AllowUserToAddRows = false;
            dgvNhanVienDuAn.AllowUserToDeleteRows = false;
            dgvNhanVienDuAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVienDuAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVienDuAn.Columns.AddRange(new DataGridViewColumn[] { MaNV, HoTenColumn, TenPhongBanColumn, TenDuAn, VaiTro, GiaTri, HinhAnh });
            dgvNhanVienDuAn.Dock = DockStyle.Fill;
            dgvNhanVienDuAn.EnableHeadersVisualStyles = false;
            dgvNhanVienDuAn.Location = new Point(0, 0);
            dgvNhanVienDuAn.MultiSelect = false;
            dgvNhanVienDuAn.Name = "dgvNhanVienDuAn";
            dgvNhanVienDuAn.RowHeadersVisible = false;
            dgvNhanVienDuAn.RowHeadersWidth = 51;
            dgvNhanVienDuAn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVienDuAn.Size = new Size(760, 164);
            dgvNhanVienDuAn.TabIndex = 7;
            dgvNhanVienDuAn.CellClick += dgvNhanVienDuAn_CellClick;
            dgvNhanVienDuAn.CellFormatting += dgvNhanVienDuAn_CellFormatting;
            // 
            // MaNV
            // 
            MaNV.DataPropertyName = "MaNV";
            MaNV.HeaderText = "Mã nhân viên";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            MaNV.ReadOnly = true;
            // 
            // HoTenColumn
            // 
            HoTenColumn.DataPropertyName = "HoTen";
            HoTenColumn.HeaderText = "Họ tên NV";
            HoTenColumn.MinimumWidth = 6;
            HoTenColumn.Name = "HoTenColumn";
            HoTenColumn.ReadOnly = true;
            // 
            // TenPhongBanColumn
            // 
            TenPhongBanColumn.DataPropertyName = "TenPhongBan";
            TenPhongBanColumn.HeaderText = "Phòng ban";
            TenPhongBanColumn.MinimumWidth = 6;
            TenPhongBanColumn.Name = "TenPhongBanColumn";
            TenPhongBanColumn.ReadOnly = true;
            // 
            // TenDuAn
            // 
            TenDuAn.DataPropertyName = "TenDuAn";
            TenDuAn.HeaderText = "Dự án ";
            TenDuAn.MinimumWidth = 6;
            TenDuAn.Name = "TenDuAn";
            TenDuAn.ReadOnly = true;
            // 
            // VaiTro
            // 
            VaiTro.DataPropertyName = "VaiTro";
            VaiTro.HeaderText = "Vai trò";
            VaiTro.MinimumWidth = 6;
            VaiTro.Name = "VaiTro";
            VaiTro.ReadOnly = true;
            // 
            // GiaTri
            // 
            GiaTri.DataPropertyName = "GiaTri";
            GiaTri.HeaderText = "Giá trị";
            GiaTri.MinimumWidth = 6;
            GiaTri.Name = "GiaTri";
            GiaTri.ReadOnly = true;
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh ";
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            // 
            // panelButton2
            // 
            panelButton2.Controls.Add(btnHuyBo);
            panelButton2.Controls.Add(btnXuatDA);
            panelButton2.Controls.Add(btnLuuDA);
            panelButton2.Controls.Add(btnSuaDA);
            panelButton2.Controls.Add(btnXoaDA);
            panelButton2.Controls.Add(btnThemDA);
            panelButton2.Dock = DockStyle.Bottom;
            panelButton2.Location = new Point(3, 376);
            panelButton2.Name = "panelButton2";
            panelButton2.Size = new Size(760, 51);
            panelButton2.TabIndex = 5;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.DeepPink;
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnHuyBo.ForeColor = Color.White;
            btnHuyBo.Location = new Point(508, 8);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(83, 35);
            btnHuyBo.TabIndex = 24;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click_1;
            // 
            // btnXuatDA
            // 
            btnXuatDA.BackColor = Color.DeepPink;
            btnXuatDA.FlatStyle = FlatStyle.Flat;
            btnXuatDA.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXuatDA.ForeColor = Color.White;
            btnXuatDA.Location = new Point(606, 8);
            btnXuatDA.Name = "btnXuatDA";
            btnXuatDA.Size = new Size(94, 35);
            btnXuatDA.TabIndex = 23;
            btnXuatDA.Text = "Xuất Excel    ";
            btnXuatDA.UseVisualStyleBackColor = false;
            // 
            // btnLuuDA
            // 
            btnLuuDA.BackColor = Color.DeepPink;
            btnLuuDA.FlatStyle = FlatStyle.Flat;
            btnLuuDA.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLuuDA.ForeColor = Color.White;
            btnLuuDA.Location = new Point(398, 8);
            btnLuuDA.Name = "btnLuuDA";
            btnLuuDA.Size = new Size(94, 35);
            btnLuuDA.TabIndex = 22;
            btnLuuDA.Text = "Lưu";
            btnLuuDA.UseVisualStyleBackColor = false;
            btnLuuDA.Click += btnLuuDA_Click;
            // 
            // btnSuaDA
            // 
            btnSuaDA.BackColor = Color.DeepPink;
            btnSuaDA.FlatStyle = FlatStyle.Flat;
            btnSuaDA.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSuaDA.ForeColor = Color.White;
            btnSuaDA.Location = new Point(288, 8);
            btnSuaDA.Name = "btnSuaDA";
            btnSuaDA.Size = new Size(94, 35);
            btnSuaDA.TabIndex = 21;
            btnSuaDA.Text = "Sửa ";
            btnSuaDA.UseVisualStyleBackColor = false;
            btnSuaDA.Click += btnSuaDA_Click;
            // 
            // btnXoaDA
            // 
            btnXoaDA.BackColor = Color.DeepPink;
            btnXoaDA.FlatStyle = FlatStyle.Flat;
            btnXoaDA.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoaDA.ForeColor = Color.White;
            btnXoaDA.Location = new Point(173, 8);
            btnXoaDA.Name = "btnXoaDA";
            btnXoaDA.Size = new Size(94, 35);
            btnXoaDA.TabIndex = 20;
            btnXoaDA.Text = "Xóa";
            btnXoaDA.UseVisualStyleBackColor = false;
            btnXoaDA.Click += btnXoaDA_Click;
            // 
            // btnThemDA
            // 
            btnThemDA.BackColor = Color.DeepPink;
            btnThemDA.FlatStyle = FlatStyle.Flat;
            btnThemDA.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThemDA.ForeColor = Color.White;
            btnThemDA.Location = new Point(61, 8);
            btnThemDA.Name = "btnThemDA";
            btnThemDA.Size = new Size(94, 35);
            btnThemDA.TabIndex = 19;
            btnThemDA.Text = "Thêm ";
            btnThemDA.UseVisualStyleBackColor = false;
            btnThemDA.Click += btnThemDA_Click;
            // 
            // panelInput
            // 
            panelInput.Controls.Add(cbDuAn);
            panelInput.Controls.Add(cbVaiTro);
            panelInput.Controls.Add(label9);
            panelInput.Controls.Add(txtGiaTri);
            panelInput.Controls.Add(btnXoay);
            panelInput.Controls.Add(btnDoiAnh);
            panelInput.Controls.Add(picHinhAnh);
            panelInput.Controls.Add(label11);
            panelInput.Controls.Add(label10);
            panelInput.Controls.Add(cbTenPhongBanDA);
            panelInput.Controls.Add(label8);
            panelInput.Controls.Add(txtHoTenNV);
            panelInput.Controls.Add(label7);
            panelInput.Controls.Add(txtMaNV);
            panelInput.Controls.Add(label6);
            panelInput.Dock = DockStyle.Top;
            panelInput.Location = new Point(3, 53);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(760, 159);
            panelInput.TabIndex = 4;
            // 
            // cbDuAn
            // 
            cbDuAn.FormattingEnabled = true;
            cbDuAn.Location = new Point(150, 125);
            cbDuAn.Name = "cbDuAn";
            cbDuAn.Size = new Size(414, 28);
            cbDuAn.TabIndex = 21;
            // 
            // cbVaiTro
            // 
            cbVaiTro.FormattingEnabled = true;
            cbVaiTro.Location = new Point(413, 72);
            cbVaiTro.Name = "cbVaiTro";
            cbVaiTro.Size = new Size(151, 28);
            cbVaiTro.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(350, 80);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 19;
            label9.Text = "Vai trò";
            // 
            // txtGiaTri
            // 
            txtGiaTri.Location = new Point(150, 89);
            txtGiaTri.Name = "txtGiaTri";
            txtGiaTri.Size = new Size(151, 27);
            txtGiaTri.TabIndex = 18;
            // 
            // btnXoay
            // 
            btnXoay.BackColor = Color.Transparent;
            btnXoay.FlatAppearance.BorderSize = 0;
            btnXoay.FlatStyle = FlatStyle.Flat;
            btnXoay.Image = (Image)resources.GetObject("btnXoay.Image");
            btnXoay.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoay.Location = new Point(672, 100);
            btnXoay.Name = "btnXoay";
            btnXoay.Padding = new Padding(10, 0, 0, 0);
            btnXoay.Size = new Size(59, 51);
            btnXoay.TabIndex = 16;
            btnXoay.TextAlign = ContentAlignment.MiddleRight;
            btnXoay.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoay.UseVisualStyleBackColor = true;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.FlatAppearance.BorderSize = 0;
            btnDoiAnh.FlatStyle = FlatStyle.Flat;
            btnDoiAnh.Image = (Image)resources.GetObject("btnDoiAnh.Image");
            btnDoiAnh.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoiAnh.Location = new Point(606, 100);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Padding = new Padding(10, 0, 0, 0);
            btnDoiAnh.Size = new Size(59, 51);
            btnDoiAnh.TabIndex = 16;
            btnDoiAnh.TextAlign = ContentAlignment.MiddleRight;
            btnDoiAnh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(606, 12);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(125, 88);
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picHinhAnh.TabIndex = 15;
            picHinhAnh.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(74, 96);
            label11.Name = "label11";
            label11.Size = new Size(49, 20);
            label11.TabIndex = 10;
            label11.Text = "Giá trị";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(70, 131);
            label10.Name = "label10";
            label10.Size = new Size(53, 20);
            label10.TabIndex = 8;
            label10.Text = "Dự án ";
            // 
            // cbTenPhongBanDA
            // 
            cbTenPhongBanDA.FormattingEnabled = true;
            cbTenPhongBanDA.Location = new Point(413, 11);
            cbTenPhongBanDA.Name = "cbTenPhongBanDA";
            cbTenPhongBanDA.Size = new Size(151, 28);
            cbTenPhongBanDA.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(318, 19);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 4;
            label8.Text = "Phòng ban ";
            // 
            // txtHoTenNV
            // 
            txtHoTenNV.Location = new Point(149, 50);
            txtHoTenNV.Name = "txtHoTenNV";
            txtHoTenNV.Size = new Size(151, 27);
            txtHoTenNV.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 57);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 2;
            label7.Text = "Tên nhân viên ";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(149, 12);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(151, 27);
            txtMaNV.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 19);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 0;
            label6.Text = "Mã nhân viên ";
            // 
            // panelHeader1
            // 
            panelHeader1.BackColor = Color.Teal;
            panelHeader1.Controls.Add(label5);
            panelHeader1.Dock = DockStyle.Top;
            panelHeader1.Location = new Point(3, 3);
            panelHeader1.Name = "panelHeader1";
            panelHeader1.Size = new Size(760, 50);
            panelHeader1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 9);
            label5.Name = "label5";
            label5.Size = new Size(211, 31);
            label5.TabIndex = 0;
            label5.Text = "Nhân viên - dự án ";
            // 
            // tabNhanVienChiTiet
            // 
            tabNhanVienChiTiet.Controls.Add(panelMain2);
            tabNhanVienChiTiet.Controls.Add(panelButton1);
            tabNhanVienChiTiet.Controls.Add(panelInput1);
            tabNhanVienChiTiet.Controls.Add(panelHeader2);
            tabNhanVienChiTiet.Location = new Point(4, 34);
            tabNhanVienChiTiet.Name = "tabNhanVienChiTiet";
            tabNhanVienChiTiet.Padding = new Padding(3);
            tabNhanVienChiTiet.Size = new Size(766, 430);
            tabNhanVienChiTiet.TabIndex = 2;
            tabNhanVienChiTiet.Text = "Thông tin nhân viên chi tiết ";
            tabNhanVienChiTiet.UseVisualStyleBackColor = true;
            // 
            // panelMain2
            // 
            panelMain2.Controls.Add(dgvChiTietNhanVien);
            panelMain2.Dock = DockStyle.Fill;
            panelMain2.Location = new Point(3, 241);
            panelMain2.Name = "panelMain2";
            panelMain2.Size = new Size(760, 122);
            panelMain2.TabIndex = 4;
            // 
            // dgvChiTietNhanVien
            // 
            dgvChiTietNhanVien.AllowUserToAddRows = false;
            dgvChiTietNhanVien.AllowUserToDeleteRows = false;
            dgvChiTietNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietNhanVien.Columns.AddRange(new DataGridViewColumn[] { IDCT, TenPhongBanCT, HoTenCT, NgaySinhCT, DiaChiCT, GioiTinhCT, DanTocCT, CCCDCT, NoiCapCT, ChucVuCT });
            dgvChiTietNhanVien.Dock = DockStyle.Fill;
            dgvChiTietNhanVien.EnableHeadersVisualStyles = false;
            dgvChiTietNhanVien.Location = new Point(0, 0);
            dgvChiTietNhanVien.MultiSelect = false;
            dgvChiTietNhanVien.Name = "dgvChiTietNhanVien";
            dgvChiTietNhanVien.RowHeadersVisible = false;
            dgvChiTietNhanVien.RowHeadersWidth = 51;
            dgvChiTietNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietNhanVien.Size = new Size(760, 122);
            dgvChiTietNhanVien.TabIndex = 6;
            dgvChiTietNhanVien.CellClick += dgvChiTietNhanVien_CellClick;
            // 
            // IDCT
            // 
            IDCT.DataPropertyName = "ID";
            IDCT.HeaderText = "Mã NV";
            IDCT.MinimumWidth = 6;
            IDCT.Name = "IDCT";
            // 
            // TenPhongBanCT
            // 
            TenPhongBanCT.DataPropertyName = "TenPhongBan";
            TenPhongBanCT.HeaderText = "Tên phòng ";
            TenPhongBanCT.MinimumWidth = 6;
            TenPhongBanCT.Name = "TenPhongBanCT";
            // 
            // HoTenCT
            // 
            HoTenCT.DataPropertyName = "HoTen";
            HoTenCT.HeaderText = "Họ tên ";
            HoTenCT.MinimumWidth = 6;
            HoTenCT.Name = "HoTenCT";
            // 
            // NgaySinhCT
            // 
            NgaySinhCT.DataPropertyName = "NgaySinh";
            NgaySinhCT.HeaderText = "Ngày sinh ";
            NgaySinhCT.MinimumWidth = 6;
            NgaySinhCT.Name = "NgaySinhCT";
            // 
            // DiaChiCT
            // 
            DiaChiCT.DataPropertyName = "DiaChi";
            DiaChiCT.HeaderText = "Địa chỉ";
            DiaChiCT.MinimumWidth = 6;
            DiaChiCT.Name = "DiaChiCT";
            // 
            // GioiTinhCT
            // 
            GioiTinhCT.DataPropertyName = "GioiTinh";
            GioiTinhCT.HeaderText = "Giới tính ";
            GioiTinhCT.MinimumWidth = 6;
            GioiTinhCT.Name = "GioiTinhCT";
            // 
            // DanTocCT
            // 
            DanTocCT.DataPropertyName = "DanToc";
            DanTocCT.HeaderText = "Dân tộc";
            DanTocCT.MinimumWidth = 6;
            DanTocCT.Name = "DanTocCT";
            // 
            // CCCDCT
            // 
            CCCDCT.DataPropertyName = "CCCD";
            CCCDCT.HeaderText = "CCCD";
            CCCDCT.MinimumWidth = 6;
            CCCDCT.Name = "CCCDCT";
            // 
            // NoiCapCT
            // 
            NoiCapCT.DataPropertyName = "NoiCap";
            NoiCapCT.HeaderText = "Nơi cấp ";
            NoiCapCT.MinimumWidth = 6;
            NoiCapCT.Name = "NoiCapCT";
            // 
            // ChucVuCT
            // 
            ChucVuCT.DataPropertyName = "ChucVu";
            ChucVuCT.HeaderText = "Chức vụ";
            ChucVuCT.MinimumWidth = 6;
            ChucVuCT.Name = "ChucVuCT";
            // 
            // panelButton1
            // 
            panelButton1.Controls.Add(btnQuayLai);
            panelButton1.Controls.Add(btnHuy);
            panelButton1.Controls.Add(btnLuu);
            panelButton1.Dock = DockStyle.Bottom;
            panelButton1.Location = new Point(3, 363);
            panelButton1.Name = "panelButton1";
            panelButton1.Size = new Size(760, 64);
            panelButton1.TabIndex = 3;
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.DeepPink;
            btnQuayLai.FlatStyle = FlatStyle.Flat;
            btnQuayLai.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnQuayLai.ForeColor = Color.White;
            btnQuayLai.Location = new Point(488, 11);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(115, 43);
            btnQuayLai.TabIndex = 3;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.DeepPink;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(323, 11);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(115, 43);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.DeepPink;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(158, 11);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(115, 43);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // panelInput1
            // 
            panelInput1.Controls.Add(cbChucVuCT);
            panelInput1.Controls.Add(txtCCCDCT);
            panelInput1.Controls.Add(txtDanTocCT);
            panelInput1.Controls.Add(radNuCT);
            panelInput1.Controls.Add(radNamCT);
            panelInput1.Controls.Add(txtDiaChiCT);
            panelInput1.Controls.Add(txtNoiCapCT);
            panelInput1.Controls.Add(dtpNgaySinhCT);
            panelInput1.Controls.Add(cbPhongBanCT);
            panelInput1.Controls.Add(txtHoTenCT);
            panelInput1.Controls.Add(txtMaNVCT);
            panelInput1.Controls.Add(label23);
            panelInput1.Controls.Add(label22);
            panelInput1.Controls.Add(label21);
            panelInput1.Controls.Add(label20);
            panelInput1.Controls.Add(label19);
            panelInput1.Controls.Add(label18);
            panelInput1.Controls.Add(label17);
            panelInput1.Controls.Add(label16);
            panelInput1.Controls.Add(label15);
            panelInput1.Controls.Add(label14);
            panelInput1.Dock = DockStyle.Top;
            panelInput1.Location = new Point(3, 48);
            panelInput1.Name = "panelInput1";
            panelInput1.Size = new Size(760, 193);
            panelInput1.TabIndex = 2;
            // 
            // cbChucVuCT
            // 
            cbChucVuCT.FormattingEnabled = true;
            cbChucVuCT.Location = new Point(515, 147);
            cbChucVuCT.Name = "cbChucVuCT";
            cbChucVuCT.Size = new Size(209, 28);
            cbChucVuCT.TabIndex = 20;
            // 
            // txtCCCDCT
            // 
            txtCCCDCT.Location = new Point(515, 114);
            txtCCCDCT.Name = "txtCCCDCT";
            txtCCCDCT.Size = new Size(209, 27);
            txtCCCDCT.TabIndex = 19;
            // 
            // txtDanTocCT
            // 
            txtDanTocCT.Location = new Point(515, 81);
            txtDanTocCT.Name = "txtDanTocCT";
            txtDanTocCT.Size = new Size(209, 27);
            txtDanTocCT.TabIndex = 18;
            // 
            // radNuCT
            // 
            radNuCT.AutoSize = true;
            radNuCT.Location = new Point(645, 48);
            radNuCT.Name = "radNuCT";
            radNuCT.Size = new Size(50, 24);
            radNuCT.TabIndex = 17;
            radNuCT.TabStop = true;
            radNuCT.Text = "Nữ";
            radNuCT.UseVisualStyleBackColor = true;
            // 
            // radNamCT
            // 
            radNamCT.AutoSize = true;
            radNamCT.Location = new Point(515, 48);
            radNamCT.Name = "radNamCT";
            radNamCT.Size = new Size(62, 24);
            radNamCT.TabIndex = 16;
            radNamCT.TabStop = true;
            radNamCT.Text = "Nam";
            radNamCT.UseVisualStyleBackColor = true;
            // 
            // txtDiaChiCT
            // 
            txtDiaChiCT.Location = new Point(515, 11);
            txtDiaChiCT.Name = "txtDiaChiCT";
            txtDiaChiCT.Size = new Size(209, 27);
            txtDiaChiCT.TabIndex = 15;
            // 
            // txtNoiCapCT
            // 
            txtNoiCapCT.Location = new Point(132, 148);
            txtNoiCapCT.Name = "txtNoiCapCT";
            txtNoiCapCT.Size = new Size(209, 27);
            txtNoiCapCT.TabIndex = 14;
            // 
            // dtpNgaySinhCT
            // 
            dtpNgaySinhCT.Location = new Point(132, 114);
            dtpNgaySinhCT.Name = "dtpNgaySinhCT";
            dtpNgaySinhCT.Size = new Size(209, 27);
            dtpNgaySinhCT.TabIndex = 13;
            // 
            // cbPhongBanCT
            // 
            cbPhongBanCT.FormattingEnabled = true;
            cbPhongBanCT.Location = new Point(132, 80);
            cbPhongBanCT.Name = "cbPhongBanCT";
            cbPhongBanCT.Size = new Size(209, 28);
            cbPhongBanCT.TabIndex = 12;
            // 
            // txtHoTenCT
            // 
            txtHoTenCT.Location = new Point(132, 45);
            txtHoTenCT.Name = "txtHoTenCT";
            txtHoTenCT.Size = new Size(209, 27);
            txtHoTenCT.TabIndex = 11;
            // 
            // txtMaNVCT
            // 
            txtMaNVCT.Location = new Point(132, 11);
            txtMaNVCT.Name = "txtMaNVCT";
            txtMaNVCT.ReadOnly = true;
            txtMaNVCT.Size = new Size(209, 27);
            txtMaNVCT.TabIndex = 10;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(418, 155);
            label23.Name = "label23";
            label23.Size = new Size(65, 20);
            label23.TabIndex = 9;
            label23.Text = "Chức vụ ";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(45, 155);
            label22.Name = "label22";
            label22.Size = new Size(61, 20);
            label22.TabIndex = 8;
            label22.Text = "Nơi cấp";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(436, 121);
            label21.Name = "label21";
            label21.Size = new Size(47, 20);
            label21.TabIndex = 7;
            label21.Text = "CCCD";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(418, 88);
            label20.Name = "label20";
            label20.Size = new Size(65, 20);
            label20.TabIndex = 6;
            label20.Text = "Dân tộc ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(414, 52);
            label19.Name = "label19";
            label19.Size = new Size(69, 20);
            label19.TabIndex = 5;
            label19.Text = "Giới tính ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(428, 18);
            label18.Name = "label18";
            label18.Size = new Size(55, 20);
            label18.TabIndex = 4;
            label18.Text = "Địa chỉ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(32, 121);
            label17.Name = "label17";
            label17.Size = new Size(74, 20);
            label17.TabIndex = 3;
            label17.Text = "Ngày sinh";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(22, 88);
            label16.Name = "label16";
            label16.Size = new Size(84, 20);
            label16.TabIndex = 2;
            label16.Text = "Phòng ban ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(29, 52);
            label15.Name = "label15";
            label15.Size = new Size(77, 20);
            label15.TabIndex = 1;
            label15.Text = "Họ và tên ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(5, 18);
            label14.Name = "label14";
            label14.Size = new Size(101, 20);
            label14.TabIndex = 0;
            label14.Text = "Mã nhân viên ";
            // 
            // panelHeader2
            // 
            panelHeader2.BackColor = Color.Teal;
            panelHeader2.Controls.Add(label13);
            panelHeader2.Dock = DockStyle.Top;
            panelHeader2.Location = new Point(3, 3);
            panelHeader2.Name = "panelHeader2";
            panelHeader2.Size = new Size(760, 45);
            panelHeader2.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label13.ForeColor = Color.White;
            label13.Location = new Point(20, 10);
            label13.Name = "label13";
            label13.Size = new Size(276, 28);
            label13.TabIndex = 0;
            label13.Text = "Thông tin nhân viên chi tiết";
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(774, 468);
            Controls.Add(tabControl1);
            Name = "NhanVien";
            Text = "NhanVien";
            Load += NhanVien_Load;
            tabControl1.ResumeLayout(false);
            tabDanhSachNhanVien.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            panelButton.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tabNhanVienDuAn.ResumeLayout(false);
            panelMain1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVienDuAn).EndInit();
            panelButton2.ResumeLayout(false);
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            panelHeader1.ResumeLayout(false);
            panelHeader1.PerformLayout();
            tabNhanVienChiTiet.ResumeLayout(false);
            panelMain2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTietNhanVien).EndInit();
            panelButton1.ResumeLayout(false);
            panelInput1.ResumeLayout(false);
            panelInput1.PerformLayout();
            panelHeader2.ResumeLayout(false);
            panelHeader2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabDanhSachNhanVien;
        private Panel panelFilter;
        private Button btnTimKiem;
        private TextBox txtHoTen;
        private Label label3;
        private ComboBox cbPhong;
        private Label label2;
        private ComboBox cbChucVu;
        private Label label1;
        private Panel panelButton;
        private Button btnExcel;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Panel panelHeader;
        private Label label4;
        private TabPage tabNhanVienDuAn;
        private Panel panelMain;
        private Panel panelHeader1;
        private Label label5;
        private Panel panelInput;
        private ComboBox cbTenPhongBanDA;
        private Label label8;
        private TextBox txtHoTenNV;
        private Label label7;
        private TextBox txtMaNV;
        private Label label6;
        private Label label10;
        private Label label11;
        private Button btnXoay;
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
        private Panel panelMain1;
        private DataGridView dgvNhanVien;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenPhongBan;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn DanToc;
        private DataGridViewTextBoxColumn CCCD;
        private DataGridViewTextBoxColumn NoiCap;
        private DataGridViewTextBoxColumn ChucVu;
        private TabPage tabNhanVienChiTiet;
        private Panel panelHeader2;
        private Label label13;
        private Panel panelMain2;
        private Panel panelButton1;
        private Panel panelInput1;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private ComboBox cbChucVuCT;
        private TextBox txtCCCDCT;
        private TextBox txtDanTocCT;
        private RadioButton radNuCT;
        private RadioButton radNamCT;
        private TextBox txtDiaChiCT;
        private TextBox txtNoiCapCT;
        private DateTimePicker dtpNgaySinhCT;
        private ComboBox cbPhongBanCT;
        private TextBox txtHoTenCT;
        private TextBox txtMaNVCT;
        private DataGridView dgvChiTietNhanVien;
        private Button btnQuayLai;
        private Button btnHuy;
        private Button btnLuu;
        private DataGridViewTextBoxColumn IDCT;
        private DataGridViewTextBoxColumn TenPhongBanCT;
        private DataGridViewTextBoxColumn HoTenCT;
        private DataGridViewTextBoxColumn NgaySinhCT;
        private DataGridViewTextBoxColumn DiaChiCT;
        private DataGridViewTextBoxColumn GioiTinhCT;
        private DataGridViewTextBoxColumn DanTocCT;
        private DataGridViewTextBoxColumn CCCDCT;
        private DataGridViewTextBoxColumn NoiCapCT;
        private DataGridViewTextBoxColumn ChucVuCT;
        private Panel panelButton2;
        private TextBox txtGiaTri;
        private DataGridView dgvNhanVienDuAn;
        private ComboBox cbVaiTro;
        private Label label9;
        private Button btnHuyBo;
        private Button btnXuatDA;
        private Button btnLuuDA;
        private Button btnSuaDA;
        private Button btnXoaDA;
        private Button btnThemDA;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn HoTenColumn;
        private DataGridViewTextBoxColumn TenPhongBanColumn;
        private DataGridViewTextBoxColumn TenDuAn;
        private DataGridViewTextBoxColumn VaiTro;
        private DataGridViewTextBoxColumn GiaTri;
        private DataGridViewImageColumn HinhAnh;
        private ComboBox cbDuAn;
    }
}