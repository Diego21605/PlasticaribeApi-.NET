﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlasticaribeApi_Prueba.Models
{
    public class Devolucion_MatPrima
    {

        [Key]
        public long DevMatPri_Id { get; set; }

        public long DevMatPri_OrdenTrabajo { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DevMatPri_Fecha { get; set; }

        [Column(TypeName = "text")]
        public string? DevMatPri_Motivo { get; set; }

        public long Usua_Id { get; set; } //Llave foranea de usuario que registra la devolucion
        public Usuario? Usua { get; set; } //Propiedad de navegación usuario que registra la devolucion

        public IList<DetalleDevolucion_MateriaPrima>? DetDevMatPri { get; set; }

    }
}
