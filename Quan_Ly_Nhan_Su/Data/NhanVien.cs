using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Nhan_Su.Data
{
    public class NhanVien
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string HoVaTen { get; set; } = string.Empty;

        [StringLength(20)]
        public string? DienThoai { get; set; }

        public string? DiaChi { get; set; }

        public DateTime NgaySinh { get; set; }

        public DateTime NgayVaoLam { get; set; }

        public decimal LuongCoBan { get; set; }

        // ====== Khóa ngoại ======
        public int PhongBanID { get; set; }

        [ForeignKey("PhongBanID")]
        public virtual PhongBan PhongBan { get; set; } = null!;

        public virtual TaiKhoan? TaiKhoan { get; set; }

        // ====== Navigation ======
        public virtual ICollection<ChamCong> ChamCong { get; set; } = new List<ChamCong>();
        public virtual ICollection<BangLuong> BangLuong { get; set; } = new List<BangLuong>();
        public virtual ICollection<NghiPhep> NghiPhep { get; set; } = new List<NghiPhep>();
        public virtual ICollection<PhanCongDuAn> PhanCongDuAn { get; set; } = new List<PhanCongDuAn>();
    }
}
