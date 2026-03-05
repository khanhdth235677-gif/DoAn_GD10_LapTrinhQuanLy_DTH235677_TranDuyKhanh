using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Nhan_Su.Data
{
    public class ChamCong
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public DateTime Ngay { get; set; }
        public string? TrangThai { get; set; }

        public int GioTangCa { get; set; }   // số giờ tăng ca

        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}
