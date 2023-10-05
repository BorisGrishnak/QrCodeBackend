using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QrCode.Models;

namespace QrCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class AdminController : ControllerBase
    {
        QrCodeContext _context;
        public AdminController(QrCodeContext qrCodeContext)
        {
            _context = qrCodeContext;
        }

        [HttpGet]
        public async Task<ActionResult<Pengunjung>> GetPengunjung()
        {
            var a = _context.Pengunjung.Join(_context.Checkpoints,
            Pengunjung => Pengunjung.IdPengunjung,
            Checkpoint => Checkpoint.Pengunjung.IdPengunjung,
            (Pengunjung, Checkpoint) => new
            {
                IdCheckpoint = Checkpoint.IdCheckpoint,
                IdPengunjung = Checkpoint.IdPengunjung,
                Nama = Pengunjung.Nama,
                NoHP = Pengunjung.NoHP,
                Kantor = Pengunjung.Kantor,
                Expose = Checkpoint.Expose,
                Force = Checkpoint.Force,
                BTS = Checkpoint.BTS,
                UTCall = Checkpoint.UTCall,
                CreatedAt = Pengunjung.CreatedAt
            }
            ).ToList();

            return Ok(a);
        }

    }
}