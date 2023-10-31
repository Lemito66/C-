using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGeneric
{
    internal class Employeer : Person
    {
        public double Salary { get; set; }

        public string writeSalary()
        {
            return Name + " " + Age + " " + Salary;
        }
    }
}
