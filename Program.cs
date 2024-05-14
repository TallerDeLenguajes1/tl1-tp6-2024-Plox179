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


