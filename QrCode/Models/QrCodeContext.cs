using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QrCode.Models;

public partial class QrCodeContext : DbContext
{
    
    public QrCodeContext(DbContextOptions<QrCodeContext> options)
        : base(options)
    {
    }
    
    public virtual DbSet<Pengunjung> Pengunjung { get; set; }
    public virtual DbSet<Checkpoint> Checkpoints { get; set; }

    /*protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MigrationOperation>().HasNoKey();
    }*/
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
