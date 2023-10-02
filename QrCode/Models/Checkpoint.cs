using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace QrCode.Models
{
    public class Checkpoint
    {
        [Key]
        public int IdCheckpoint { get; set; }
        public Guid IdPengunjung { get; set; }
        [ForeignKey(nameof(IdPengunjung))]
        [JsonIgnore]
        public Pengunjung Pengunjung { get; set; }
        public bool Expose { get; set; }
        public bool Force { get; set; }
        public bool BTS { get; set; }
        public bool UTCall { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
