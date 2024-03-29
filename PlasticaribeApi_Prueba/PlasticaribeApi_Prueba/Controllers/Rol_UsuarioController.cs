﻿#nullable disable
using System;
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
    public class Rol_UsuarioController : ControllerBase
    {
        private readonly dataContext _context;

        public Rol_UsuarioController(dataContext context)
        {
            _context = context;
        }

        // GET: api/Rol_Usuario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rol_Usuario>>> GetRoles_Usuarios()
        {
            return await _context.Roles_Usuarios.ToListAsync();
        }

        // GET: api/Rol_Usuario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rol_Usuario>> GetRol_Usuario(int id)
        {
            var rol_Usuario = await _context.Roles_Usuarios.FindAsync(id);

            if (rol_Usuario == null)
            {
                return NotFound();
            }

            return rol_Usuario;
        }

        // PUT: api/Rol_Usuario/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRol_Usuario(int id, Rol_Usuario rol_Usuario)
        {
            if (id != rol_Usuario.RolUsu_Id)
            {
                return BadRequest();
            }

            _context.Entry(rol_Usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Rol_UsuarioExists(id))
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

        // POST: api/Rol_Usuario
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Rol_Usuario>> PostRol_Usuario(Rol_Usuario rol_Usuario)
        {
            _context.Roles_Usuarios.Add(rol_Usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRol_Usuario", new { id = rol_Usuario.RolUsu_Id }, rol_Usuario);
        }

        // DELETE: api/Rol_Usuario/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRol_Usuario(int id)
        {
            var rol_Usuario = await _context.Roles_Usuarios.FindAsync(id);
            if (rol_Usuario == null)
            {
                return NotFound();
            }

            _context.Roles_Usuarios.Remove(rol_Usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Rol_UsuarioExists(int id)
        {
            return _context.Roles_Usuarios.Any(e => e.RolUsu_Id == id);
        }
    }
}
