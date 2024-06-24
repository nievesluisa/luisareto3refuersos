using System;

class Programa
{
    static bool EsPrimo(int numero)
    {
        if (numero < 2)
            return false;

        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Ingresa el inicio del rango: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el fin del rango: ");
        int fin = int.Parse(Console.ReadLine());

        Console.WriteLine("Números primos en el rango:");

        for (int num = inicio; num <= fin; num++)
        {
            if (EsPrimo(num))
                Console.WriteLine(num);
        }
    }
}
