﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QrCode.Models;

#nullable disable

namespace QrCode.Migrations
{
    [DbContext(typeof(QrCodeContext))]
    [Migration("20230927012351_First")]
    partial class First
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QrCode.Models.Pengunjung", b =>
                {
                    b.Property<int>("MyProperty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MyProperty"));

                    b.Property<string>("Jabatan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kantor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MyProperty");

                    b.ToTable("Pengunjung");
                });
#pragma warning restore 612, 618
        }
    }
}
