using DocumentFormat.OpenXml.InkML;
using Quan_Ly_Nhan_Su.Data;
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
using System.Drawing.Drawing2D;
using System.Data.SqlClient;

namespace Quan_Ly_Nhan_Su.Forms
{
    public partial class TrangChuHome : Form
    {
        #region Khởi tạo & DataContext
        QLNSDataContext context = new QLNSDataContext();
        public TrangChuHome()
        {
            InitializeComponent();
        }
        #endregion
        #region HÀM LOAD DỮ LIỆU DASHBOARD
        // ================== HÀM LOAD DỮ LIỆU TỪ CSDL ==================
        private void LoadDuLieuDashboard()
        {
            try
            {
                #region 1. Tổng số nhân viên
                int tongNV = context.NhanVien.Count();
                lblTongNhanVien.Text = tongNV.ToString("N0");
                #endregion
                #region 2. Tổng số dự án
                int tongDA = context.DuAn.Count();
                lblTongDuAn.Text = tongDA.ToString("N0");
                #endregion
                #region 3. Top 5 nhân viên lương cao nhất
                var top5NhanVien = (from nv in context.NhanVien // (hoặc context.NhanVien tùy cách bạn đặt tên)
                                    join bl in context.BangLuong on nv.ID equals bl.NhanVienID
                                    orderby bl.TongLuong descending // Sắp xếp giảm dần theo cột Tổng Lương ở bảng lương
                                    select new
                                    {
                                        ID = nv.ID,
                                        HoTen = nv.HoTen,
                                        TenPhongBan = nv.PhongBan.TenPhongBan,
                                        TongLuong = bl.TongLuong // Lấy Tổng lương từ bảng bl (BangLuong)
                                    }).Take(5).ToList();

                // Đổ dữ liệu vào bảng
                dgvTopNhanVien.DataSource = top5NhanVien;
                // Bỏ bôi đen dòng đầu
                dgvTopNhanVien.ClearSelection();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Sự kiện Load Form
        private void TrangChuHome_Load_1(object sender, EventArgs e)
        {
            LoadDuLieuDashboard();
        }
        #endregion
    }
}
