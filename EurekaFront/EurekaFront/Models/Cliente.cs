using System.ComponentModel.DataAnnotations;

namespace EurekaFront.Models
{
    public class Cliente
    {
        public string Cc_Nit { get; set; }
        public string Nombre_RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        public int ClienteId { get; set; }
    }
}
