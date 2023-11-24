using System.ComponentModel.DataAnnotations;

namespace appHospital.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 50 caracteres")]
        [Display(Name = "Nombre", Prompt = "Ingrese su nombre",
                      Description = "Nombre de usuario")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "El email es requerido")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
                      ErrorMessage = "El email no es valido")]
        [Display(Name = "Correo Electrónico", Prompt = "Ingrese su correo electrónico",
           Description = "Correo electrónico de usuario")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La dirección es requerida")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La dirección debe tener entre 3 y 50 caracteres")]
        [Display(Name = "Dirección", Prompt = "Ingrese su dirección",
                                 Description = "Dirección de usuario")]
        public string Address { get; set; }

        [Required(ErrorMessage = "El teléfono es requerido")]
        [StringLength(10, MinimumLength = 7, ErrorMessage = "El teléfono debe tener entre 7 y 10 caracteres")]
        [Display(Name = "Teléfono", Prompt = "Ingrese su teléfono",
                                            Description = "Teléfono de usuario")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "El contacto es requerido")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "El contacto debe tener entre 3 y 200 caracteres")]
        [Display(Name = "Contacto", Prompt = "Ingrese su dirección de contacto o nombre de contacto",
                                                       Description = "Contacto de usuario")]
        public string ContactAddressOrContactName { get; set; }
    }
}
