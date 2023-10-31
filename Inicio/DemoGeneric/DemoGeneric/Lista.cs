using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGeneric
{
    public class Lista<T> // El T sirve para decir que está clase tiene un generico
    {
        T valor; // asignamos el generico a una variable
        public Lista(T valor) // le pasamos el generico a un constructor
        {
            this.valor = valor; 

        }

        public void writeValue()
        {
            Debug.WriteLine(valor);
        }
    }
}
