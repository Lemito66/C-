// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

DateTime birthday;
DateTime dateNow = DateTime.Now;
int years;
// arreglo para almacenar los nombres
string[,] employeers = new string[5,2]; // 5 filas y 2 columnas []
string nameEmployeer;

for (int i = 0; i < 2; i++)
{
    Console.Clear();
    Console.WriteLine("Ingresa el nombre del colaborador número: " + i.ToString() + " ");
    nameEmployeer = Console.ReadLine();
    Console.WriteLine("Ingrese su fecha de nacimiento en el formato dd/mm/yyyy");

    if (DateTime.TryParse(Console.ReadLine(), out birthday))
    {
        Console.WriteLine("Fecha ingresada de forma correcta");
    }
    else
    {
        Console.WriteLine("El formato de fecha es incorrecto");
    }

    years = dateNow.Year - birthday.Year;

    if (birthday.Month == dateNow.Month)
    {
        if (birthday.Day <= dateNow.Day)
        {
            years++;
            if (birthday.Day == dateNow.Day)
            {
                Console.WriteLine("Feliz cumpleaños");
            }
        }
    }
    //Console.WriteLine("Su edad es de: " + years.ToString() + " años");
    employeers[i,0] = nameEmployeer;
    employeers[i,1] = years.ToString();
    Console.WriteLine("Presione una tecla para continuar");
    //Console.Clear();
}

for (int i = 0; i < 2; i++)
{
    Console.WriteLine(employeers[i, 0]);
    Console.Write(" ");
    Console.WriteLine(employeers[i, 1]);
}
