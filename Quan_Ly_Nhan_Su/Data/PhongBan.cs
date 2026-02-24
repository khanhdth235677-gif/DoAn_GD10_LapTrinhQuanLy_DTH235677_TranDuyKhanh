using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Nhan_Su.Data
{
    public class PhongBan
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string TenPhongBan { get; set; } = string.Empty;

        public string? MoTa { get; set; }

        // Navigation
        public virtual ICollection<NhanVien> NhanVien { get; set; } = new List<NhanVien>();
    }
}
