using Quan_Ly_Nhan_Su.Reports;
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
    public partial class BaoCao_ThongKe : Form
    {
        #region === CONSTRUCTOR ===
        public BaoCao_ThongKe()
        {
            InitializeComponent();
            // Đăng ký sự kiện SelectedIndexChanged bằng code
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);

            // Gọi nạp Tab đầu tiên ngay khi vừa mở Form
            this.Load += (s, e) => tabControlMain_SelectedIndexChanged(null, null);
            // 1. QUAN TRỌNG: Phải đổi chế độ vẽ sang OwnerDrawFixed thì hàm DrawItem mới chạy
            this.tabControlMain.DrawMode = TabDrawMode.OwnerDrawFixed;

            // 2. Đăng ký hàm DrawItem mà bạn đã viết
            this.tabControlMain.DrawItem += new DrawItemEventHandler(tabControlMain_DrawItem);
        }
        #endregion
        #region === TAB CONTROL CHANGE (ĐIỀU HƯỚNG) ===
        // Hàm nhúng Form vào Panel
        // Hàm dùng chung để nhúng Form vào Panel
        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem tabControlMain có bị NULL không để tránh lỗi
            if (tabControlMain == null) return;

            switch (tabControlMain.SelectedIndex)
            {
                case 0:
                    fromThongKeNhanVien frmNV = new fromThongKeNhanVien();
                    MoFormConToiUu(pnlThongKeNV, frmNV);
                    break;
                case 1:
                    fromThongKeDuAn frmDA = new fromThongKeDuAn();
                    MoFormConToiUu(pnlThongKeDA, frmDA);
                    break;
                case 2:
                    fromHoSoNhanVien frmHS = new fromHoSoNhanVien();
                    MoFormConToiUu(pnlInHoSo, frmHS);
                    break;
            }
        }
        #endregion
        #region === NHÚNG FORM CON (HOST FORM) ===
        private void MoFormConToiUu(Panel pnl, Form frmMoi)
        {
            // Kiểm tra nếu form đã tồn tại trong panel thì chỉ load lại dữ liệu
            if (pnl.Controls.Count > 0 && pnl.Controls[0].GetType() == frmMoi.GetType())
            {
                try
                {
                    var frmHienTai = (dynamic)pnl.Controls[0];
                    frmHienTai.LoadReportData();
                }
                catch
                {
                    // Bỏ qua nếu form đó thực sự không có hàm LoadReportData
                }
                return;
            }

            // Nếu chưa có thì nhúng mới
            pnl.Controls.Clear();
            frmMoi.TopLevel = false;
            frmMoi.FormBorderStyle = FormBorderStyle.None;
            frmMoi.Dock = DockStyle.Fill;
            pnl.Controls.Add(frmMoi);
            frmMoi.Show();

            // Gọi nạp dữ liệu lần đầu sau khi hiển thị
            try
            {
                ((dynamic)frmMoi).LoadReportData();
            }
            catch { }
        }
        #endregion
        #region === CUSTOM TAB UI (DRAW TAB) ===
        private void tabControlMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            TabPage tabPage = tabControlMain.TabPages[e.Index];
            Rectangle tabRect = tabControlMain.GetTabRect(e.Index);
            bool isSelected = (e.Index == tabControlMain.SelectedIndex);

            g.FillRectangle(new SolidBrush(Color.White), tabRect);
            Color textColor = isSelected ? Color.Teal : Color.Gray;

            TextRenderer.DrawText(g, tabPage.Text, new Font("Segoe UI", 10, FontStyle.Bold),
                tabRect, textColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            if (isSelected)
            {
                Pen pen = new Pen(Color.Teal, 3);
                g.DrawLine(pen, tabRect.Left + 10, tabRect.Bottom - 2, tabRect.Right - 10, tabRect.Bottom - 2);
            }
        }
        #endregion
    }
}
