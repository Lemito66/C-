using System.ComponentModel.DataAnnotations;

namespace apiFinalVerdadero.Models
{
    public class CustomerEL2
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        [StringLength(500)]
        public string Text { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
    }
}
