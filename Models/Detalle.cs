using System.ComponentModel.DataAnnotations;

namespace _1erParcial_Luis_Miguel_Jerez.Models
{
    public class Detalle
    {
        [Key]

        [Required (ErrorMessage = "El Campo Emisor es obligatorio")]
        public string? Emisor { get; set; }

        [Required(ErrorMessage = "El Campo Emisor es obligatorio")]
        public string? Mensaje { get; set; }
    }
}
