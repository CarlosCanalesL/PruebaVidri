using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaVidri.Data;
using PruebaVidri.Entities;

namespace PruebaVidri.Controllers
{
    [Route("api/hero")] 
    [ApiController] 
    public class HeroController : ControllerBase
    {
        private readonly DataContext _context;

        public HeroController(DataContext context)
        {
            _context = context;
        }

        // GET: api/hero
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hero>>> GetHeros()
        {
            return await _context.Hero.ToListAsync();
        }

        // GET: api/hero/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hero>> GetHero(int id)
        {
            var hero = await _context.Hero.FindAsync(id);

            if (hero == null)
            {
                return NotFound();
            }

            return hero;
        }

        // PUT: api/hero/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHero(int id, Hero hero)
        {
            if (id != hero.HeroId)
            {
                return BadRequest();
            }

            _context.Entry(hero).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeroExists(id))
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
        public async Task<ActionResult<Hero>> PostHero(Hero hero)
        {
            _context.Hero.Add(hero);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetHero), new { id = hero.HeroId }, hero);
        }

        // DELETE: api/hero/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHero(int id)
        {
            var hero = await _context.Hero.FindAsync(id);
            if (hero == null)
            {
                return NotFound();
            }

            _context.Hero.Remove(hero);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HeroExists(int id)
        {
            return _context.Hero.Any(e => e.HeroId == id);
        }
    }
}
