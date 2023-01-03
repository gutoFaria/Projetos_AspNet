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
    public class MateriaController : ControllerBase
    {
        private readonly QuizDbContext _context;

        public MateriaController(QuizDbContext context)
        {
            _context = context;
        }

        // GET: api/Materia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Materia>>> GetMaterias()
        {
          if (_context.Materias == null)
          {
              return NotFound();
          }
            return await _context.Materias.ToListAsync();
        }

        // GET: api/Materia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Materia>> GetMateria(int id)
        {
          if (_context.Materias == null)
          {
              return NotFound();
          }
            var materia = await _context.Materias.FindAsync(id);

            if (materia == null)
            {
                return NotFound();
            }

            return materia;
        }

        // PUT: api/Materia/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMateria(int id, Materia materia)
        {
            if (id != materia.MateriaId)
            {
                return BadRequest();
            }

            _context.Entry(materia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MateriaExists(id))
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

        // POST: api/Materia
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Materia>> PostMateria(Materia materia)
        {
          if (_context.Materias == null)
          {
              return Problem("Entity set 'QuizDbContext.Materias'  is null.");
          }
            _context.Materias.Add(materia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMateria", new { id = materia.MateriaId }, materia);
        }

        // DELETE: api/Materia/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMateria(int id)
        {
            if (_context.Materias == null)
            {
                return NotFound();
            }
            var materia = await _context.Materias.FindAsync(id);
            if (materia == null)
            {
                return NotFound();
            }

            _context.Materias.Remove(materia);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MateriaExists(int id)
        {
            return (_context.Materias?.Any(e => e.MateriaId == id)).GetValueOrDefault();
        }
    }
}
