// See https://aka.ms/new-console-template for more information
using Variables;

Console.WriteLine("Hello, World!");

// Declarando la variable
int salary = 1000;
int bonus = 200;


// Impresion de las variables
Console.WriteLine("El salario del trabajador es: "+ salary + bonus);
// Corregir el error de arriba 
Console.WriteLine("El salario del trabajador es: "+ (salary + bonus));

Employee empleado = new Employee();
empleado.Name = "Juan";
Console.WriteLine(empleado.CompleteName());




