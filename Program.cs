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
int opcion1 = 0, operacion1 = 0;
float num, result1;
string? aux1;
bool p1;
while (operacion1 == 0)
{
    do
    {
        Console.WriteLine("0: Valor absoluto 1: Cuadrado de un numero 2: Raiz cuadrada 3: seno de un numero 4: coseno de un numero 5: parte entera de un numero ");
        aux1 = Console.ReadLine();
        p1 = int.TryParse(aux1, out opcion1);
        if (!p1)
        {
            Console.WriteLine("Numero ingresado no valido");
        }
        if (opcion1 < 0 || opcion1 > 5)
        {
            Console.WriteLine("Numero ingresado fuera de rango");
            p1 = false;
        }
    } while (!p1);

    do
    {
        Console.WriteLine("Seleccione un numero para trabajar: ");
        aux1 = Console.ReadLine();
        p1 = float.TryParse(aux1, out num);
        if (!p1)
        {
            Console.WriteLine("Numero ingresado no valido");
        }
        if (opcion1 == 2 && num < 0)
        {
            Console.WriteLine("La raiz cuadrada solo trabaja con numeros positivos");
            p1 = false;
        }
    } while (!p1);

    switch (opcion1)
    {
        case 0:
            result1 = Math.Abs(num);
            break;
        case 1:
            result1 = num * num;
            break;
        case 2:
            result1 = (float)Math.Sqrt(num);
            break;
        case 3:
            result1 = (float)Math.Sin(num);
            break;
        case 4:
            result1 = (float)Math.Cos(num);
            break;
        case 5:
            result1 = (int)num;
            break;
        default:
            result1 = 0;
            break;
    }
    Console.WriteLine($"El resultado de la operacion es: {result1}");
    do
    {
        Console.WriteLine("Seleccione 0 para realizar otra operacion: ");
        aux1 = Console.ReadLine();
        p1 = int.TryParse(aux1, out operacion1);
        if (!p1)
        {
            Console.WriteLine("Numero ingresado no valido");
        }
    } while (!p1);


}
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
Console.WriteLine("Ingrese una palabra: ");
string? palabra = Console.ReadLine();
if (palabra != null)
{
    int palabraLong = palabra.Length;
    Console.WriteLine($"La longitud de la cadena es: {palabraLong}");
}
Console.WriteLine("Ingrese otra palabra: ");
string? palabra1 = Console.ReadLine();
if (palabra != null && palabra1 != null)
{
    string Unida = $"{palabra}{palabra1}";
    Console.WriteLine($"La palabra concatenada es: {Unida}");
    string? sub = Unida.Substring(0, 2);
    Console.WriteLine($"Sub cadena: {sub}");

    Console.WriteLine("Ingrese un caracter: ");
    string? letra = Console.ReadLine();
    if (letra != null)
    {
        string[] separado = Unida.Split(letra);
        Console.WriteLine($"Sub cadena 1: {separado[0]} Sub cadena 2: {separado[1]}");
    }
    Console.WriteLine("Ingrese un caracter: ");
    char? c = Console.ReadLine()[0];
    int frecuencia = 0;
    foreach (char x in Unida)
    {
        if (x == c)
        {
            frecuencia++;
        }
        Console.WriteLine(x);
    }
    Console.WriteLine($"La cantidad de frecuencia de {c} es {frecuencia}");
    string? Mayuscula = Unida.ToLower();
    string? Minuscula = Unida.ToUpper();
    Console.WriteLine($"La palabra en mayuscula es: {Mayuscula}, La palabra en minuscula es: {Minuscula}");
}
