using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlasticaribeApi_Prueba.Models
{
    public class Tipo_Proveedor
    {
        [Key]
        public int TpProv_Id { get; set; }

        [Column(TypeName="varchar(MAX)")]
        public string TpProv_Nombre { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        public string TpProv_Descripcion { get; set; }

    }
}
