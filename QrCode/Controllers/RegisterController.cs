using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using QrCode.Models;
using QRCoder;
using System.Drawing;
using System.ComponentModel;
using System.Security.Cryptography;
using QrCode.Dto;
using Microsoft.EntityFrameworkCore;

namespace QrCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class RegisterController : ControllerBase
    {
        QrCodeContext _context;
        public RegisterController(QrCodeContext qrCodeContext)
        {
            _context = qrCodeContext;
        }
        [HttpGet("Getbyid/{IdCheckpoint}")]
        public ActionResult<Checkpoint> GetById(int IdCheckpoint)
        {
            if (IdCheckpoint <= 0)
            {
                return NotFound("not found");
            }

            Checkpoint Checkpoints = _context.Checkpoints.FirstOrDefault(s => s.IdCheckpoint == IdCheckpoint);

            if (Checkpoints == null)
            {
                return NotFound("notfound");
            }

            return Ok(Checkpoints);
        }
        [HttpPost]
        public async Task<ActionResult<Checkpoint>> CreatePengunjung(CreateCheckpoint createCheckpoint)
        {
            var pengunjung = new Pengunjung
            {
                Nama = createCheckpoint.Pengunjung.Nama,
                NoHP = createCheckpoint.Pengunjung.NoHP,
                Kantor = createCheckpoint.Pengunjung.Kantor,
                CreatedAt = DateTime.Now.ToLocalTime(),
            };
            _context.Pengunjung.Add(pengunjung);
            var checkpoint = new Checkpoint
            {
                IdPengunjung = pengunjung.IdPengunjung,
                Expose = false,
                Force = false,
                BTS = false,
                UTCall = false,
                UpdatedAt = DateTime.Now.ToLocalTime(),

            };
            _context.Checkpoints.Add(checkpoint);
            await _context.SaveChangesAsync();
            return Ok(checkpoint);
        }

    }
}
