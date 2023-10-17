using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Employee
        /// <summary>
        /// Todas las clases tienen por dentro propiedades, métodos y eventos
        /// 
    {
        public Employee()
        {
            Console.WriteLine("Codigo desde el constructor");
        }
        public string Name { get; set; }

        public string CompleteName()
        {
            return this.Name.ToString() + " Completo";
        }
    }
}
