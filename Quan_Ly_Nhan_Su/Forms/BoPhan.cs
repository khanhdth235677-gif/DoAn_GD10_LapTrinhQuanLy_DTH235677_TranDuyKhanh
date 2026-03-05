using Quan_Ly_Nhan_Su.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Quan_Ly_Nhan_Su.Forms
{
    public partial class BoPhan : Form
    {
        QLNSDataContext context = new QLNSDataContext();
        int id = 0;
        bool xuLyThem = false;
        public BoPhan()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        void LoadBoPhan()
        {
            dgvBoPhan.AutoGenerateColumns = false;

            var ds = from pb in context.PhongBan
                     select new
                     {
                         pb.ID,
                         pb.TenPhongBan,
                         HoTen = string.Join(", ",
                                context.NhanVien
                                .Where(nv => nv.PhongBanID == pb.ID)
                                .Select(nv => nv.HoTen)),
                         pb.MoTa
                     };

            dgvBoPhan.DataSource = ds.ToList();
        }

        void LoadComboBoPhan()
        {
            cbTenPhongBan.DataSource = context.PhongBan.ToList();
            cbTenPhongBan.DisplayMember = "TenPhongBan";
            cbTenPhongBan.ValueMember = "ID";
            cbTenPhongBan.SelectedIndex = -1;
        }

        void ResetForm()
        {
            txtID.Clear();
            txtMoTa.Clear();
            txtHoTenNV.Clear();
            cbTenPhongBan.SelectedIndex = -1;
            dgvBoPhan.ClearSelection();
            id = 0;
        }
        private void BoPhan_Load(object sender, EventArgs e)
        {
            LoadBoPhan();
            LoadComboBoPhan();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbTenPhongBan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên bộ phận");
                return;
            }

            PhongBan pb = new PhongBan();
            pb.TenPhongBan = cbTenPhongBan.Text;
            pb.MoTa = txtMoTa.Text;

            context.PhongBan.Add(pb);
            context.SaveChanges();

            LoadBoPhan();
            LoadComboBoPhan();
            ResetForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Vui lòng chọn bộ phận cần xóa");
                return;
            }

            var pb = context.PhongBan.Find(id);

            if (pb != null)
            {
                var nhanViens = context.NhanVien
                    .Where(nv => nv.PhongBanID == id)
                    .ToList();

                context.NhanVien.RemoveRange(nhanViens);
                context.PhongBan.Remove(pb);
                context.SaveChanges();
            }

            LoadBoPhan();
            ResetForm();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadBoPhan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Vui lòng chọn bộ phận cần sửa");
                return;
            }

            var pb = context.PhongBan.Find(id);

            if (pb != null)
            {
                pb.TenPhongBan = cbTenPhongBan.Text;
                pb.MoTa = txtMoTa.Text;

                context.SaveChanges();
            }

            LoadBoPhan();
            ResetForm();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenPB = cbTenPhongBan.Text.Trim();

            var ds = from pb in context.PhongBan
                     where pb.TenPhongBan.Contains(tenPB)
                     select new
                     {
                         pb.ID,
                         pb.TenPhongBan,
                         HoTen = string.Join(", ",
                                context.NhanVien
                                .Where(nv => nv.PhongBanID == pb.ID)
                                .Select(nv => nv.HoTen)),
                         pb.MoTa
                     };

            dgvBoPhan.DataSource = ds.ToList();
        }

        private void dgvBoPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBoPhan.Rows[e.RowIndex];

                id = Convert.ToInt32(row.Cells["ID"].Value);

                txtID.Text = row.Cells["ID"].Value.ToString();
                cbTenPhongBan.Text = row.Cells["TenPhongBan"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();
                txtHoTenNV.Text = row.Cells["HoTen"].Value?.ToString();
            }
        }
    }
}
