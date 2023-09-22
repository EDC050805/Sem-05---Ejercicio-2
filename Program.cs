// See https://aka.ms/new-console-template for more information

Console.WriteLine("\tLogaritmo para hallar la potencia de un número");
Console.WriteLine("\t----------------------------------------------\n");
Console.Write("Ingrese la base: ");
float bas = float.Parse(Console.ReadLine());
Console.Write("Ingrese el exponente: ");
int exponente = int.Parse(Console.ReadLine());
double potencia = bas;

if (exponente >= 0)
{
    if (exponente == 0)
    {
        potencia = 1;
    }
    else
    {
        for (int i = 1; i < exponente; i++)
        {
            potencia *= bas;
        }
    }
}
else
{
    Console.WriteLine("¡Error! Este algoritmo funciona solo con exponentes iguales o mayores a cero");
    Console.ReadKey();
    return;
}

Console.WriteLine("La potencia es: " + potencia);
Console.ReadKey(); 
