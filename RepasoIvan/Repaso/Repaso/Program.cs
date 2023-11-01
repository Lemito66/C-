// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

int a = 10;
int b = 20;



static int Suma(int a, int b)
{
    return a + b;
}

// arreglo 
int[] arreglo = new int[10];

// arreglo de 10 elementos
int[] arreglo2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

ArrayList myArray = new ArrayList();

myArray.Add(1);
myArray.Add("hola");

foreach(var item in myArray)
{
    Console.WriteLine(item);
}