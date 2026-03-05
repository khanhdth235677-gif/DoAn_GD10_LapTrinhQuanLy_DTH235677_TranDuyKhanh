using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quan_Ly_Nhan_Su.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDuAnAndPhanCong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NgayKetThuc",
                table: "DuAn");

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaTri",
                table: "PhanCongDuAn",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "GhiChu",
                table: "PhanCongDuAn",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayKetThuc",
                table: "PhanCongDuAn",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayThamGia",
                table: "PhanCongDuAn",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrangThai",
                table: "PhanCongDuAn",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayBatDau",
                table: "DuAn",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "GhiChu",
                table: "DuAn",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "GiaTriHopDong",
                table: "DuAn",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KhachHang",
                table: "DuAn",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaDuAn",
                table: "DuAn",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MoTa",
                table: "DuAn",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayKetThucDuKien",
                table: "DuAn",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayKetThucThucTe",
                table: "DuAn",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NguoiQuanLyID",
                table: "DuAn",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhongBanID",
                table: "DuAn",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TienDo",
                table: "DuAn",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TinhTrang",
                table: "DuAn",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DuAn_NguoiQuanLyID",
                table: "DuAn",
                column: "NguoiQuanLyID");

            migrationBuilder.CreateIndex(
                name: "IX_DuAn_PhongBanID",
                table: "DuAn",
                column: "PhongBanID");

            migrationBuilder.AddForeignKey(
                name: "FK_DuAn_NhanVien_NguoiQuanLyID",
                table: "DuAn",
                column: "NguoiQuanLyID",
                principalTable: "NhanVien",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DuAn_PhongBan_PhongBanID",
                table: "DuAn",
                column: "PhongBanID",
                principalTable: "PhongBan",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DuAn_NhanVien_NguoiQuanLyID",
                table: "DuAn");

            migrationBuilder.DropForeignKey(
                name: "FK_DuAn_PhongBan_PhongBanID",
                table: "DuAn");

            migrationBuilder.DropIndex(
                name: "IX_DuAn_NguoiQuanLyID",
                table: "DuAn");

            migrationBuilder.DropIndex(
                name: "IX_DuAn_PhongBanID",
                table: "DuAn");

            migrationBuilder.DropColumn(
                name: "GhiChu",
                table: "PhanCongDuAn");

            migrationBuilder.DropColumn(
                name: "NgayKetThuc",
                table: "PhanCongDuAn");

            migrationBuilder.DropColumn(
                name: "NgayThamGia",
                table: "PhanCongDuAn");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "PhanCongDuAn");

            migrationBuilder.DropColumn(
                name: "GhiChu",
                table: "DuAn");

            migrationBuilder.DropColumn(
                name: "GiaTriHopDong",
                table: "DuAn");

            migrationBuilder.DropColumn(
                name: "KhachHang",
                table: "DuAn");

            migrationBuilder.DropColumn(
                name: "MaDuAn",
                table: "DuAn");

            migrationBuilder.DropColumn(
                name: "MoTa",
                table: "DuAn");

            migrationBuilder.DropColumn(
                name: "NgayKetThucDuKien",
                table: "DuAn");

            migrationBuilder.DropColumn(
                name: "NgayKetThucThucTe",
                table: "DuAn");

            migrationBuilder.DropColumn(
                name: "NguoiQuanLyID",
                table: "DuAn");

            migrationBuilder.DropColumn(
                name: "PhongBanID",
                table: "DuAn");

            migrationBuilder.DropColumn(
                name: "TienDo",
                table: "DuAn");

            migrationBuilder.DropColumn(
                name: "TinhTrang",
                table: "DuAn");

            migrationBuilder.AlterColumn<int>(
                name: "GiaTri",
                table: "PhanCongDuAn",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayBatDau",
                table: "DuAn",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayKetThuc",
                table: "DuAn",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
