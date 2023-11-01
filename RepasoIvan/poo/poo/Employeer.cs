using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    internal class Employeer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int Telephone { get; set; }
        

        public Employeer(string name, int age, string address, int telephone) { 
            this.Name = name;
            this.Age = age;
            this.Address = address;
            this.Telephone = telephone;

            
        }

    }
}
