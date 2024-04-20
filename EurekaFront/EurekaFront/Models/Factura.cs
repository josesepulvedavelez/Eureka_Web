using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EurekaFront.Models
{
    public class Factura
    {
        public string No { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }                
        public int ClienteId { get; set; }
        public int FacturaId { get; set; }

        public List<FacturaDetalle>? lstFacturaDetalle { get; set; }
    }
}
