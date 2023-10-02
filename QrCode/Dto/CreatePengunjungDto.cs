namespace QrCode.Dto
{
    public class CreatePengunjungDto
    {
        public string Nama { get; set; } = null!;
        public string NoHP { get; set; } = null!;
        public string Kantor { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
