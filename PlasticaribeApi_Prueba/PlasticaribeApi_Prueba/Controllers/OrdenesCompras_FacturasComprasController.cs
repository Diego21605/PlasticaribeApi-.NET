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
    public class OrdenesCompras_FacturasComprasController : ControllerBase
    {
        private readonly dataContext _context;

        public OrdenesCompras_FacturasComprasController(dataContext context)
        {
            _context = context;
        }

        // GET: api/Insumoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrdenesCompras_FacturasCompras>>> GetOrdenesCompras_FacturasCompras()
        {
            if (_context.OrdenesCompras_FacturasCompras == null)
            {
                return NotFound();
            }
            return await _context.OrdenesCompras_FacturasCompras.ToListAsync();
        }

        // GET: api/Insumoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrdenesCompras_FacturasCompras>> GetOrdenesCompras_FacturasCompras(int id)
        {
            if (_context.OrdenesCompras_FacturasCompras == null)
            {
                return NotFound();
            }
            var Ordenes_Compras = await _context.OrdenesCompras_FacturasCompras.FindAsync(id);

            if (Ordenes_Compras == null)
            {
                return NotFound();
            }

            return Ordenes_Compras;
        }


        // PUT: api/Insumoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrdenesCompras_FacturasCompras(int id, OrdenesCompras_FacturasCompras OrdenesCompras_FacturasCompras)
        {
            if (id != OrdenesCompras_FacturasCompras.Oc_Id)
            {
                return BadRequest();
            }

            _context.Entry(OrdenesCompras_FacturasCompras).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Insumoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult PostOrdenes_Compras(OrdenesCompras_FacturasCompras OrdenesCompras_FacturasCompras)
        {
            if (_context.OrdenesCompras_FacturasCompras == null)
            {
                return Problem("Entity set 'dataContext.Insumos'  is null.");
            }
            _context.OrdenesCompras_FacturasCompras.Add(OrdenesCompras_FacturasCompras);
            _context.SaveChangesAsync();

            return Ok(OrdenesCompras_FacturasCompras);
        }

        // DELETE: api/Insumoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrdenes_Compras(int id)
        {
            if (_context.OrdenesCompras_FacturasCompras == null)
            {
                return NotFound();
            }
            var OrdenesCompras_FacturasCompras = await _context.OrdenesCompras_FacturasCompras.FindAsync(id);
            if (OrdenesCompras_FacturasCompras == null)
            {
                return NotFound();
            }

            _context.OrdenesCompras_FacturasCompras.Remove(OrdenesCompras_FacturasCompras);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
