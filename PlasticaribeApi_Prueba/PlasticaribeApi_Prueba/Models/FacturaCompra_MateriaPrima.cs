using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlasticaribeApi_Prueba.Models
{
    public class FacturaCompra_MateriaPrima
    {

        [Key]
        [Column(Order = 0)]
        public long Facco_Codigo { get; set; } //Llave primaria compuesta Factura_Compra


        [Column(Order = 1)]
        public long Facco_Id { get; set; } //Llave primaria compuesta Factura_Compra
        public Factura_Compra? Facco { get; set; } //Propiedad de navegación Factura_Compra



        [Column(Order = 2)]
        public long MatPri_Id { get; set; } //Llave primaria compuesta Materia_Prima
        public Materia_Prima? MatPri { get; set; } //Propiedad de navegación Materia_Prima



        [Column(Order = 3)]
        public long Tinta_Id { get; set; } //Llave primaria compuesta Tinta
        public Tinta? Tinta { get; set; } //Propiedad de navegación Tinta



        [Column(Order = 4)]
        [Precision(14, 2)]      
        public decimal FaccoMatPri_Cantidad { get; set; }



        [Column(TypeName = "varchar(10)", Order = 5)]
        public string UndMed_Id { get; set; }
        public Unidad_Medida? UndMed { get; set; }



        [Column(Order = 6)]
        [Precision(18, 2)]
        public decimal FaccoMatPri_ValorUnitario { get; set; }

     


    }
}
