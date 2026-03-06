using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Biblioteca.Data;
using API.Biblioteca.Models;

namespace API.Biblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmprestimoLivrosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EmprestimoLivrosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EmprestimoLivros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmprestimoLivro>>> GetEmprestimoLivro()
        {
            return await _context.EmprestimoLivro.ToListAsync();
        }

        // GET: api/EmprestimoLivros/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmprestimoLivro>> GetEmprestimoLivro(Guid id)
        {
            var emprestimoLivro = await _context.EmprestimoLivro.FindAsync(id);

            if (emprestimoLivro == null)
            {
                return NotFound();
            }

            return emprestimoLivro;
        }

        // PUT: api/EmprestimoLivros/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmprestimoLivro(Guid id, EmprestimoLivro emprestimoLivro)
        {
            if (id != emprestimoLivro.EmprestimoLivroId)
            {
                return BadRequest();
            }

            _context.Entry(emprestimoLivro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmprestimoLivroExists(id))
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

        // POST: api/EmprestimoLivros
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmprestimoLivro>> PostEmprestimoLivro(EmprestimoLivro emprestimoLivro)
        {
            _context.EmprestimoLivro.Add(emprestimoLivro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmprestimoLivro", new { id = emprestimoLivro.EmprestimoLivroId }, emprestimoLivro);
        }

        // DELETE: api/EmprestimoLivros/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmprestimoLivro(Guid id)
        {
            var emprestimoLivro = await _context.EmprestimoLivro.FindAsync(id);
            if (emprestimoLivro == null)
            {
                return NotFound();
            }

            _context.EmprestimoLivro.Remove(emprestimoLivro);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmprestimoLivroExists(Guid id)
        {
            return _context.EmprestimoLivro.Any(e => e.EmprestimoLivroId == id);
        }
    }
}
