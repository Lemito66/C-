using System.ComponentModel.DataAnnotations;

namespace RepasoWebCore.Controllers
{
    public class Customer
    {
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El campo es requerido")]
        public string Name { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="El campo es requerido")]
        public string Adrress { get; set; }
        public string Cellphone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
    }
}
