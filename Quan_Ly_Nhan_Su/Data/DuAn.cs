using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Nhan_Su.Data
{
    public class DuAn
    {
        public int ID { get; set; }

        // Mã dự án duy nhất (ví dụ: DA001, DA2025-001, ...)
        public string? MaDuAn { get; set; }

        // Tên dự án đầy đủ
        public string? TenDuAn { get; set; }

        // Mô tả ngắn gọn hoặc chi tiết dự án
        public string? MoTa { get; set; }

        // Khách hàng / Đối tác
        public string? KhachHang { get; set; }

        // Phòng ban chủ quản dự án
        public int? PhongBanID { get; set; }
        public virtual PhongBan? PhongBan { get; set; }

        // Người quản lý dự án (Project Manager)
        public int? NguoiQuanLyID { get; set; }           // FK -> NhanVien
        public virtual NhanVien? NguoiQuanLy { get; set; }

        // Thời gian
        public DateTime? NgayBatDau { get; set; }         // sửa tên thống nhất, bỏ trùng lặp
        public DateTime? NgayKetThucDuKien { get; set; }
        public DateTime? NgayKetThucThucTe { get; set; }  // để theo dõi dự án trễ hạn

        // Giá trị hợp đồng / ngân sách
        public decimal? GiaTriHopDong { get; set; }

        // Tình trạng dự án
        public string? TinhTrang { get; set; }            // Ví dụ: "Đang thực hiện", "Hoàn thành", "Tạm dừng", "Hủy"

        // Tiến độ (tùy chọn - % hoàn thành)
        public int? TienDo { get; set; }                  // 0-100

        // Ghi chú chung
        public string? GhiChu { get; set; }

        // Navigation property: danh sách nhân viên tham gia dự án
        public virtual ICollection<PhanCongDuAn> PhanCongDuAn { get; set; } = new List<PhanCongDuAn>();
    }
}