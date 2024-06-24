using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        while (true)
        {
            Console.WriteLine("Presiona Enter para lanzar los dados o escribe 'salir' para salir:");
            string input = Console.ReadLine();

            if (input.ToLower() == "salir")
            {
                Console.WriteLine("¡Hasta luego!");
                break;
            }

            int dado1 = random.Next(1, 7);
            int dado2 = random.Next(1, 7);

            Console.WriteLine($"Dado 1: {dado1}");
            Console.WriteLine($"Dado 2: {dado2}");

            int suma = dado1 + dado2;
            Console.WriteLine($"Suma de los dados: {suma}");
        }
    }
}
