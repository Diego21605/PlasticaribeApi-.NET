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
    public class Orden_CompraController : ControllerBase
    {
        private readonly dataContext _context;

        public Orden_CompraController(dataContext context)
        {
            _context = context;
        }

        // GET: api/Insumoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Orden_Compra>>> GetOrdenes_Compras()
        {
            if (_context.Ordenes_Compras == null)
            {
                return NotFound();
            }
            return await _context.Ordenes_Compras.ToListAsync();
        }

        // GET: api/Insumoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Orden_Compra>> GetOrdenes_Compras(int id)
        {
            if (_context.Ordenes_Compras == null)
            {
                return NotFound();
            }
            var Ordenes_Compras = await _context.Ordenes_Compras.FindAsync(id);

            if (Ordenes_Compras == null)
            {
                return NotFound();
            }

            return Ordenes_Compras;
        }


        // PUT: api/Insumoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrdenes_Compras(int id, Orden_Compra Orden_Compra)
        {
            if (id != Orden_Compra.Oc_Id)
            {
                return BadRequest();
            }

            _context.Entry(Orden_Compra).State = EntityState.Modified;
             await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Insumoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult PostOrdenes_Compras(Orden_Compra Orden_Compra)
        {
            if (_context.Ordenes_Compras == null)
            {
                return Problem("Entity set 'dataContext.Insumos'  is null.");
            }
            _context.Ordenes_Compras.Add(Orden_Compra);
            _context.SaveChangesAsync();

            return Ok(Orden_Compra);
        }

        // DELETE: api/Insumoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrdenes_Compras(int id)
        {
            if (_context.Ordenes_Compras == null)
            {
                return NotFound();
            }
            var Orden_Compra = await _context.Ordenes_Compras.FindAsync(id);
            if (Orden_Compra == null)
            {
                return NotFound();
            }

            _context.Ordenes_Compras.Remove(Orden_Compra);
            await _context.SaveChangesAsync();

            return NoContent();
        }


    }
}
