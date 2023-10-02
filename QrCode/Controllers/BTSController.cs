using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QrCode.Models;

namespace QrCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class BTSController : ControllerBase
    {
        QrCodeContext _context;
        public BTSController(QrCodeContext qrCodeContext)
        {
            _context = qrCodeContext;
        }
        [HttpPatch("{id}")]
        public async Task<ActionResult<Checkpoint>> UpdateBTS(Guid id)
        {
            var check = _context.Checkpoints.Where(e => e.IdPengunjung ==  id).FirstOrDefault();
            if (check == null)
            {
                return BadRequest();
            }
            if(check.Expose == true && check.Force == true)
            {
                check.BTS = true;
                check.UpdatedAt = DateTime.Now.ToLocalTime();
            }
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
