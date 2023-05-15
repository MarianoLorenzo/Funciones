using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, variable = 0;

            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());

            positivoNegativoCero(n, ref variable);

        }

        static void positivoNegativoCero(int n, ref int variable)
        {
            if (n > 0)
                variable = 1;
            else if (n < 0)
                variable = -1;
            else 
                variable = 0;

            Console.WriteLine("El estado del valor es: " + variable); 

        }
    }
}
