using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QrCode.Migrations
{
    /// <inheritdoc />
    public partial class Pengunjung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pengunjung",
                table: "Pengunjung");

            migrationBuilder.DropColumn(
                name: "PengunjungId",
                table: "Pengunjung");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pengunjung",
                table: "Pengunjung",
                column: "KodeUnik");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pengunjung",
                table: "Pengunjung");

            migrationBuilder.AddColumn<int>(
                name: "PengunjungId",
                table: "Pengunjung",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pengunjung",
                table: "Pengunjung",
                column: "PengunjungId");
        }
    }
}
