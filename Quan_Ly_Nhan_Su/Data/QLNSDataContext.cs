using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Quan_Ly_Nhan_Su.Data;

namespace Quan_Ly_Nhan_Su.Data
{
    public class QLNSDataContext : DbContext
    {
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<PhongBan> PhongBan { get; set; }
        public DbSet<ChamCong> ChamCong { get; set; }
        public DbSet<BangLuong> BangLuong { get; set; }
        public DbSet<NghiPhep> NghiPhep { get; set; }
        public DbSet<DuAn> DuAn { get; set; }
        public DbSet<PhanCongDuAn> PhanCongDuAn { get; set; }
        public DbSet<TaiKhoan> TaiKhoan { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                ConfigurationManager.ConnectionStrings["QLNSConnection"].ConnectionString
            );
        }
    }
}
