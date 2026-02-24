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

        public int NhanVienID { get; set; }
        public int DuAnID { get; set; }

        public string VaiTro { get; set; } = string.Empty;

        public virtual NhanVien NhanVien { get; set; } = null!;
        public virtual DuAn DuAn { get; set; } = null!;
    }
}
