using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QrCode.Migrations
{
    /// <inheritdoc />
    public partial class Pengunjunggg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pengunjung",
                table: "Pengunjung");

            migrationBuilder.AlterColumn<string>(
                name: "KodeUnik",
                table: "Pengunjung",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "KodeUnik",
                table: "Pengunjung",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pengunjung",
                table: "Pengunjung",
                column: "KodeUnik");
        }
    }
}
