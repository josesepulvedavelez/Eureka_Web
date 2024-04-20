using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EurekaFront.Models
{
    public class FacturaDetalle
    {
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public int ArticuloId { get; set; }
        public int FacturaId { get; set; }
        public int FacturaDetalleId { get; set; }
    }
}
