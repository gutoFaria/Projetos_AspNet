using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemaController : ControllerBase
    {
        private readonly QuizDbContext _context;

        public TemaController(QuizDbContext context)
        {
            _context = context;
        }

        // GET: api/Tema
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tema>>> GetTemas()
        {
          if (_context.Temas == null)
          {
              return NotFound();
          }
            return await _context.Temas.ToListAsync();
        }

        // GET: api/Tema/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tema>> GetTema(int id)
        {
          if (_context.Temas == null)
          {
              return NotFound();
          }
            var tema = await _context.Temas.FindAsync(id);

            if (tema == null)
            {
                return NotFound();
            }

            return tema;
        }

        // PUT: api/Tema/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTema(int id, Tema tema)
        {
            if (id != tema.TemaId)
            {
                return BadRequest();
            }

            _context.Entry(tema).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TemaExists(id))
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

        // POST: api/Tema
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tema>> PostTema(Tema tema)
        {
          if (_context.Temas == null)
          {
              return Problem("Entity set 'QuizDbContext.Temas'  is null.");
          }
            _context.Temas.Add(tema);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTema", new { id = tema.TemaId }, tema);
        }

        // DELETE: api/Tema/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTema(int id)
        {
            if (_context.Temas == null)
            {
                return NotFound();
            }
            var tema = await _context.Temas.FindAsync(id);
            if (tema == null)
            {
                return NotFound();
            }

            _context.Temas.Remove(tema);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TemaExists(int id)
        {
            return (_context.Temas?.Any(e => e.TemaId == id)).GetValueOrDefault();
        }
    }
}
