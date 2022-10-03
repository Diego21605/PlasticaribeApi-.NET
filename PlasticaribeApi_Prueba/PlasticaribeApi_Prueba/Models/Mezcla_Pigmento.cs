using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlasticaribeApi_Prueba.Models
{
    public class Mezcla_Pigmento
    {

        [Key]
        public int MezPigmto_Id { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string MezPigmto_Nombre { get; set; }

        [Column(TypeName = "text")]
        public string? MezPigmto_Descripcion { get; set; }
    }
}
