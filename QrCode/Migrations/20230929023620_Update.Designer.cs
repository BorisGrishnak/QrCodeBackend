﻿// <auto-generated />
using System;
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
    [Migration("20230929023620_Update")]
    partial class Update
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QrCode.Models.Checkpoint", b =>
                {
                    b.Property<int>("IdCheckpoint")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCheckpoint"));

                    b.Property<bool>("BTS")
                        .HasColumnType("bit");

                    b.Property<bool>("Expose")
                        .HasColumnType("bit");

                    b.Property<bool>("Force")
                        .HasColumnType("bit");

                    b.Property<Guid>("IdPengunjung")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("UTCall")
                        .HasColumnType("bit");

                    b.HasKey("IdCheckpoint");

                    b.HasIndex("IdPengunjung");

                    b.ToTable("Checkpoints");
                });

            modelBuilder.Entity("QrCode.Models.Pengunjung", b =>
                {
                    b.Property<Guid>("IdPengunjung")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Jabatan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kantor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPengunjung");

                    b.ToTable("Pengunjung");
                });

            modelBuilder.Entity("QrCode.Models.Checkpoint", b =>
                {
                    b.HasOne("QrCode.Models.Pengunjung", "Pengunjung")
                        .WithMany()
                        .HasForeignKey("IdPengunjung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pengunjung");
                });
#pragma warning restore 612, 618
        }
    }
}
