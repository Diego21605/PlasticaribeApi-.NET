using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlasticaribeApi_Prueba.Models
{
    public class Mezcla_Material
    {
        [Key]
        public int MezMaterial_Id { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string MezMaterial_Nombre { get; set; }

        [Column(TypeName = "text")]
        public string? MezMaterial_Descripcion { get; set; }
    }
}
