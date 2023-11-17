using System.ComponentModel.DataAnnotations;

namespace StudentsApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [Required]
        public string Name { get; set; }
        [Required]
        public int age { get; set; }
    }
}
