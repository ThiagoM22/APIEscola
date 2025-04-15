using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIEscola.Data;
using APIEscola.Models;
using Microsoft.AspNetCore.Authorization;

namespace APIEscola.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MatriculasController : ControllerBase
    {
        private readonly APIEscolaContext _context;

        public MatriculasController(APIEscolaContext context)
        {
            _context = context;
        }

        // GET: api/Matriculas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Matricula>>> GetMatriculas()
        {
            return await _context.Matriculas.ToListAsync();
        }

        // GET: api/Matriculas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Matricula>> GetMatricula(Guid id)
        {
            var matricula = await _context.Matriculas.FindAsync(id);

            if (matricula == null)
            {
                return NotFound();
            }

            return matricula;
        }

        // PUT: api/Matriculas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMatricula(Guid id, Matricula matricula)
        {
            if (id != matricula.MatriculaId)
            {
                return BadRequest();
            }

            _context.Entry(matricula).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MatriculaExists(id))
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

        // POST: api/Matriculas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Matricula>> PostMatricula(Matricula matricula)
        {
            _context.Matriculas.Add(matricula);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMatricula", new { id = matricula.MatriculaId }, matricula);
        }

        // DELETE: api/Matriculas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMatricula(Guid id)
        {
            var matricula = await _context.Matriculas.FindAsync(id);
            if (matricula == null)
            {
                return NotFound();
            }

            _context.Matriculas.Remove(matricula);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MatriculaExists(Guid id)
        {
            return _context.Matriculas.Any(e => e.MatriculaId == id);
        }
    }
}
