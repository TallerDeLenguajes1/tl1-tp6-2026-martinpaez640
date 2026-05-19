Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);
Console.WriteLine("Ingrese un numero: ");
string? entrada = Console.ReadLine();
int i = 0, resultado = 0;
if (int.TryParse(entrada, out i))
{
    if (i > 0)
    {
        while (i > 0)
        {
            resultado = resultado * 10 + i % 10;
            i /= 10;
        }
        Console.WriteLine($"El resultado del numero invertido es:  {resultado}");
    }
    else
    {
        Console.WriteLine("El numero debe de ser mayor a 0");
    }
}else
{
    Console.WriteLine("Numero ingresado no valido");
}

