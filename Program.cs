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
}
else
{
    Console.WriteLine("Numero ingresado no valido");
}

float num1, num2, result = 0;
int opcion, operacion = 0;
bool p;
string? aux;
while (operacion == 0)
{

    do
    {
        Console.WriteLine("0:Multiplicacion 1:Divicion 2:Resta 3:Suma");
        aux = Console.ReadLine();
        p = int.TryParse(aux, out opcion);
        if (!p)
        {
            Console.WriteLine("Numero ingresado no valido");
        }
    } while (!p);

    do
    {
        Console.WriteLine("Ingrese el primer numero: ");
        aux = Console.ReadLine();
        p = float.TryParse(aux, out num1);
        if (!p)
        {
            Console.WriteLine("Numero ingresado no valido");
        }
    } while (!p);
    do
    {
        Console.WriteLine("Ingrese el segundo numero: ");
        aux = Console.ReadLine();
        p = float.TryParse(aux, out num2);
        if (!p)
        {
            Console.WriteLine("Numero ingresado no valido");
        }
        if (opcion == 1 && num2 == 0 && p)
        {
            Console.WriteLine("No se puede dividir entre 0");
            p = false;
        }
    } while (!p);

    switch (opcion)
    {
        case 0:
            result = num1 * num2;
            break;
        case 1:
            result = num1 / num2;
            break;
        case 2:
            result = num1 - num2;
            break;
        case 3:
            result = num1 + num2;
            break;
        default:
            break;
    }
    Console.WriteLine($"El resultado de la operacion es: {result}");
    do
    {
        Console.WriteLine("iNGRESE 0 PARA CONTINUAR CON OTRA OPERACION: ");
        aux = Console.ReadLine();
        p = int.TryParse(aux, out operacion);
        if (!p)
        {
            Console.WriteLine("Numero ingresado no valido");
        }
    } while (!p);
}