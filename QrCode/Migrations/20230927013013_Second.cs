using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QrCode.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Pengunjung",
                newName: "IdPengunjung");

            migrationBuilder.CreateTable(
                name: "Stasiun",
                columns: table => new
                {
                    IdStasiun = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaStasiun = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stasiun", x => x.IdStasiun);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stasiun");

            migrationBuilder.RenameColumn(
                name: "IdPengunjung",
                table: "Pengunjung",
                newName: "MyProperty");
        }
    }
}
