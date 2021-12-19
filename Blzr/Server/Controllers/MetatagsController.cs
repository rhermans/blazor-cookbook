using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Blzr.Server.Data;
using Blzr.Shared;

namespace Blzr.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetatagsController : ControllerBase
    {
        private readonly BlzrDbContext _context;

        public MetatagsController(BlzrDbContext context)
        {
            _context = context;
        }

        // GET: api/Metatags
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Metatag>>> GetMetatags()
        {
            return await _context.Metatags.ToListAsync();
        }

        // GET: api/Metatags/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Metatag>> GetMetatag(int id)
        {
            var metatag = await _context.Metatags.FindAsync(id);

            if (metatag == null)
            {
                return NotFound();
            }

            return metatag;
        }

        // PUT: api/Metatags/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMetatag(int id, Metatag metatag)
        {
            if (id != metatag.Id)
            {
                return BadRequest();
            }

            _context.Entry(metatag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MetatagExists(id))
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

        // POST: api/Metatags
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Metatag>> PostMetatag(Metatag metatag)
        {
            _context.Metatags.Add(metatag);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMetatag", new { id = metatag.Id }, metatag);
        }

        // DELETE: api/Metatags/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMetatag(int id)
        {
            var metatag = await _context.Metatags.FindAsync(id);
            if (metatag == null)
            {
                return NotFound();
            }

            _context.Metatags.Remove(metatag);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MetatagExists(int id)
        {
            return _context.Metatags.Any(e => e.Id == id);
        }
    }
}