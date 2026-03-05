using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quan_Ly_Nhan_Su.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DuAn_NhanVien_NhanVienID",
                table: "DuAn");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_PhongBan_PhongBanID",
                table: "NhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_PhanCongDuAn_NhanVien_NhanVienID",
                table: "PhanCongDuAn");

            migrationBuilder.DropForeignKey(
                name: "FK_TaiKhoan_NhanVien_NhanVienID",
                table: "TaiKhoan");

            migrationBuilder.DropIndex(
                name: "IX_TaiKhoan_NhanVienID",
                table: "TaiKhoan");

            migrationBuilder.DropIndex(
                name: "IX_DuAn_NhanVienID",
                table: "DuAn");

            migrationBuilder.DropColumn(
                name: "LaQuanTri",
                table: "TaiKhoan");

            migrationBuilder.DropColumn(
                name: "NhanVienID",
                table: "TaiKhoan");

            migrationBuilder.DropColumn(
                name: "HoVaTen",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "LuongCoBan",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "NgayVaoLam",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "DaDuyet",
                table: "NghiPhep");

            migrationBuilder.DropColumn(
                name: "DaDuyet",
                table: "DuAn");

            migrationBuilder.DropColumn(
                name: "NhanVienID",
                table: "DuAn");

            migrationBuilder.DropColumn(
                name: "GioRa",
                table: "ChamCong");

            migrationBuilder.DropColumn(
                name: "GioVao",
                table: "ChamCong");

            migrationBuilder.RenameColumn(
                name: "TuNgay",
                table: "DuAn",
                newName: "NgayKetThuc");

            migrationBuilder.RenameColumn(
                name: "LyDo",
                table: "DuAn",
                newName: "TenDuAn");

            migrationBuilder.RenameColumn(
                name: "DenNgay",
                table: "DuAn",
                newName: "NgayBatDau");

            migrationBuilder.RenameColumn(
                name: "PhuCap",
                table: "BangLuong",
                newName: "LuongCoBan");

            migrationBuilder.AddColumn<string>(
                name: "Quyen",
                table: "TaiKhoan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TenPhongBan",
                table: "PhongBan",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "DienThoai",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GioiTinh",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HoTen",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TrangThai",
                table: "NghiPhep",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TrangThai",
                table: "ChamCong",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_PhongBan_PhongBanID",
                table: "NhanVien",
                column: "PhongBanID",
                principalTable: "PhongBan",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhanCongDuAn_NhanVien_NhanVienID",
                table: "PhanCongDuAn",
                column: "NhanVienID",
                principalTable: "NhanVien",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_PhongBan_PhongBanID",
                table: "NhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_PhanCongDuAn_NhanVien_NhanVienID",
                table: "PhanCongDuAn");

            migrationBuilder.DropColumn(
                name: "Quyen",
                table: "TaiKhoan");

            migrationBuilder.DropColumn(
                name: "GioiTinh",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "HoTen",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "NghiPhep");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "ChamCong");

            migrationBuilder.RenameColumn(
                name: "TenDuAn",
                table: "DuAn",
                newName: "LyDo");

            migrationBuilder.RenameColumn(
                name: "NgayKetThuc",
                table: "DuAn",
                newName: "TuNgay");

            migrationBuilder.RenameColumn(
                name: "NgayBatDau",
                table: "DuAn",
                newName: "DenNgay");

            migrationBuilder.RenameColumn(
                name: "LuongCoBan",
                table: "BangLuong",
                newName: "PhuCap");

            migrationBuilder.AddColumn<bool>(
                name: "LaQuanTri",
                table: "TaiKhoan",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "NhanVienID",
                table: "TaiKhoan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "TenPhongBan",
                table: "PhongBan",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DienThoai",
                table: "NhanVien",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HoVaTen",
                table: "NhanVien",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "LuongCoBan",
                table: "NhanVien",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayVaoLam",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "DaDuyet",
                table: "NghiPhep",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DaDuyet",
                table: "DuAn",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "NhanVienID",
                table: "DuAn",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "GioRa",
                table: "ChamCong",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "GioVao",
                table: "ChamCong",
                type: "time",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_NhanVienID",
                table: "TaiKhoan",
                column: "NhanVienID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DuAn_NhanVienID",
                table: "DuAn",
                column: "NhanVienID");

            migrationBuilder.AddForeignKey(
                name: "FK_DuAn_NhanVien_NhanVienID",
                table: "DuAn",
                column: "NhanVienID",
                principalTable: "NhanVien",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_PhongBan_PhongBanID",
                table: "NhanVien",
                column: "PhongBanID",
                principalTable: "PhongBan",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhanCongDuAn_NhanVien_NhanVienID",
                table: "PhanCongDuAn",
                column: "NhanVienID",
                principalTable: "NhanVien",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TaiKhoan_NhanVien_NhanVienID",
                table: "TaiKhoan",
                column: "NhanVienID",
                principalTable: "NhanVien",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
