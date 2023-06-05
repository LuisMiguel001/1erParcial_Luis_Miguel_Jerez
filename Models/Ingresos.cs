using System.ComponentModel.DataAnnotations;

namespace _1erParcial_Luis_Miguel_Jerez.Models
{
    public class Ingresos
    {
        [Key]

        public int IngresosId { get; set; }

        public DateTime Fecha { get; set; }

        public string Concepto { get; set; }

        public Decimal Monto { get; set; }
    }
}
