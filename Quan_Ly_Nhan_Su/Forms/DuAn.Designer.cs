namespace Quan_Ly_Nhan_Su.Forms
{
    partial class DuAn
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabDanhSachDuAn = new TabPage();
            panelMain2 = new Panel();
            dgvDanhSachDuAn = new DataGridView();
            MaDA = new DataGridViewTextBoxColumn();
            TenDA = new DataGridViewTextBoxColumn();
            KhachHang = new DataGridViewTextBoxColumn();
            TenNVQL = new DataGridViewTextBoxColumn();
            TenPhongBan = new DataGridViewTextBoxColumn();
            NgayBD = new DataGridViewTextBoxColumn();
            NgayKTTT = new DataGridViewTextBoxColumn();
            NgayKTDK = new DataGridViewTextBoxColumn();
            GiaTri = new DataGridViewTextBoxColumn();
            TienDo = new DataGridViewTextBoxColumn();
            TinhTrang = new DataGridViewCheckBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            panelInput1 = new Panel();
            cbTenPhongBan = new ComboBox();
            btnTimKiem = new Button();
            label7 = new Label();
            cbTenDA = new ComboBox();
            label11 = new Label();
            cbMaDA = new ComboBox();
            label12 = new Label();
            panelButton = new Panel();
            button6 = new Button();
            button5 = new Button();
            btnHuyBo = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panelHeader2 = new Panel();
            label1 = new Label();
            tabPhanCongDuAn = new TabPage();
            panelMain = new Panel();
            dgvPhanCongDuAn = new DataGridView();
            MaDA1 = new DataGridViewTextBoxColumn();
            TenDA1 = new DataGridViewTextBoxColumn();
            KhachHang1 = new DataGridViewTextBoxColumn();
            TenNVQL1 = new DataGridViewTextBoxColumn();
            PhongBan1 = new DataGridViewTextBoxColumn();
            NgayBD1 = new DataGridViewTextBoxColumn();
            NgayKTTT1 = new DataGridViewTextBoxColumn();
            NgayKTDK1 = new DataGridViewTextBoxColumn();
            GiaTri1 = new DataGridViewTextBoxColumn();
            TienDo1 = new DataGridViewTextBoxColumn();
            TinhTrang1 = new DataGridViewCheckBoxColumn();
            GhiChu1 = new DataGridViewTextBoxColumn();
            panelButton1 = new Panel();
            btnQuayLai = new Button();
            btnLamMoi = new Button();
            btnLuu = new Button();
            panelInput = new Panel();
            cbTienDo = new ComboBox();
            txtGhiChu = new TextBox();
            label16 = new Label();
            label15 = new Label();
            cbPhongBan = new ComboBox();
            label14 = new Label();
            cbTenNhanVienQL = new ComboBox();
            label3 = new Label();
            label13 = new Label();
            dtNgayBD = new DateTimePicker();
            label8 = new Label();
            chkHoanThanh = new CheckBox();
            txtGiaTri = new TextBox();
            txtTenKhachHang = new TextBox();
            dtNgayKTTT = new DateTimePicker();
            dtNgayKTDK = new DateTimePicker();
            txtTenDuAn = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panelHeader = new Panel();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabDanhSachDuAn.SuspendLayout();
            panelMain2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachDuAn).BeginInit();
            panelInput1.SuspendLayout();
            panelButton.SuspendLayout();
            panelHeader2.SuspendLayout();
            tabPhanCongDuAn.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhanCongDuAn).BeginInit();
            panelButton1.SuspendLayout();
            panelInput.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabDanhSachDuAn);
            tabControl1.Controls.Add(tabPhanCongDuAn);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.ItemSize = new Size(150, 30);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1003, 450);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            tabControl1.DrawItem += tabControl1_DrawItem;
            // 
            // tabDanhSachDuAn
            // 
            tabDanhSachDuAn.Controls.Add(panelMain2);
            tabDanhSachDuAn.Controls.Add(panelInput1);
            tabDanhSachDuAn.Controls.Add(panelButton);
            tabDanhSachDuAn.Controls.Add(panelHeader2);
            tabDanhSachDuAn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tabDanhSachDuAn.ForeColor = Color.Black;
            tabDanhSachDuAn.Location = new Point(4, 34);
            tabDanhSachDuAn.Name = "tabDanhSachDuAn";
            tabDanhSachDuAn.Padding = new Padding(3);
            tabDanhSachDuAn.Size = new Size(792, 412);
            tabDanhSachDuAn.TabIndex = 0;
            tabDanhSachDuAn.Text = "Danh sách dự án ";
            tabDanhSachDuAn.UseVisualStyleBackColor = true;
            // 
            // panelMain2
            // 
            panelMain2.Controls.Add(dgvDanhSachDuAn);
            panelMain2.Dock = DockStyle.Fill;
            panelMain2.Location = new Point(3, 120);
            panelMain2.Name = "panelMain2";
            panelMain2.Size = new Size(786, 239);
            panelMain2.TabIndex = 9;
            // 
            // dgvDanhSachDuAn
            // 
            dgvDanhSachDuAn.AllowUserToAddRows = false;
            dgvDanhSachDuAn.AllowUserToDeleteRows = false;
            dgvDanhSachDuAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachDuAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachDuAn.Columns.AddRange(new DataGridViewColumn[] { MaDA, TenDA, KhachHang, TenNVQL, TenPhongBan, NgayBD, NgayKTTT, NgayKTDK, GiaTri, TienDo, TinhTrang, GhiChu });
            dgvDanhSachDuAn.Dock = DockStyle.Fill;
            dgvDanhSachDuAn.EnableHeadersVisualStyles = false;
            dgvDanhSachDuAn.Location = new Point(0, 0);
            dgvDanhSachDuAn.MultiSelect = false;
            dgvDanhSachDuAn.Name = "dgvDanhSachDuAn";
            dgvDanhSachDuAn.RowHeadersVisible = false;
            dgvDanhSachDuAn.RowHeadersWidth = 51;
            dgvDanhSachDuAn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachDuAn.Size = new Size(786, 239);
            dgvDanhSachDuAn.TabIndex = 5;
            // 
            // MaDA
            // 
            MaDA.DataPropertyName = "MaDA";
            MaDA.HeaderText = "Mã DA";
            MaDA.MinimumWidth = 6;
            MaDA.Name = "MaDA";
            // 
            // TenDA
            // 
            TenDA.DataPropertyName = "TenDA";
            TenDA.HeaderText = "Tên DA";
            TenDA.MinimumWidth = 6;
            TenDA.Name = "TenDA";
            // 
            // KhachHang
            // 
            KhachHang.DataPropertyName = "KhachHang";
            KhachHang.HeaderText = "Khách hàng";
            KhachHang.MinimumWidth = 6;
            KhachHang.Name = "KhachHang";
            // 
            // TenNVQL
            // 
            TenNVQL.DataPropertyName = "TenNVQL";
            TenNVQL.HeaderText = "Tên NV QL";
            TenNVQL.MinimumWidth = 6;
            TenNVQL.Name = "TenNVQL";
            // 
            // TenPhongBan
            // 
            TenPhongBan.DataPropertyName = "PhongBan";
            TenPhongBan.HeaderText = "Phòng ban ";
            TenPhongBan.MinimumWidth = 6;
            TenPhongBan.Name = "TenPhongBan";
            // 
            // NgayBD
            // 
            NgayBD.DataPropertyName = "NgayBD";
            dataGridViewCellStyle1.Format = "dd/MM/yyy";
            NgayBD.DefaultCellStyle = dataGridViewCellStyle1;
            NgayBD.HeaderText = "Ngày BD";
            NgayBD.MinimumWidth = 6;
            NgayBD.Name = "NgayBD";
            // 
            // NgayKTTT
            // 
            NgayKTTT.DataPropertyName = "NgayKTTT";
            dataGridViewCellStyle2.Format = "dd/MM/yyy";
            NgayKTTT.DefaultCellStyle = dataGridViewCellStyle2;
            NgayKTTT.HeaderText = "Ngày KTTT";
            NgayKTTT.MinimumWidth = 6;
            NgayKTTT.Name = "NgayKTTT";
            // 
            // NgayKTDK
            // 
            NgayKTDK.DataPropertyName = "NgayKTDK";
            dataGridViewCellStyle3.Format = "dd/MM/yyy";
            NgayKTDK.DefaultCellStyle = dataGridViewCellStyle3;
            NgayKTDK.HeaderText = "Ngày KTDK";
            NgayKTDK.MinimumWidth = 6;
            NgayKTDK.Name = "NgayKTDK";
            // 
            // GiaTri
            // 
            GiaTri.DataPropertyName = "GiaTri";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            GiaTri.DefaultCellStyle = dataGridViewCellStyle4;
            GiaTri.HeaderText = "Giá trị";
            GiaTri.MinimumWidth = 6;
            GiaTri.Name = "GiaTri";
            // 
            // TienDo
            // 
            TienDo.DataPropertyName = "TienDo";
            dataGridViewCellStyle5.Format = "0\\\\%";
            TienDo.DefaultCellStyle = dataGridViewCellStyle5;
            TienDo.HeaderText = "Tiến độ";
            TienDo.MinimumWidth = 6;
            TienDo.Name = "TienDo";
            // 
            // TinhTrang
            // 
            TinhTrang.DataPropertyName = "TinhTrang";
            TinhTrang.FalseValue = "false";
            TinhTrang.HeaderText = "Tình trạng";
            TinhTrang.MinimumWidth = 6;
            TinhTrang.Name = "TinhTrang";
            TinhTrang.TrueValue = "true";
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.HeaderText = "Ghi chú ";
            GhiChu.MinimumWidth = 6;
            GhiChu.Name = "GhiChu";
            // 
            // panelInput1
            // 
            panelInput1.Controls.Add(cbTenPhongBan);
            panelInput1.Controls.Add(btnTimKiem);
            panelInput1.Controls.Add(label7);
            panelInput1.Controls.Add(cbTenDA);
            panelInput1.Controls.Add(label11);
            panelInput1.Controls.Add(cbMaDA);
            panelInput1.Controls.Add(label12);
            panelInput1.Dock = DockStyle.Top;
            panelInput1.Location = new Point(3, 48);
            panelInput1.Name = "panelInput1";
            panelInput1.Size = new Size(786, 72);
            panelInput1.TabIndex = 10;
            // 
            // cbTenPhongBan
            // 
            cbTenPhongBan.Anchor = AnchorStyles.None;
            cbTenPhongBan.BackColor = Color.White;
            cbTenPhongBan.FlatStyle = FlatStyle.Flat;
            cbTenPhongBan.Font = new Font("Segoe UI", 10.2F);
            cbTenPhongBan.FormattingEnabled = true;
            cbTenPhongBan.Location = new Point(561, 19);
            cbTenPhongBan.Name = "cbTenPhongBan";
            cbTenPhongBan.Size = new Size(120, 31);
            cbTenPhongBan.TabIndex = 14;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.Location = new Point(687, 21);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm kiếm ";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(443, 26);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 11;
            label7.Text = "Tên phòng ban ";
            // 
            // cbTenDA
            // 
            cbTenDA.Anchor = AnchorStyles.None;
            cbTenDA.BackColor = Color.White;
            cbTenDA.FlatStyle = FlatStyle.Flat;
            cbTenDA.Font = new Font("Segoe UI", 10.2F);
            cbTenDA.FormattingEnabled = true;
            cbTenDA.Location = new Point(312, 19);
            cbTenDA.Name = "cbTenDA";
            cbTenDA.Size = new Size(120, 31);
            cbTenDA.TabIndex = 10;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new Point(233, 26);
            label11.Name = "label11";
            label11.Size = new Size(78, 20);
            label11.TabIndex = 9;
            label11.Text = "Tên dự án ";
            // 
            // cbMaDA
            // 
            cbMaDA.Anchor = AnchorStyles.None;
            cbMaDA.BackColor = Color.White;
            cbMaDA.FlatStyle = FlatStyle.Flat;
            cbMaDA.Font = new Font("Segoe UI", 10.2F);
            cbMaDA.FormattingEnabled = true;
            cbMaDA.Location = new Point(87, 19);
            cbMaDA.Name = "cbMaDA";
            cbMaDA.Size = new Size(120, 31);
            cbMaDA.TabIndex = 8;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Location = new Point(5, 26);
            label12.Name = "label12";
            label12.Size = new Size(76, 20);
            label12.TabIndex = 7;
            label12.Text = "Mã dự án ";
            // 
            // panelButton
            // 
            panelButton.Controls.Add(button6);
            panelButton.Controls.Add(button5);
            panelButton.Controls.Add(btnHuyBo);
            panelButton.Controls.Add(btnSua);
            panelButton.Controls.Add(btnXoa);
            panelButton.Controls.Add(btnThem);
            panelButton.Dock = DockStyle.Bottom;
            panelButton.Location = new Point(3, 359);
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(786, 50);
            panelButton.TabIndex = 9;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.BackColor = Color.DeepPink;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(661, 8);
            button6.Name = "button6";
            button6.Size = new Size(100, 35);
            button6.TabIndex = 13;
            button6.Text = "Xuất ";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.BackColor = Color.DeepPink;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(548, 8);
            button5.Name = "button5";
            button5.Size = new Size(100, 35);
            button5.TabIndex = 12;
            button5.Text = "Nhập";
            button5.UseVisualStyleBackColor = false;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.None;
            btnHuyBo.BackColor = Color.DeepPink;
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnHuyBo.ForeColor = Color.White;
            btnHuyBo.Location = new Point(433, 8);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(100, 35);
            btnHuyBo.TabIndex = 11;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = Color.DeepPink;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(312, 8);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(115, 35);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa dự án ";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = Color.DeepPink;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(172, 8);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 35);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa dự án ";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = Color.DeepPink;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(26, 8);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(128, 35);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm dự án ";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // panelHeader2
            // 
            panelHeader2.BackColor = Color.Teal;
            panelHeader2.Controls.Add(label1);
            panelHeader2.Dock = DockStyle.Top;
            panelHeader2.Location = new Point(3, 3);
            panelHeader2.Name = "panelHeader2";
            panelHeader2.Size = new Size(786, 45);
            panelHeader2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 10);
            label1.Name = "label1";
            label1.Size = new Size(176, 28);
            label1.TabIndex = 0;
            label1.Text = "Danh sách dự án ";
            // 
            // tabPhanCongDuAn
            // 
            tabPhanCongDuAn.Controls.Add(panelMain);
            tabPhanCongDuAn.Controls.Add(panelButton1);
            tabPhanCongDuAn.Controls.Add(panelInput);
            tabPhanCongDuAn.Controls.Add(panelHeader);
            tabPhanCongDuAn.ForeColor = Color.Black;
            tabPhanCongDuAn.Location = new Point(4, 34);
            tabPhanCongDuAn.Name = "tabPhanCongDuAn";
            tabPhanCongDuAn.Padding = new Padding(3);
            tabPhanCongDuAn.Size = new Size(995, 412);
            tabPhanCongDuAn.TabIndex = 1;
            tabPhanCongDuAn.Text = "Phân công dự án ";
            tabPhanCongDuAn.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(dgvPhanCongDuAn);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(3, 312);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(989, 97);
            panelMain.TabIndex = 32;
            // 
            // dgvPhanCongDuAn
            // 
            dgvPhanCongDuAn.AllowUserToAddRows = false;
            dgvPhanCongDuAn.AllowUserToDeleteRows = false;
            dgvPhanCongDuAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhanCongDuAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhanCongDuAn.Columns.AddRange(new DataGridViewColumn[] { MaDA1, TenDA1, KhachHang1, TenNVQL1, PhongBan1, NgayBD1, NgayKTTT1, NgayKTDK1, GiaTri1, TienDo1, TinhTrang1, GhiChu1 });
            dgvPhanCongDuAn.Dock = DockStyle.Fill;
            dgvPhanCongDuAn.EnableHeadersVisualStyles = false;
            dgvPhanCongDuAn.Location = new Point(0, 0);
            dgvPhanCongDuAn.MultiSelect = false;
            dgvPhanCongDuAn.Name = "dgvPhanCongDuAn";
            dgvPhanCongDuAn.RowHeadersVisible = false;
            dgvPhanCongDuAn.RowHeadersWidth = 51;
            dgvPhanCongDuAn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhanCongDuAn.Size = new Size(989, 97);
            dgvPhanCongDuAn.TabIndex = 6;
            dgvPhanCongDuAn.CellClick += dgvPhanCongDuAn_CellClick;
            // 
            // MaDA1
            // 
            MaDA1.DataPropertyName = "MaDA";
            MaDA1.HeaderText = "Mã DA";
            MaDA1.MinimumWidth = 6;
            MaDA1.Name = "MaDA1";
            // 
            // TenDA1
            // 
            TenDA1.DataPropertyName = "TenDA";
            TenDA1.HeaderText = "Tên DA";
            TenDA1.MinimumWidth = 6;
            TenDA1.Name = "TenDA1";
            // 
            // KhachHang1
            // 
            KhachHang1.DataPropertyName = "KhachHang";
            KhachHang1.HeaderText = "Khách hàng";
            KhachHang1.MinimumWidth = 6;
            KhachHang1.Name = "KhachHang1";
            // 
            // TenNVQL1
            // 
            TenNVQL1.DataPropertyName = "TenNVQL";
            TenNVQL1.HeaderText = "Tên NV QL";
            TenNVQL1.MinimumWidth = 6;
            TenNVQL1.Name = "TenNVQL1";
            // 
            // PhongBan1
            // 
            PhongBan1.DataPropertyName = "PhongBan";
            PhongBan1.HeaderText = "Phòng ban ";
            PhongBan1.MinimumWidth = 6;
            PhongBan1.Name = "PhongBan1";
            // 
            // NgayBD1
            // 
            NgayBD1.DataPropertyName = "NgayBD";
            dataGridViewCellStyle6.Format = "dd/MM/yyy";
            NgayBD1.DefaultCellStyle = dataGridViewCellStyle6;
            NgayBD1.HeaderText = "Ngày BD";
            NgayBD1.MinimumWidth = 6;
            NgayBD1.Name = "NgayBD1";
            // 
            // NgayKTTT1
            // 
            NgayKTTT1.DataPropertyName = "NgayKTTT";
            dataGridViewCellStyle7.Format = "dd/MM/yyy";
            NgayKTTT1.DefaultCellStyle = dataGridViewCellStyle7;
            NgayKTTT1.HeaderText = "Ngày KTTT";
            NgayKTTT1.MinimumWidth = 6;
            NgayKTTT1.Name = "NgayKTTT1";
            // 
            // NgayKTDK1
            // 
            NgayKTDK1.DataPropertyName = "NgayKTDK";
            dataGridViewCellStyle8.Format = "dd/MM/yyy";
            NgayKTDK1.DefaultCellStyle = dataGridViewCellStyle8;
            NgayKTDK1.HeaderText = "Ngày KTDK";
            NgayKTDK1.MinimumWidth = 6;
            NgayKTDK1.Name = "NgayKTDK1";
            // 
            // GiaTri1
            // 
            GiaTri1.DataPropertyName = "GiaTri";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            GiaTri1.DefaultCellStyle = dataGridViewCellStyle9;
            GiaTri1.HeaderText = "Giá trị";
            GiaTri1.MinimumWidth = 6;
            GiaTri1.Name = "GiaTri1";
            // 
            // TienDo1
            // 
            TienDo1.DataPropertyName = "TienDo";
            dataGridViewCellStyle10.Format = "0\\\\%";
            TienDo1.DefaultCellStyle = dataGridViewCellStyle10;
            TienDo1.HeaderText = "Tiến độ";
            TienDo1.MinimumWidth = 6;
            TienDo1.Name = "TienDo1";
            // 
            // TinhTrang1
            // 
            TinhTrang1.DataPropertyName = "TinhTrang";
            TinhTrang1.FalseValue = "false";
            TinhTrang1.HeaderText = "Tình trạng";
            TinhTrang1.MinimumWidth = 6;
            TinhTrang1.Name = "TinhTrang1";
            TinhTrang1.TrueValue = "true";
            // 
            // GhiChu1
            // 
            GhiChu1.DataPropertyName = "GhiChu";
            GhiChu1.HeaderText = "Ghi chú ";
            GhiChu1.MinimumWidth = 6;
            GhiChu1.Name = "GhiChu1";
            // 
            // panelButton1
            // 
            panelButton1.Controls.Add(btnQuayLai);
            panelButton1.Controls.Add(btnLamMoi);
            panelButton1.Controls.Add(btnLuu);
            panelButton1.Dock = DockStyle.Top;
            panelButton1.Location = new Point(3, 265);
            panelButton1.Name = "panelButton1";
            panelButton1.Size = new Size(989, 47);
            panelButton1.TabIndex = 31;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Anchor = AnchorStyles.None;
            btnQuayLai.BackColor = Color.DeepPink;
            btnQuayLai.FlatStyle = FlatStyle.Flat;
            btnQuayLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuayLai.ForeColor = Color.White;
            btnQuayLai.Location = new Point(634, 6);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 35);
            btnQuayLai.TabIndex = 62;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.None;
            btnLamMoi.BackColor = Color.DeepPink;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(457, 6);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 35);
            btnLamMoi.TabIndex = 42;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.BackColor = Color.DeepPink;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(289, 6);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 35);
            btnLuu.TabIndex = 61;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // panelInput
            // 
            panelInput.Controls.Add(cbTienDo);
            panelInput.Controls.Add(txtGhiChu);
            panelInput.Controls.Add(label16);
            panelInput.Controls.Add(label15);
            panelInput.Controls.Add(cbPhongBan);
            panelInput.Controls.Add(label14);
            panelInput.Controls.Add(cbTenNhanVienQL);
            panelInput.Controls.Add(label3);
            panelInput.Controls.Add(label13);
            panelInput.Controls.Add(dtNgayBD);
            panelInput.Controls.Add(label8);
            panelInput.Controls.Add(chkHoanThanh);
            panelInput.Controls.Add(txtGiaTri);
            panelInput.Controls.Add(txtTenKhachHang);
            panelInput.Controls.Add(dtNgayKTTT);
            panelInput.Controls.Add(dtNgayKTDK);
            panelInput.Controls.Add(txtTenDuAn);
            panelInput.Controls.Add(label10);
            panelInput.Controls.Add(label9);
            panelInput.Controls.Add(label6);
            panelInput.Controls.Add(label5);
            panelInput.Controls.Add(label4);
            panelInput.Dock = DockStyle.Top;
            panelInput.Location = new Point(3, 48);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(989, 217);
            panelInput.TabIndex = 29;
            // 
            // cbTienDo
            // 
            cbTienDo.Anchor = AnchorStyles.None;
            cbTienDo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTienDo.FormattingEnabled = true;
            cbTienDo.Location = new Point(659, 115);
            cbTienDo.Name = "cbTienDo";
            cbTienDo.Size = new Size(278, 28);
            cbTienDo.TabIndex = 61;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Anchor = AnchorStyles.None;
            txtGhiChu.Location = new Point(179, 182);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(758, 27);
            txtGhiChu.TabIndex = 60;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Location = new Point(86, 189);
            label16.Name = "label16";
            label16.Size = new Size(62, 20);
            label16.TabIndex = 59;
            label16.Text = "Ghi chú ";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Location = new Point(563, 123);
            label15.Name = "label15";
            label15.Size = new Size(59, 20);
            label15.TabIndex = 58;
            label15.Text = "Tiến độ";
            // 
            // cbPhongBan
            // 
            cbPhongBan.Anchor = AnchorStyles.None;
            cbPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPhongBan.FormattingEnabled = true;
            cbPhongBan.Location = new Point(179, 115);
            cbPhongBan.Name = "cbPhongBan";
            cbPhongBan.Size = new Size(278, 28);
            cbPhongBan.TabIndex = 56;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Location = new Point(64, 123);
            label14.Name = "label14";
            label14.Size = new Size(84, 20);
            label14.TabIndex = 55;
            label14.Text = "Phòng ban ";
            // 
            // cbTenNhanVienQL
            // 
            cbTenNhanVienQL.Anchor = AnchorStyles.None;
            cbTenNhanVienQL.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTenNhanVienQL.FormattingEnabled = true;
            cbTenNhanVienQL.Location = new Point(179, 81);
            cbTenNhanVienQL.Name = "cbTenNhanVienQL";
            cbTenNhanVienQL.Size = new Size(278, 28);
            cbTenNhanVienQL.TabIndex = 54;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(51, 89);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 52;
            label3.Text = "Nhân viên QL";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Location = new Point(543, 156);
            label13.Name = "label13";
            label13.Size = new Size(80, 20);
            label13.TabIndex = 51;
            label13.Text = "Tình trạng ";
            // 
            // dtNgayBD
            // 
            dtNgayBD.Anchor = AnchorStyles.None;
            dtNgayBD.Format = DateTimePickerFormat.Short;
            dtNgayBD.Location = new Point(659, 13);
            dtNgayBD.Name = "dtNgayBD";
            dtNgayBD.Size = new Size(278, 27);
            dtNgayBD.TabIndex = 50;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(555, 20);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 49;
            label8.Text = "Ngày BD";
            // 
            // chkHoanThanh
            // 
            chkHoanThanh.Anchor = AnchorStyles.None;
            chkHoanThanh.AutoSize = true;
            chkHoanThanh.Location = new Point(659, 156);
            chkHoanThanh.Name = "chkHoanThanh";
            chkHoanThanh.Size = new Size(112, 24);
            chkHoanThanh.TabIndex = 48;
            chkHoanThanh.Text = "Hoàn thành ";
            chkHoanThanh.UseVisualStyleBackColor = true;
            // 
            // txtGiaTri
            // 
            txtGiaTri.Anchor = AnchorStyles.None;
            txtGiaTri.Location = new Point(179, 149);
            txtGiaTri.Name = "txtGiaTri";
            txtGiaTri.Size = new Size(278, 27);
            txtGiaTri.TabIndex = 46;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Anchor = AnchorStyles.None;
            txtTenKhachHang.Location = new Point(179, 48);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(278, 27);
            txtTenKhachHang.TabIndex = 45;
            // 
            // dtNgayKTTT
            // 
            dtNgayKTTT.Anchor = AnchorStyles.None;
            dtNgayKTTT.Format = DateTimePickerFormat.Short;
            dtNgayKTTT.Location = new Point(659, 82);
            dtNgayKTTT.Name = "dtNgayKTTT";
            dtNgayKTTT.Size = new Size(278, 27);
            dtNgayKTTT.TabIndex = 38;
            // 
            // dtNgayKTDK
            // 
            dtNgayKTDK.Anchor = AnchorStyles.None;
            dtNgayKTDK.Format = DateTimePickerFormat.Short;
            dtNgayKTDK.Location = new Point(659, 48);
            dtNgayKTDK.Name = "dtNgayKTDK";
            dtNgayKTDK.Size = new Size(278, 27);
            dtNgayKTDK.TabIndex = 37;
            // 
            // txtTenDuAn
            // 
            txtTenDuAn.Anchor = AnchorStyles.None;
            txtTenDuAn.Location = new Point(179, 13);
            txtTenDuAn.Name = "txtTenDuAn";
            txtTenDuAn.Size = new Size(278, 27);
            txtTenDuAn.TabIndex = 35;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(542, 89);
            label10.Name = "label10";
            label10.Size = new Size(81, 20);
            label10.TabIndex = 34;
            label10.Text = "Ngày KTTT";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(538, 55);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 33;
            label9.Text = "Ngày KTDK";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(95, 153);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 31;
            label6.Text = "Giá trị ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(62, 55);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 30;
            label5.Text = "Khách hàng ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(74, 20);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 29;
            label4.Text = "Tên dự án";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Teal;
            panelHeader.Controls.Add(label2);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(3, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(989, 45);
            panelHeader.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 10);
            label2.Name = "label2";
            label2.Size = new Size(171, 28);
            label2.TabIndex = 0;
            label2.Text = "Phân công dự án";
            // 
            // DuAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 450);
            Controls.Add(tabControl1);
            Name = "DuAn";
            Text = "DuAn";
            Load += DuAn_Load;
            tabControl1.ResumeLayout(false);
            tabDanhSachDuAn.ResumeLayout(false);
            panelMain2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachDuAn).EndInit();
            panelInput1.ResumeLayout(false);
            panelInput1.PerformLayout();
            panelButton.ResumeLayout(false);
            panelHeader2.ResumeLayout(false);
            panelHeader2.PerformLayout();
            tabPhanCongDuAn.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhanCongDuAn).EndInit();
            panelButton1.ResumeLayout(false);
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabDanhSachDuAn;
        private TabPage tabPhanCongDuAn;
        private Panel panelHeader2;
        private Label label1;
        private Panel panelHeader;
        private Label label2;
        private Panel panelButton;
        private Button button6;
        private Button button5;
        private Button btnHuyBo;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Panel panelInput;
        private CheckBox chkHoanThanh;
        private TextBox txtMaDA;
        private TextBox txtGiaTri;
        private TextBox txtTenKhachHang;
        private Button btnLamMoi;
        private DateTimePicker dtNgayKTTT;
        private DateTimePicker dtNgayKTDK;
        private TextBox txtTenDuAn;
        private Label label10;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panelMain2;
        private DataGridView dgvDanhSachDuAn;
        private Panel panelInput1;
        private ComboBox cbTenPhongBan;
        private Button btnTimKiem;
        private Label label7;
        private ComboBox cbTenDA;
        private Label label11;
        private ComboBox cbMaDA;
        private Label label12;
        private Label label8;
        private DateTimePicker dtNgayBD;
        private Label label13;
        private ComboBox cbTenNhanVienQL;
        private Label label3;
        private ComboBox cbPhongBan;
        private Label label14;
        private TextBox txtGhiChu;
        private Label label16;
        private Label label15;
        private Button btnLuu;
        private Button btnQuayLai;
        private Panel panelButton1;
        private Panel panelMain;
        private DataGridView dgvPhanCongDuAn;
        private DataGridViewTextBoxColumn MaDA;
        private DataGridViewTextBoxColumn TenDA;
        private DataGridViewTextBoxColumn KhachHang;
        private DataGridViewTextBoxColumn TenNVQL;
        private DataGridViewTextBoxColumn TenPhongBan;
        private DataGridViewTextBoxColumn NgayBD;
        private DataGridViewTextBoxColumn NgayKTTT;
        private DataGridViewTextBoxColumn NgayKTDK;
        private DataGridViewTextBoxColumn GiaTri;
        private DataGridViewTextBoxColumn TienDo;
        private DataGridViewCheckBoxColumn TinhTrang;
        private DataGridViewTextBoxColumn GhiChu;
        private DataGridViewTextBoxColumn MaDA1;
        private DataGridViewTextBoxColumn TenDA1;
        private DataGridViewTextBoxColumn KhachHang1;
        private DataGridViewTextBoxColumn TenNVQL1;
        private DataGridViewTextBoxColumn PhongBan1;
        private DataGridViewTextBoxColumn NgayBD1;
        private DataGridViewTextBoxColumn NgayKTTT1;
        private DataGridViewTextBoxColumn NgayKTDK1;
        private DataGridViewTextBoxColumn GiaTri1;
        private DataGridViewTextBoxColumn TienDo1;
        private DataGridViewCheckBoxColumn TinhTrang1;
        private DataGridViewTextBoxColumn GhiChu1;
        private ComboBox cbTienDo;
    }
}