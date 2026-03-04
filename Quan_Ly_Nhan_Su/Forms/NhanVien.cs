using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Nhan_Su.Forms
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            StyleGrid();
        }

        private void StyleGrid()
        {
            dgvNhanVien.BorderStyle = BorderStyle.None;
            dgvNhanVien.EnableHeadersVisualStyles = false;

            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvNhanVien.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvNhanVien.DefaultCellStyle.SelectionBackColor =
                Color.LightGray;

            dgvNhanVien.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
