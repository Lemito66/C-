using System.ComponentModel.DataAnnotations;

namespace webAppCore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string?   Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }
    }
}
