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
    public class Detalle_OrdenCompraController : ControllerBase
    {
        private readonly dataContext _context;

        public Detalle_OrdenCompraController(dataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Detalle_OrdenCompra>>> GetAreas()
        {
            return await _context.Detalles_OrdenesCompras.ToListAsync();
        }

        // GET: api/Areas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Detalle_OrdenCompra>> GetArea(long id)
        {
            var Detalle_OrdenCompra = await _context.Detalles_OrdenesCompras.FindAsync(id);

            if (Detalle_OrdenCompra == null)
            {
                return NotFound();
            }

            return Detalle_OrdenCompra;
        }

        // PUT: api/Areas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArea(long id, Detalle_OrdenCompra Detalle_OrdenCompra)
        {
            if (id != Detalle_OrdenCompra.Doc_Codigo)
            {
                return BadRequest();
            }

            _context.Entry(Detalle_OrdenCompra).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }


        // POST: api/Areas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Detalle_OrdenCompra>> PostArea(Detalle_OrdenCompra Detalle_OrdenCompra)
        {
            _context.Detalles_OrdenesCompras.Add(Detalle_OrdenCompra);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArea", new { id = Detalle_OrdenCompra.Doc_Codigo }, Detalle_OrdenCompra);
        }

        // DELETE: api/Areas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArea(long id)
        {
            var Detalle_OrdenCompra = await _context.Detalles_OrdenesCompras.FindAsync(id);
            if (Detalle_OrdenCompra == null)
            {
                return NotFound();
            }

            _context.Detalles_OrdenesCompras.Remove(Detalle_OrdenCompra);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
