using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contadorPares = 0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());

                if (par(n) == 1)
                    contadorPares++;
            }

            Console.WriteLine("La cantidad de números pares es: " + contadorPares);

        }

        static int par(int n)
        {
            if (n % 2 == 0)
                return 1;
            else 
                return 0;    
        }
    }
}
