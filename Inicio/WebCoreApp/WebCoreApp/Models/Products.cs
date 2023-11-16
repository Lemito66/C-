using System.ComponentModel.DataAnnotations;

namespace WebCoreApp.Models
{
    public class Products
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string? Name { get; set; }
    }
}
