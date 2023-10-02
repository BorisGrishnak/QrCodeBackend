using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QrCode.Dto;
using QrCode.Models;

namespace QrCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class UpdateStationController : ControllerBase
    {
        QrCodeContext _context;
        public UpdateStationController(QrCodeContext qrCodeContext)
        {
            _context = qrCodeContext;
        }
        [HttpPatch("{id}")]
        public async Task<ActionResult<Checkpoint>> UpdateExpose(Guid id)
        {
           var check = _context.Checkpoints.Where(e => e.IdPengunjung == id).FirstOrDefault();
           if (check == null)
            {
                return BadRequest();
            }
            check.Expose = true;
            check.UpdatedAt = DateTime.Now.ToLocalTime();
           _context.Checkpoints.Update(check).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok("KENEK BOS");
        }
    }
}
