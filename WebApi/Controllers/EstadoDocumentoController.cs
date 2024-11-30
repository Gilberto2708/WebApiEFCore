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
    public class EstadoDocumentoController : ControllerBase
    {
        private readonly Db_FacturaContext _context;

        public EstadoDocumentoController(Db_FacturaContext context)
        {
            _context = context;
        }

        // GET: api/EstadoDocumento
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstadoDocumento>>> GetEstadoDocumentos()
        {
            return await _context.EstadoDocumentos.ToListAsync();
        }

        // GET: api/EstadoDocumento/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EstadoDocumento>> GetEstadoDocumento(int id)
        {
            var estadoDocumento = await _context.EstadoDocumentos.FindAsync(id);

            if (estadoDocumento == null)
            {
                return NotFound();
            }

            return estadoDocumento;
        }

        // PUT: api/EstadoDocumento/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstadoDocumento(int id, EstadoDocumento estadoDocumento)
        {
            if (id != estadoDocumento.IdEstadoDocumento)
            {
                return BadRequest();
            }

            _context.Entry(estadoDocumento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstadoDocumentoExists(id))
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

        // POST: api/EstadoDocumento
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EstadoDocumento>> PostEstadoDocumento(EstadoDocumento estadoDocumento)
        {
            _context.EstadoDocumentos.Add(estadoDocumento);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EstadoDocumentoExists(estadoDocumento.IdEstadoDocumento))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEstadoDocumento", new { id = estadoDocumento.IdEstadoDocumento }, estadoDocumento);
        }

        // DELETE: api/EstadoDocumento/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstadoDocumento(int id)
        {
            var estadoDocumento = await _context.EstadoDocumentos.FindAsync(id);
            if (estadoDocumento == null)
            {
                return NotFound();
            }

            _context.EstadoDocumentos.Remove(estadoDocumento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstadoDocumentoExists(int id)
        {
            return _context.EstadoDocumentos.Any(e => e.IdEstadoDocumento == id);
        }
    }
}
