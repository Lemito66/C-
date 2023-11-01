using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList employeers = new ArrayList();
            //List<Employeer> employeers1 = new List<Employeer>(); // Otra forma de hacerlo

            //Employeer employeer = new Employeer("Ivan", 25, "Mascota", 33333);

            employeers.Add(new Employeer("Ivan", 25, "Mascota", 33333));
            employeers.Add(new Employeer("Emill", 25, "Mascota", 33333));
            employeers.Add(new Employeer("House", 25, "Mascota", 33333));

            //Console.WriteLine(employeers);
            /*foreach (Employeer item in employeers)
            {
                Console.WriteLine(item.Name.ToString());
            } */


            // Iterate over the ArrayList using a for loop
            for (int i = 0; i < employeers.Count; i++)
            {
                Employeer employee = (Employeer)employeers[i];
                Console.WriteLine($"Employee name: {employee.Name}");
                // change name 
                employee.Name = "Changed";
                for (int j = 0; j < employeers.Count; j++)
                {
                    Employeer employeer = (Employeer)employeers[i];
                    Console.WriteLine($"Employee name: {employeer.Name}");
                    // change name 
                    //employee.Name = "Changed";
                }
            }

            Console.WriteLine();
            Console.ReadKey();





        }
    }
}
