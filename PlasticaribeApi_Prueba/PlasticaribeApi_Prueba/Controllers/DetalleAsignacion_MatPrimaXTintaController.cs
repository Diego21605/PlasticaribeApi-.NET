﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlasticaribeApi_Prueba.Data;
using PlasticaribeApi_Prueba.Models;

namespace PlasticaribeApi_Prueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleAsignacion_MatPrimaXTintaController : ControllerBase
    {
        private readonly dataContext _context;

        public DetalleAsignacion_MatPrimaXTintaController(dataContext context)
        {
            _context = context;
        }

        // GET: api/DetalleAsignacion_MatPrimaXTinta
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleAsignacion_MatPrimaXTinta>>> GetDetallesAsignaciones_MatPrimasXTintas()
        {
          if (_context.DetallesAsignaciones_MatPrimasXTintas == null)
          {
              return NotFound();
          }
            return await _context.DetallesAsignaciones_MatPrimasXTintas.ToListAsync();
        }

        // GET: api/DetalleAsignacion_MatPrimaXTinta/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleAsignacion_MatPrimaXTinta>> GetDetalleAsignacion_MatPrimaXTinta(long id)
        {
          if (_context.DetallesAsignaciones_MatPrimasXTintas == null)
          {
              return NotFound();
          }
            var detalleAsignacion_MatPrimaXTinta = await _context.DetallesAsignaciones_MatPrimasXTintas.FindAsync(id);

            if (detalleAsignacion_MatPrimaXTinta == null)
            {
                return NotFound();
            }

            return detalleAsignacion_MatPrimaXTinta;
        }

        // PUT: api/DetalleAsignacion_MatPrimaXTinta/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalleAsignacion_MatPrimaXTinta(long id, DetalleAsignacion_MatPrimaXTinta detalleAsignacion_MatPrimaXTinta)
        {
            if (id != detalleAsignacion_MatPrimaXTinta.AsigMPxTinta_Id)
            {
                return BadRequest();
            }

            _context.Entry(detalleAsignacion_MatPrimaXTinta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalleAsignacion_MatPrimaXTintaExists(id))
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


        // POST: api/DetalleAsignacion_MatPrimaXTinta
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DetalleAsignacion_MatPrimaXTinta>> PostDetalleAsignacion_MatPrimaXTinta(DetalleAsignacion_MatPrimaXTinta detalleAsignacion_MatPrimaXTinta)
        {
          if (_context.DetallesAsignaciones_MatPrimasXTintas == null)
          {
              return Problem("Entity set 'dataContext.DetallesAsignaciones_MatPrimasXTintas'  is null.");
          }
            _context.DetallesAsignaciones_MatPrimasXTintas.Add(detalleAsignacion_MatPrimaXTinta);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DetalleAsignacion_MatPrimaXTintaExists(detalleAsignacion_MatPrimaXTinta.AsigMPxTinta_Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDetalleAsignacion_MatPrimaXTinta", new { id = detalleAsignacion_MatPrimaXTinta.AsigMPxTinta_Id }, detalleAsignacion_MatPrimaXTinta);
        }

        // DELETE: api/DetalleAsignacion_MatPrimaXTinta/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalleAsignacion_MatPrimaXTinta(long id)
        {
            if (_context.DetallesAsignaciones_MatPrimasXTintas == null)
            {
                return NotFound();
            }
            var detalleAsignacion_MatPrimaXTinta = await _context.DetallesAsignaciones_MatPrimasXTintas.FindAsync(id);
            if (detalleAsignacion_MatPrimaXTinta == null)
            {
                return NotFound();
            }

            _context.DetallesAsignaciones_MatPrimasXTintas.Remove(detalleAsignacion_MatPrimaXTinta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetalleAsignacion_MatPrimaXTintaExists(long id)
        {
            return (_context.DetallesAsignaciones_MatPrimasXTintas?.Any(e => e.AsigMPxTinta_Id == id)).GetValueOrDefault();
        }
    }
}
