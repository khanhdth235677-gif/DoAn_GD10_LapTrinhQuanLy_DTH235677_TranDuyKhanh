using Microsoft.EntityFrameworkCore.ChangeTracking;
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

        public int PhongBanID { get; set; }

        public string? HoTen { get; set; }

        public DateTime NgaySinh { get; set; }

        public string? GioiTinh { get; set; }
        public string? DanToc { get; set; }
        public string? CCCD { get; set; }
        public string? NoiCap { get; set; }
        public string? DienThoai { get; set; }

        public string? DiaChi { get; set; }

        public string? Email { get; set; }

        public string? ChucVu { get; set; }
        public string? HinhAnh { get; set; }

        public DateTime NgayVaoLam { get; set; }

        public string TrangThai { get; set; } = "Đang làm";

        // Navigation property
        public virtual PhongBan? PhongBan { get; set; }

        public virtual ICollection<ChamCong> ChamCong { get; set; } = new List<ChamCong>();

        public virtual ICollection<BangLuong> BangLuong { get; set; } = new List<BangLuong>();

        public virtual ICollection<NghiPhep> NghiPhep { get; set; } = new List<NghiPhep>();

        public virtual ICollection<PhanCongDuAn> PhanCongDuAn { get; set; } = new List<PhanCongDuAn>();
    }
    [NotMapped]
    public class DanhSachNhanVien
    {
        public int ID { get; set; }               
        public int NhanVienID { get; set; }      
        public string MaNV { get; set; } = "";    
        public string? HoTen { get; set; }
        public int PhongBanID { get; set; }
        public string? TenPhongBan { get; set; }
        public int DuAnID { get; set; }
        public string? TenDuAn { get; set; }
        public int GiaTri { get; set; }
        public string? VaiTro { get; set; }
        public string? HinhAnh { get; set; }
    }
}
