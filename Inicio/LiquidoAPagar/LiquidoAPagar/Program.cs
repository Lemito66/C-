// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Crear un programa para calcular liquido a pagar
// Liquido a pagar = Salario Base + Otros Ingresos - Descuentos + Bono

/*
 * Tipo Empleado:
 * 1. Operario
 * 2. Administrativo
 * 3. Ventas
 * Bono:
 * Tipo Empleado es operario bono es del 10% del salario base
 * Tipo Empleado es Administrativo Bono es del 5% del salario base
 * Tipo Empleado es Ventas Bono es del 25% del salario base
 
 */

// Declaracion de variables
char continuar;

do
{
    int tipoEmpleado = 0;
    do
    {
        Console.WriteLine("Ingrese el tipo de empleado (1, 2 o 3)");
        tipoEmpleado = int.Parse(Console.ReadLine());

        if (!(tipoEmpleado == 1 || tipoEmpleado == 2 || tipoEmpleado == 3))
        {
            Console.WriteLine("El tipo de empleado debe ser 1, 2 o 3");
        }

    } while (!(tipoEmpleado == 1 || tipoEmpleado == 2 || tipoEmpleado == 3));

    double salarioBase, otrosIngresos, descuentos, bono = 0, liquidoPagar = 0;

    Console.WriteLine("Ingrese el salario base");
    salarioBase = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese otros ingresos");
    otrosIngresos = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese descuentos");
    descuentos = double.Parse(Console.ReadLine());

    if (tipoEmpleado == 1)
    {
        bono = salarioBase * 0.10;
    }
    else if (tipoEmpleado == 2)
    {
        bono = salarioBase * 0.05;
    }
    else if (tipoEmpleado == 3)
    {
        bono = salarioBase * 0.25;
    }

    liquidoPagar = salarioBase + otrosIngresos - descuentos + bono;

    Console.WriteLine("El liquido a pagar es de: " + liquidoPagar.ToString("C"));

    Console.WriteLine("¿Desea continuar? (s/n)");
    continuar = Console.ReadLine()[0]; 

} while (continuar == 's' || continuar == 'S');
