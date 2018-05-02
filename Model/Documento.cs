using System.ComponentModel.DataAnnotations;

namespace Demo.Model
{
    public class Documento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }

        [Required]
        public bool Activo { get; set; }
    }

}
