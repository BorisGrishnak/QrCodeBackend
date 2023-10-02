using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QrCode.Migrations
{
    /// <inheritdoc />
    public partial class Checkpointupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkpoints_Pengunjung_PengunjungGuid",
                table: "Checkpoints");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Checkpoints",
                newName: "UTCall");

            migrationBuilder.RenameColumn(
                name: "PengunjungGuid",
                table: "Checkpoints",
                newName: "IdPengunjung");

            migrationBuilder.RenameIndex(
                name: "IX_Checkpoints_PengunjungGuid",
                table: "Checkpoints",
                newName: "IX_Checkpoints_IdPengunjung");

            migrationBuilder.AddColumn<bool>(
                name: "BTS",
                table: "Checkpoints",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Expose",
                table: "Checkpoints",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Force",
                table: "Checkpoints",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkpoints_Pengunjung_IdPengunjung",
                table: "Checkpoints",
                column: "IdPengunjung",
                principalTable: "Pengunjung",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkpoints_Pengunjung_IdPengunjung",
                table: "Checkpoints");

            migrationBuilder.DropColumn(
                name: "BTS",
                table: "Checkpoints");

            migrationBuilder.DropColumn(
                name: "Expose",
                table: "Checkpoints");

            migrationBuilder.DropColumn(
                name: "Force",
                table: "Checkpoints");

            migrationBuilder.RenameColumn(
                name: "UTCall",
                table: "Checkpoints",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "IdPengunjung",
                table: "Checkpoints",
                newName: "PengunjungGuid");

            migrationBuilder.RenameIndex(
                name: "IX_Checkpoints_IdPengunjung",
                table: "Checkpoints",
                newName: "IX_Checkpoints_PengunjungGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkpoints_Pengunjung_PengunjungGuid",
                table: "Checkpoints",
                column: "PengunjungGuid",
                principalTable: "Pengunjung",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
