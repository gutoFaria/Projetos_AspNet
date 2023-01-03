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
    public class PerguntaController : ControllerBase
    {
        private readonly QuizDbContext _context;

        public PerguntaController(QuizDbContext context)
        {
            _context = context;
        }

        // GET: api/Pergunta
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pergunta>>> GetPerguntas()
        {
          if (_context.Perguntas == null)
          {
              return NotFound();
          }
            return await _context.Perguntas.ToListAsync();
        }

        // GET: api/Pergunta/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pergunta>> GetPergunta(int id)
        {
          if (_context.Perguntas == null)
          {
              return NotFound();
          }
            var pergunta = await _context.Perguntas.FindAsync(id);

            if (pergunta == null)
            {
                return NotFound();
            }

            return pergunta;
        }

        // PUT: api/Pergunta/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPergunta(int id, Pergunta pergunta)
        {
            if (id != pergunta.PerguntaId)
            {
                return BadRequest();
            }

            _context.Entry(pergunta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PerguntaExists(id))
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

        // POST: api/Pergunta
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pergunta>> PostPergunta(Pergunta pergunta)
        {
          if (_context.Perguntas == null)
          {
              return Problem("Entity set 'QuizDbContext.Perguntas'  is null.");
          }
            _context.Perguntas.Add(pergunta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPergunta", new { id = pergunta.PerguntaId }, pergunta);
        }

        // DELETE: api/Pergunta/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePergunta(int id)
        {
            if (_context.Perguntas == null)
            {
                return NotFound();
            }
            var pergunta = await _context.Perguntas.FindAsync(id);
            if (pergunta == null)
            {
                return NotFound();
            }

            _context.Perguntas.Remove(pergunta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PerguntaExists(int id)
        {
            return (_context.Perguntas?.Any(e => e.PerguntaId == id)).GetValueOrDefault();
        }
    }
}
