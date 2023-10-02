using Microsoft.EntityFrameworkCore;
using QrCode.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QrCode.Models;
public partial class Pengunjung
{
    [Key]
    public Guid IdPengunjung { get; set; }
    public ICollection<Checkpoint> Checkpoints { get; set; }
    public string Nama { get; set; } = null!;
    public string NoHP { get; set; } = null!;
    public string Kantor { get; set; } = null!;
    public DateTime CreatedAt { get; set; }

}
