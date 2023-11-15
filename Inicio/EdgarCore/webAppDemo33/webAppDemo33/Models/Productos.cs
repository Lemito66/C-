using System.ComponentModel.DataAnnotations;

namespace webAppDemo33.Models
{
    public class Productos
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Existencias { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }
    }
}
