using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClienteDemoForms
{
    internal class Products
    {
        public Products (int id, string name, double price, int stocks)
        {
            // Este es el constructor, siempre debe tener el mismo nombre de la clase
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Stocks = stocks;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stocks { get; set; }

    }
}
