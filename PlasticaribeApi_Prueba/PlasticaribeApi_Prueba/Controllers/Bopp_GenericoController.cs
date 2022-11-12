using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using PlasticaribeApi_Prueba.Data;
using PlasticaribeApi_Prueba.Models;


namespace PlasticaribeApi_Prueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Bopp_GenericoController : ControllerBase
    {
        private readonly dataContext _context;

        public Bopp_GenericoController(dataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Area>>> GetAreas()
        {
            return await _context.Areas.ToListAsync();
        }

        // GET: api/Areas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bopp_Generico>> GetArea(long id)
        {
            var Bopp_Generico = await _context.Bopp_Generico.FindAsync(id);

            if (Bopp_Generico == null)
            {
                return NotFound();
            }

            return Bopp_Generico;
        }

        // PUT: api/Areas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArea(long id, Bopp_Generico Bopp_Generico)
        {
            if (id != Bopp_Generico.BoppGen_Id)
            {
                return BadRequest();
            }

            _context.Entry(Bopp_Generico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AreaExists(id))
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

        // POST: api/Areas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bopp_Generico>> PostArea(Bopp_Generico Bopp_Generico)
        {
            _context.Bopp_Generico.Add(Bopp_Generico);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArea", new { id = Bopp_Generico.BoppGen_Id }, Bopp_Generico);
        }

        // DELETE: api/Areas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArea(long id)
        {
            var Bopp_Generico = await _context.Bopp_Generico.FindAsync(id);
            if (Bopp_Generico == null)
            {
                return NotFound();
            }

            _context.Bopp_Generico.Remove(Bopp_Generico);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AreaExists(long id)
        {
            return _context.Areas.Any(e => e.Area_Id == id);
        }
    }
}
