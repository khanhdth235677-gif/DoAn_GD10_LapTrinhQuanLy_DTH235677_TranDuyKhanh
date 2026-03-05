using Microsoft.EntityFrameworkCore.ChangeTracking;
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
        public string? TenPhongBan { get; set; }
        public string? MoTa { get; set; }

        public virtual ObservableCollectionListSource<NhanVien> NhanVien { get; } = new();
    }
}
