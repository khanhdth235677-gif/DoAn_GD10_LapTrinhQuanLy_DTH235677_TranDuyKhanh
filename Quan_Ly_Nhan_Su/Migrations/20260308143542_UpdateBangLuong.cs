using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quan_Ly_Nhan_Su.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBangLuong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nam",
                table: "BangLuong");

            migrationBuilder.DropColumn(
                name: "Thang",
                table: "BangLuong");

            migrationBuilder.AddColumn<decimal>(
                name: "PhuCap",
                table: "BangLuong",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "ThangNam",
                table: "BangLuong",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhuCap",
                table: "BangLuong");

            migrationBuilder.DropColumn(
                name: "ThangNam",
                table: "BangLuong");

            migrationBuilder.AddColumn<int>(
                name: "Nam",
                table: "BangLuong",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Thang",
                table: "BangLuong",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
