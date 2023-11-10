using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cp6_rm93449.Models;
using cp6_rm93449.Persistence;

namespace cp6_rm93449.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcessoriosController : ControllerBase
    {
        private readonly OracleDbContext _context;

        public AcessoriosController(OracleDbContext context)
        {
            _context = context;
        }

        // GET: api/Acessorios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Acessorio>>> GetAcessorio()
        {
          if (_context.Acessorio == null)
          {
              return NotFound();
          }
            return await _context.Acessorio.ToListAsync();
        }

        // GET: api/Acessorios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Acessorio>> GetAcessorio(int id)
        {
          if (_context.Acessorio == null)
          {
              return NotFound();
          }
            var acessorio = await _context.Acessorio.FindAsync(id);

            if (acessorio == null)
            {
                return NotFound();
            }

            return acessorio;
        }

        // PUT: api/Acessorios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAcessorio(int id, Acessorio acessorio)
        {
            if (id != acessorio.id)
            {
                return BadRequest();
            }

            _context.Entry(acessorio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AcessorioExists(id))
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

        // POST: api/Acessorios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Acessorio>> PostAcessorio(Acessorio acessorio)
        {
          if (_context.Acessorio == null)
          {
              return Problem("Entity set 'OracleDbContext.Acessorio'  is null.");
          }
            _context.Acessorio.Add(acessorio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAcessorio", new { id = acessorio.id }, acessorio);
        }

        // DELETE: api/Acessorios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAcessorio(int id)
        {
            if (_context.Acessorio == null)
            {
                return NotFound();
            }
            var acessorio = await _context.Acessorio.FindAsync(id);
            if (acessorio == null)
            {
                return NotFound();
            }

            _context.Acessorio.Remove(acessorio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AcessorioExists(int id)
        {
            return (_context.Acessorio?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
