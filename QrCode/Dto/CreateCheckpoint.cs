using System.ComponentModel.DataAnnotations.Schema;

namespace QrCode.Dto
{
    public class CreateCheckpoint
    {
        public string IdPengunjung { get; set; }
        [ForeignKey(nameof(IdPengunjung))]
        public CreatePengunjungDto Pengunjung { get; set; }
        public bool Expose { get; set; }
        public bool Force { get; set; }
        public bool BTS { get; set; }
        public bool UTCall { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
