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

int opcion = 0, operacion = 0;
float num, result;
string? aux;
bool p;
while (operacion == 0)
{
    do
    {
        Console.WriteLine("0: Valor absoluto 1: Cuadrado de un numero 2: Raiz cuadrada 3: seno de un numero 4: coseno de un numero 5: parte entera de un numero ");
        aux = Console.ReadLine();
        p = int.TryParse(aux, out opcion);
        if (!p)
        {
            Console.WriteLine("Numero ingresado no valido");
        }
        if (opcion < 0 || opcion > 5)
        {
            Console.WriteLine("Numero ingresado fuera de rango");
            p = false;
        }
    } while (!p);

    do
    {
        Console.WriteLine("Seleccione un numero para trabajar: ");
        aux = Console.ReadLine();
        p = float.TryParse(aux, out num);
        if (!p)
        {
            Console.WriteLine("Numero ingresado no valido");
        }
        if (opcion == 2 && num < 0)
        {
            Console.WriteLine("La raiz cuadrada solo trabaja con numeros positivos");
            p = false;
        }
    } while (!p);

    switch (opcion)
    {
        case 0:
            result = Math.Abs(num);
            break;
        case 1:
            result = num * num;
            break;
        case 2:
            result = (float)Math.Sqrt(num);
            break;
        case 3:
            result = (float)Math.Sin(num);
            break;
        case 4:
            result = (float)Math.Cos(num);
            break;
        case 5:
            result = (int)num;
            break;
        default:
            result = 0;
            break;
    }
    Console.WriteLine($"El resultado de la operacion es: {result}");
    do
    {
        Console.WriteLine("Seleccione 0 para realizar otra operacion: ");
        aux = Console.ReadLine();
        p = int.TryParse(aux, out operacion);
        if (!p)
        {
            Console.WriteLine("Numero ingresado no valido");
        }
    } while (!p);


}
float num1, num2;
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
} while (!p);
if (num1 == num2)
{
    Console.WriteLine("Ambos numeros son iguales");
}
else if (num1 > num2)
{
    Console.WriteLine($"El numero {num1} es mayor");
}
else
{
    Console.WriteLine($"El numero {num2} es mayor");
}