using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float n, conPrimo = 0, acuNumeros = 0, promedio;

            Console.WriteLine("Ingrese un número: ");
            n = float.Parse(Console.ReadLine());

            while (n != 0)
            {
                if (primo(n))
                {
                    conPrimo++;
                    acuNumeros += n;
                }

                Console.WriteLine("Ingrese un número: ");
                n = float.Parse(Console.ReadLine());
            }   

            promedio = acuNumeros / conPrimo;

            Console.WriteLine("El promedio de números primos es: " + promedio.ToString("0.00"));
            
        }

        static bool primo(float n)
        {
            int conDivisor = 0;

            for (int x = 1; x <= n; x++)
            {
                if (n % x == 0 )
                    conDivisor++;
            } 

            if (conDivisor == 2)
                return true;
            else 
                return false;    
        }
    }
}
