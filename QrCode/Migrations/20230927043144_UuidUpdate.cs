using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QrCode.Migrations
{
    /// <inheritdoc />
    public partial class UuidUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Pengunjung");

            migrationBuilder.RenameColumn(
                name: "IdPengunjung",
                table: "Pengunjung",
                newName: "PengunjungId");

            migrationBuilder.AddColumn<Guid>(
                name: "KodeUnik",
                table: "Pengunjung",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KodeUnik",
                table: "Pengunjung");

            migrationBuilder.RenameColumn(
                name: "PengunjungId",
                table: "Pengunjung",
                newName: "IdPengunjung");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Pengunjung",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
