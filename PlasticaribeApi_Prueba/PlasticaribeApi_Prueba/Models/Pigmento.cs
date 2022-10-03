using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlasticaribeApi_Prueba.Models
{
    public class Pigmento
    {
        [Key]
        public int Pigmt_Id { get; set; }
        
        [Column(TypeName = "varchar(100)")]
        public string Pigmt_Nombre { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        public string Pigmt_Descripcion { get; set; }
    }
}
