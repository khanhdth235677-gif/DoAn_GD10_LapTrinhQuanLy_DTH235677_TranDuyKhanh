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
        public DbSet<PhongBan> PhongBan { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Quan hệ Phòng ban - Nhân viên
            modelBuilder.Entity<NhanVien>()
                .HasOne(nv => nv.PhongBan)
                .WithMany(pb => pb.NhanVien)
                .HasForeignKey(nv => nv.PhongBanID)
                .OnDelete(DeleteBehavior.Restrict);

            // Quan hệ Nhân viên - Chấm công
            modelBuilder.Entity<ChamCong>()
                .HasOne(cc => cc.NhanVien)
                .WithMany(nv => nv.ChamCong)
                .HasForeignKey(cc => cc.NhanVienID);

            // Quan hệ Nhân viên - Bảng lương
            modelBuilder.Entity<BangLuong>()
                .HasOne(bl => bl.NhanVien)
                .WithMany(nv => nv.BangLuong)
                .HasForeignKey(bl => bl.NhanVienID);

            // Quan hệ Nhân viên - Nghỉ phép
            modelBuilder.Entity<NghiPhep>()
                .HasOne(np => np.NhanVien)
                .WithMany(nv => nv.NghiPhep)
                .HasForeignKey(np => np.NhanVienID);

            // Quan hệ Phân công dự án
            modelBuilder.Entity<PhanCongDuAn>()
                .HasOne(p => p.NhanVien)
                .WithMany(n => n.PhanCongDuAn)
                .HasForeignKey(p => p.NhanVienID)
                .OnDelete(DeleteBehavior.Restrict);   

            modelBuilder.Entity<PhanCongDuAn>()
                .HasOne(p => p.DuAn)
                .WithMany(d => d.PhanCongDuAn)
                .HasForeignKey(p => p.DuAnID)
                .OnDelete(DeleteBehavior.Cascade);
            // Quan hệ 1-1 Nhân viên - Tài khoản
            modelBuilder.Entity<TaiKhoan>()
                .HasOne(tk => tk.NhanVien)
                .WithOne(nv => nv.TaiKhoan)
                .HasForeignKey<TaiKhoan>(tk => tk.NhanVienID);
        }
    }
}
