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
    public class Asignacion_MatPrimaController : ControllerBase
    {
        private readonly dataContext _context;

        public Asignacion_MatPrimaController(dataContext context)
        {
            _context = context;
        }

        // GET: api/Asignacion_MatPrima
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Asignacion_MatPrima>>> GetAsignaciones_MatPrima()
        {
          if (_context.Asignaciones_MatPrima == null)
          {
              return NotFound();
          }
            return await _context.Asignaciones_MatPrima.ToListAsync();
        }

        // GET: api/Asignacion_MatPrima/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Asignacion_MatPrima>> GetAsignacion_MatPrima(long id)
        {
          if (_context.Asignaciones_MatPrima == null)
          {
              return NotFound();
          }
            var asignacion_MatPrima = await _context.Asignaciones_MatPrima.FindAsync(id);

            if (asignacion_MatPrima == null)
            {
                return NotFound();
            }

            return asignacion_MatPrima;
        }


        [HttpGet("ultimoId/")]
        public ActionResult<Asignacion_MatPrima> GetUltimoId()
        {
            var asignacion = _context.Asignaciones_MatPrima.OrderBy(asg => asg.AsigMp_Id).Last();

            return Ok(asignacion);
        }

        //Consulta por orden de trabajo
        [HttpGet("ot/{AsigMP_OrdenTrabajo}")]
        public ActionResult<Asignacion_MatPrima> GetOt(long AsigMP_OrdenTrabajo)
        {
            var asignacion_MatPrima = _context.Asignaciones_MatPrima.Where(asg => asg.AsigMP_OrdenTrabajo == AsigMP_OrdenTrabajo).ToList();

            if (asignacion_MatPrima == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(asignacion_MatPrima); 
            }            
        }

        //Consulta por fecha
        [HttpGet("fecha/{AsigMp_FechaEntrega}")]
        public ActionResult<Asignacion_MatPrima> GetFecha(DateTime AsigMp_FechaEntrega)
        {
            var asignacion_MatPrima = _context.Asignaciones_MatPrima.Where(asg => asg.AsigMp_FechaEntrega == AsigMp_FechaEntrega).ToList();

            if (asignacion_MatPrima == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(asignacion_MatPrima);
            }
        }

        [HttpGet("fechas/")]
        public ActionResult<Asignacion_MatPrima> GetFechas(DateTime AsigMp_FechaEntrega1, DateTime AsigMp_FechaEntrega2)
        {
            var asignacion_MatPrima = _context.Asignaciones_MatPrima.Where(asg => asg.AsigMp_FechaEntrega >= AsigMp_FechaEntrega1 && asg.AsigMp_FechaEntrega <= AsigMp_FechaEntrega2).ToList();

            if (asignacion_MatPrima == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(asignacion_MatPrima);
            }
        }

        [HttpGet("fecha_Ot/")]
        public ActionResult<Asignacion_MatPrima> GetFecha_OT(DateTime AsigMp_FechaEntrega, long AsigMP_OrdenTrabajo)
        {
            var asignacion_MatPrima = _context.Asignaciones_MatPrima.Where(asg => asg.AsigMp_FechaEntrega == AsigMp_FechaEntrega && asg.AsigMP_OrdenTrabajo == AsigMP_OrdenTrabajo).ToList();

            if (asignacion_MatPrima == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(asignacion_MatPrima);
            }
        }

        // PUT: api/Asignacion_MatPrima/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsignacion_MatPrima(long id, Asignacion_MatPrima asignacion_MatPrima)
        {
            if (id != asignacion_MatPrima.AsigMp_Id)
            {
                return BadRequest();
            }

            _context.Entry(asignacion_MatPrima).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Asignacion_MatPrimaExists(id))
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

        // POST: api/Asignacion_MatPrima
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Asignacion_MatPrima>> PostAsignacion_MatPrima(Asignacion_MatPrima asignacion_MatPrima)
        {
          if (_context.Asignaciones_MatPrima == null)
          {
              return Problem("Entity set 'dataContext.Asignaciones_MatPrima'  is null.");
          }
            _context.Asignaciones_MatPrima.Add(asignacion_MatPrima);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAsignacion_MatPrima", new { id = asignacion_MatPrima.AsigMp_Id }, asignacion_MatPrima);
        }

        // DELETE: api/Asignacion_MatPrima/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsignacion_MatPrima(long id)
        {
            if (_context.Asignaciones_MatPrima == null)
            {
                return NotFound();
            }
            var asignacion_MatPrima = await _context.Asignaciones_MatPrima.FindAsync(id);
            if (asignacion_MatPrima == null)
            {
                return NotFound();
            }

            _context.Asignaciones_MatPrima.Remove(asignacion_MatPrima);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Asignacion_MatPrimaExists(long id)
        {
            return (_context.Asignaciones_MatPrima?.Any(e => e.AsigMp_Id == id)).GetValueOrDefault();
        }
    }
}
