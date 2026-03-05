using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Nhan_Su.Data
{
    public class NghiPhep
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public string? LyDo { get; set; }
        public string? TrangThai { get; set; }

        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}
