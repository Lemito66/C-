// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int flag = 0;
//double monthSales = 5000;
double monthSales = 0;
Console.WriteLine("Cual es la venta de este mes?");
monthSales = int.Parse(Console.ReadLine()); // Transformamos el valor de string a int
const double goalSales = 1000;

if (monthSales < goalSales)
{
    Console.WriteLine("No se logro la meta");
}
else
{
    Console.WriteLine("Se logro la meta");
}