using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoForms
{
    internal class Employeer
    {
        /*
        public Employeer(string name, int age, double salary){

            // dar propiedades a los atributos
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
        }

        */

        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        // Hacer un metodo para aumentar el salario
        public void IncreaseSalary(double percentage)
        {
            this.Salary += this.Salary * percentage / 100;
        }
    }
}
