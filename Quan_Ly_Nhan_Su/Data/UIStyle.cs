using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Nhan_Su.Data
{
    public static class UIStyle
    {
        // Màu sắc chuyên nghiệp
        public static Color PrimaryColor = Color.FromArgb(0, 128, 128); // Xanh Teal
        public static Color AccentColor = Color.FromArgb(52, 152, 219); // Xanh Dương
        public static Color GridColor = Color.FromArgb(221, 221, 221);
        public static Color TextColor = Color.FromArgb(51, 51, 51);
        public static Color SecondaryButtonColor = Color.FromArgb(189, 195, 199); // Xám

        public static void ApplyStyle(Form form)
        {
            // 1. Cài đặt cho Form
            form.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            form.BackColor = Color.White;
            form.Padding = new Padding(15);

            foreach (Control c in form.Controls)
            {
                ApplyStyleToControl(c);
            }
        }

        private static void ApplyStyleToControl(Control c)
        {
            // 2. Định dạng Nút bấm
            if (c is Button btn)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Height = 35;
                btn.Cursor = Cursors.Hand;
                btn.ForeColor = Color.White;
                btn.Margin = new Padding(0, 5, 0, 5);

                // Phân loại màu nút
                if (btn.Text.Contains("Lưu") || btn.Text.Contains("Thêm")) btn.BackColor = AccentColor;
                else if (btn.Text.Contains("Xóa")) btn.BackColor = Color.FromArgb(231, 76, 60); // Màu Đỏ
                else btn.BackColor = SecondaryButtonColor; // Các nút khác màu xám
            }

            // 3. Định dạng DataGridView
            if (c is DataGridView dgv)
            {
                dgv.EnableHeadersVisualStyles = false;
                dgv.BackgroundColor = Color.White;
                dgv.BorderStyle = BorderStyle.None;
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgv.GridColor = GridColor;

                // Header
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = PrimaryColor;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                dgv.ColumnHeadersHeight = 40;

                // Dữ liệu
                dgv.RowTemplate.Height = 35;
                dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(214, 234, 248); // Xanh nhạt khi chọn
                dgv.DefaultCellStyle.SelectionForeColor = TextColor;
                dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            // 4. Định dạng ô nhập liệu
            if (c is TextBox || c is ComboBox || c is DateTimePicker)
            {
                c.Height = 30; // Chú ý: TextBox cần Multiline=true mới set chiều cao được
            }

            // Đệ quy cho các control bên trong
            if (c.HasChildren)
            {
                foreach (Control child in c.Controls)
                {
                    ApplyStyleToControl(child);
                }
            }
        }
    }
}
