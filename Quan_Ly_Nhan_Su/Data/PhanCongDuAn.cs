using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Nhan_Su.Data
{
    public class PhanCongDuAn
    {
        public int ID { get; set; }

        // Nhân viên được phân công
        public int NhanVienID { get; set; }
        public virtual NhanVien NhanVien { get; set; } = null!;

        // Dự án được phân công vào
        public int DuAnID { get; set; }
        public virtual DuAn DuAn { get; set; } = null!;

        // Vai trò trong dự án
        public string? VaiTro { get; set; }               // Ví dụ: "Developer", "Tester", "Designer", "PM"

        // Giá trị đóng góp (có thể là % công sức, hoặc số tiền lương/thưởng dự kiến)
        public decimal? GiaTri { get; set; }

        // Thời gian tham gia dự án
        public DateTime? NgayThamGia { get; set; }
        public DateTime? NgayKetThuc { get; set; }        // ngày rời dự án (nếu có)

        // Trạng thái phân công
        public string? TrangThai { get; set; }            // "Đang tham gia", "Đã hoàn thành", "Tạm nghỉ",...

        // Ghi chú riêng cho phân công này
        public string? GhiChu { get; set; }
    }
}
