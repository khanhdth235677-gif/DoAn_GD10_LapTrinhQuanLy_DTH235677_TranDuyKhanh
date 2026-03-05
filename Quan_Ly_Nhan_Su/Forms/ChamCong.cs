using Quan_Ly_Nhan_Su.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Quan_Ly_Nhan_Su.Forms
{
    public partial class ChamCong : Form
    {
        QLNSDataContext context = new QLNSDataContext();
        bool xuLyThem = false;
        int id;
        bool daLoad = false;
        public ChamCong()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ChamCong_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            cbNhanVien.DataSource = context.NhanVien.ToList();
            cbNhanVien.DisplayMember = "HoTen";
            cbNhanVien.ValueMember = "ID";

            daLoad = true;

            LoadChamCong();
        }
        void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnLamMoi.Enabled = giaTri;

            cbNhanVien.Enabled = giaTri;
            dtpNgay.Enabled = giaTri;
            cbTrangThai.Enabled = giaTri;
            numTangCa.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        void LoadChamCong()
        {
            if (!daLoad) return;
            if (cbNhanVien.SelectedValue == null) return;

            int idNhanVien = Convert.ToInt32(cbNhanVien.SelectedValue);

            int thang = dtpThang.Value.Month;
            int nam = dtpThang.Value.Year;

            var data = context.ChamCong
                .Where(x => x.NhanVienID == idNhanVien
                    && x.Ngay.Month == thang
                    && x.Ngay.Year == nam)
                .Select(x => new
                {
                    x.ID,
                    TenNhanVien = x.NhanVien.HoTen,
                    x.Ngay,
                    x.TrangThai,
                    x.GioTangCa
                }).ToList();

            dgvChamCong.DataSource = data;

            dgvChamCong.Columns["Ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";

            TinhThongKe();
        }

        void TinhThongKe()
        {
            if (cbNhanVien.SelectedValue == null) return;

            int idNhanVien = Convert.ToInt32(cbNhanVien.SelectedValue);

            int thang = dtpThang.Value.Month;
            int nam = dtpThang.Value.Year;

            int ngayCong = context.ChamCong
                .Where(x => x.NhanVienID == idNhanVien
                    && x.Ngay.Month == thang
                    && x.Ngay.Year == nam
                    && x.TrangThai == "đã chấm công")
                .Count();

            int tongTangCa = context.ChamCong
                .Where(x => x.NhanVienID == idNhanVien
                    && x.Ngay.Month == thang
                    && x.Ngay.Year == nam)
                .Sum(x => (int?)x.GioTangCa) ?? 0;

            lblNgayCongMacDinh.Text = "26";
            lblNgayCongThucTe.Text = ngayCong.ToString();
            lblTongTangCa.Text = tongTangCa.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            cbTrangThai.Text = "";
            numTangCa.Value = 0;
        }

        private void btnXóa_Click(object sender, EventArgs e)
        {
            if (dgvChamCong.CurrentRow == null) return;

            if (MessageBox.Show("Xác nhận xóa?",
                 "Xóa",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvChamCong.CurrentRow.Cells["ID"].Value);

                Data.ChamCong cc = context.ChamCong.Find(id);

                if (cc != null)
                {
                    context.ChamCong.Remove(cc);
                    context.SaveChanges();
                }

                LoadChamCong();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvChamCong.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dgvChamCong.CurrentRow.Cells["ID"].Value);
        }

        private void dgvChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            cbNhanVien.Text = dgvChamCong.Rows[e.RowIndex].Cells["TenNhanVien"].Value.ToString();

            dtpNgay.Value = Convert.ToDateTime(
                dgvChamCong.Rows[e.RowIndex].Cells["Ngay"].Value);

            cbTrangThai.Text =
                dgvChamCong.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();

            numTangCa.Value = Convert.ToInt32(
                dgvChamCong.Rows[e.RowIndex].Cells["GioTangCa"].Value);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            // reset các ô nhập
            cbNhanVien.SelectedIndex = -1;
            cbTrangThai.SelectedIndex = -1;
            dtpNgay.Value = DateTime.Now;
            numTangCa.Value = 0;

            // reset thống kê
            lblNgayCongMacDinh.Text = "26";
            lblNgayCongThucTe.Text = "0";
            lblTongTangCa.Text = "0";

            // load toàn bộ dữ liệu
            LoadTatCaChamCong();
        }
        void LoadTatCaChamCong()
        {
            var data = context.ChamCong
                .Select(x => new
                {
                    x.ID,
                    TenNhanVien = x.NhanVien.HoTen,
                    x.Ngay,
                    x.TrangThai,
                    x.GioTangCa
                }).ToList();

            dgvChamCong.DataSource = data;

            dgvChamCong.Columns["Ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
                return;
            }

            int idNhanVien = Convert.ToInt32(cbNhanVien.SelectedValue);

            if (xuLyThem)
            {
                bool tonTai = context.ChamCong.Any(x =>
                    x.NhanVienID == idNhanVien &&
                    x.Ngay.Date == dtpNgay.Value.Date);

                if (tonTai)
                {
                    MessageBox.Show("Nhân viên đã được chấm công ngày này!");
                    return;
                }

                Data.ChamCong cc = new Data.ChamCong();

                cc.NhanVienID = idNhanVien;
                cc.Ngay = dtpNgay.Value;
                cc.TrangThai = cbTrangThai.Text;
                cc.GioTangCa = (int)numTangCa.Value;

                context.ChamCong.Add(cc);
                context.SaveChanges();
            }
            else
            {
                Data.ChamCong cc = context.ChamCong.Find(id);

                if (cc != null)
                {
                    cc.NhanVienID = idNhanVien;
                    cc.Ngay = dtpNgay.Value;
                    cc.TrangThai = cbTrangThai.Text;
                    cc.GioTangCa = (int)numTangCa.Value;

                    context.SaveChanges();
                }
            }

            LoadChamCong();
            BatTatChucNang(false);
        }

        private void cbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!daLoad) return;
            LoadChamCong();
        }

        private void dtpThang_ValueChanged(object sender, EventArgs e)
        {
            if (!daLoad) return;
            LoadChamCong();
        }
    }
}
