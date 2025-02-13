using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaVidri.Data;
using PruebaVidri.Entities;

namespace PruebaVidri.Controllers
{
    [Route("api/power")] // Define la ruta base correctamente
    [ApiController] 
    public class PowerController : ControllerBase
    {
        private readonly DataContext _context;

        public PowerController(DataContext context)
        {
            _context = context;
        }

        // GET: api/hero
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Power>>> GetPower()
        {
            return await _context.Power.ToListAsync();
        }

        // GET: api/hero/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Power>> GetPower(int id)
        {
            var power = await _context.Power.FindAsync(id);

            if (power == null)
            {
                return NotFound();
            }

            return power;
        }

        // PUT: api/hero/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPower(int id, Power power)
        {
            if (id != power.Id)
            {
                return BadRequest();
            }

            _context.Entry(power).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PowerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/hero
        [HttpPost]
        public async Task<ActionResult<Hero>> PostPower(Power power)
        {
            _context.Power.Add(power);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPower), new { id = power.Id }, power);
        }

        // DELETE: api/hero/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePower(int id)
        {
            var power = await _context.Power.FindAsync(id);
            if (power == null)
            {
                return NotFound();
            }

            _context.Power.Remove(power);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PowerExists(int id)
        {
            return _context.Power.Any(e => e.Id == id);
        }
    }
}
