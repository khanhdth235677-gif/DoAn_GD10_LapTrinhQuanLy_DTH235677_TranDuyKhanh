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

        public TimeSpan? GioVao { get; set; }
        public TimeSpan? GioRa { get; set; }

        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}
