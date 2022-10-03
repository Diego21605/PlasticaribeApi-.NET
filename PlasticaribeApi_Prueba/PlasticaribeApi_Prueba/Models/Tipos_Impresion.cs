using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlasticaribeApi_Prueba.Models
{
    public class Tipos_Impresion
    {
        [Key]
        public int TpImpresion_Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string TpImpresion_Nombre { get; set; }

        [Column(TypeName = "text")]
        public string Tp_Impresion_Descripcion { get; set; }
    }
}
