using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGeneric
{
    internal class Person
    {
        
        public string Name { get; set; }
        public int Age { get; set; }

        // Hacer una función que devuelva un string
        public string writeValue()
        {
            return Name + " " + Age;
        }
        
    }
}
