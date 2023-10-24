// See https://aka.ms/new-console-template for more information

DateTime birthday;
DateTime dateNow = DateTime.Now;
int years;
Console.WriteLine("Ingrese su fecha de nacimiento en el formato dd/mm/yyyy");

if(DateTime.TryParse(Console.ReadLine(), out birthday))
{
    Console.WriteLine("Fecha ingresada de forma correcta");
}
else
{
    Console.WriteLine("El formato de fecha es incorrecto");
}

years = dateNow.Year - birthday.Year;

if(birthday.Month == dateNow.Month)
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

Console.WriteLine("Su edad es de: " + years.ToString() + " años");