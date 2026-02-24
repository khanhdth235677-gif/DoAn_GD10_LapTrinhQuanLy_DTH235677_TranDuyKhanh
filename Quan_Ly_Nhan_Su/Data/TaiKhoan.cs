using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Nhan_Su.Data
{
    public class TaiKhoan
    {
        public int ID { get; set; }

        public string TenDangNhap { get; set; } = string.Empty;
        public string MatKhau { get; set; } = string.Empty;

        public bool LaQuanTri { get; set; }

        public int NhanVienID { get; set; }

        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}
