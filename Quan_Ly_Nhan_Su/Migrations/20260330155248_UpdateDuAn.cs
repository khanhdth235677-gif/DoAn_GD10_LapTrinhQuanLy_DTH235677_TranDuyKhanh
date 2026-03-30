using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quan_Ly_Nhan_Su.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDuAn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TenNhanVienQL",
                table: "DuAn",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenNhanVienQL",
                table: "DuAn");
        }
    }
}
