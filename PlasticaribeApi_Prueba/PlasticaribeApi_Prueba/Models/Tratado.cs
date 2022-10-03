using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlasticaribeApi_Prueba.Models
{
    public class Tratado
    {
        [Key]
        public int Tratado_Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Tratado_Nombre { get; set; }

        [Column(TypeName = "text")]
        public string Tratado_Descripcion { get; set; }
    }
}
