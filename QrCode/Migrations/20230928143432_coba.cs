using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QrCode.Migrations
{
    /// <inheritdoc />
    public partial class coba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stasiun");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pengunjung",
                table: "Pengunjung");

            migrationBuilder.DropColumn(
                name: "KodeUnik",
                table: "Pengunjung");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Pengunjung",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pengunjung",
                table: "Pengunjung",
                column: "Guid");

            migrationBuilder.CreateTable(
                name: "Checkpoints",
                columns: table => new
                {
                    IdCheckpoint = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PengunjungGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkpoints", x => x.IdCheckpoint);
                    table.ForeignKey(
                        name: "FK_Checkpoints_Pengunjung_PengunjungGuid",
                        column: x => x.PengunjungGuid,
                        principalTable: "Pengunjung",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Checkpoints_PengunjungGuid",
                table: "Checkpoints",
                column: "PengunjungGuid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checkpoints");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pengunjung",
                table: "Pengunjung");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Pengunjung");

            migrationBuilder.AddColumn<string>(
                name: "KodeUnik",
                table: "Pengunjung",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pengunjung",
                table: "Pengunjung",
                column: "KodeUnik");

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
    }
}
