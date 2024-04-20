using System.ComponentModel.DataAnnotations;

namespace EurekaFront.Models
{
	public class Articulo
	{
		public string Codigo { get; set; }
		public string Descripcion { get; set; }
		public decimal Costo { get; set; }
        public double Porcentaje { get; set; }
        public decimal PrecioSugerido { get; set; }
        public int Cantidad { get; set; }
		public bool Estado { get; set; }
		public int ArticuloId { get; set; }
	}
}
