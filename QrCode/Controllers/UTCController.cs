using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QrCode.Models;

namespace QrCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class UTCController : ControllerBase
    {
        QrCodeContext _context;
        public UTCController(QrCodeContext qrCodeContext)
        {
            _context = qrCodeContext;
        }
        [HttpPatch("{id}")]
        public async Task<ActionResult<Checkpoint>> UpdateUTC(Guid id)
        {
            var check = _context.Checkpoints.Where(e => e.IdPengunjung == id).FirstOrDefault();
            if(check == null)
            {
                return BadRequest();
            }
            if (check.Expose == false || check.Force == false || check.BTS == false)
            {
                return BadRequest();
            }
            check.UTCall = true;
            check.UpdatedAt = DateTime.Now.ToLocalTime();
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
