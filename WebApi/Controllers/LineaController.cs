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
    public class LineaController : ControllerBase
    {
        private readonly Db_FacturaContext _context;

        public LineaController(Db_FacturaContext context)
        {
            _context = context;
        }

        // GET: api/Linea
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Linea>>> GetLineas()
        {
            return await _context.Lineas.ToListAsync();
        }

        // GET: api/Linea/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Linea>> GetLinea(int id)
        {
            var linea = await _context.Lineas.FindAsync(id);

            if (linea == null)
            {
                return NotFound();
            }

            return linea;
        }

        // PUT: api/Linea/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLinea(int id, Linea linea)
        {
            if (id != linea.IdLinea)
            {
                return BadRequest();
            }

            _context.Entry(linea).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LineaExists(id))
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

        // POST: api/Linea
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Linea>> PostLinea(Linea linea)
        {
            _context.Lineas.Add(linea);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLinea", new { id = linea.IdLinea }, linea);
        }

        // DELETE: api/Linea/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLinea(int id)
        {
            var linea = await _context.Lineas.FindAsync(id);
            if (linea == null)
            {
                return NotFound();
            }

            _context.Lineas.Remove(linea);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LineaExists(int id)
        {
            return _context.Lineas.Any(e => e.IdLinea == id);
        }
    }
}
