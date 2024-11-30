using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonedumController : ControllerBase
    {
        private readonly Db_FacturaContext _context;

        public MonedumController(Db_FacturaContext context)
        {
            _context = context;
        }

        // GET: api/Monedum
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Monedum>>> GetMoneda()
        {
            return await _context.Moneda.ToListAsync();
        }

        // GET: api/Monedum/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Monedum>> GetMonedum(int id)
        {
            var monedum = await _context.Moneda.FindAsync(id);

            if (monedum == null)
            {
                return NotFound();
            }

            return monedum;
        }

        // PUT: api/Monedum/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonedum(int id, Monedum monedum)
        {
            if (id != monedum.IdMoneda)
            {
                return BadRequest();
            }

            _context.Entry(monedum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonedumExists(id))
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

        // POST: api/Monedum
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Monedum>> PostMonedum(Monedum monedum)
        {
            _context.Moneda.Add(monedum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMonedum", new { id = monedum.IdMoneda }, monedum);
        }

        // DELETE: api/Monedum/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMonedum(int id)
        {
            var monedum = await _context.Moneda.FindAsync(id);
            if (monedum == null)
            {
                return NotFound();
            }

            _context.Moneda.Remove(monedum);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MonedumExists(int id)
        {
            return _context.Moneda.Any(e => e.IdMoneda == id);
        }
    }
}
