using System.ComponentModel.DataAnnotations;

namespace webCoreCustomer.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Display(Name = "Nombre", Prompt ="Ingrese el nombre del cliente", Description ="Nombre del cliente")]
        public string? Name { get; set; }
        [Display(Name = "Dirección")]
        public string? Address { get; set; }
        [Display(Name = "Teléfono")]
        [StringLength(10, MinimumLength = 10, ErrorMessage ="Solo es permitido 10 caracteres")]
        public string? Telephone { get; set; }
        [Display(Name = "Límite de crédito")]
        public decimal CreditLimit { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de creación")]
        public DateTime CreatedAt { get; set; }

        [Range(1, 5, ErrorMessage = "Solo es permitido de 1 a 5")]
        [Display(Name = "Categoría")]
        public int Category { get; set; }
        
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "El email es requerido")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", 
                       ErrorMessage = "El email no es valido")]
        public string Email { get; set; }
    }
}
