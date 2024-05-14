using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        int a;
        int b;

        a = 10;
        b = a;

        Console.WriteLine("valor de a: " + a);
        Console.WriteLine("valor de b: " + b);

        // Ejercicio 1
        Console.WriteLine("Ingrese un número para invertirlo:");
        int numero;
        if (int.TryParse(Console.ReadLine(), out numero))
        {
            if (numero > 0)
            {
                int numeroInvertido = InvertirNumero(numero);
                Console.WriteLine($"El numero invertido es: {numeroInvertido}");
            }
            else
            {
                Console.WriteLine("El numero ingresado no es mayor a cero");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero válido.");
        }

        // Ejercicio 2
Console.WriteLine("Seleccione qué operación desea realizar:\n1-Suma\n2-Resta\n3-Multiplicar\n4-Dividir");
string inputOperacion = Console.ReadLine();

Console.WriteLine("Ingrese el primer número");
string inputNum1 = Console.ReadLine();
Console.WriteLine("Ingrese el segundo número");
string inputNum2 = Console.ReadLine();

int num1, num2, operacion;
bool operacionValida = int.TryParse(inputOperacion, out operacion);
bool num1Valido = int.TryParse(inputNum1, out num1);
bool num2Valido = int.TryParse(inputNum2, out num2);

if (operacionValida && num1Valido && num2Valido)
{
    int resultado = 0;

    switch (operacion)
    {
        case 1:
            resultado = num1 + num2;
            break;
        case 2:
            resultado = num1 - num2;
            break;
        case 3:
            resultado = num1 * num2;
            break;
        case 4:
            if (num2 != 0)
                resultado = num1 / num2;
            else
                Console.WriteLine("No se puede dividir por cero.");
            break;
        default:
            Console.WriteLine("Seleccione una operación válida");
            break;
    }

    Console.WriteLine("Resultado = " + resultado);
}
else
{
    Console.WriteLine("Entrada inválida. Por favor, ingrese números enteros válidos para la operación y los números.");
}


    }

    // Metodo para invertir un número
    static int InvertirNumero(int num)
    {
        while (num > 0)
        {
            num = num * (-1);
        }
        return num;
    }
}


