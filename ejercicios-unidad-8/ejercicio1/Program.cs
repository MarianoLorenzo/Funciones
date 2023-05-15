using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio, cantidad, resultado;

            Console.WriteLine("Ingrese el precio del artículo: ");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidad = int.Parse(Console.ReadLine());

            resultado = producto(precio, cantidad);
            Console.WriteLine("Monto total a pagar: $" + resultado);
        }

        static int producto(int precio, int cantidad)
        {
            return precio * cantidad;
        }
    }
}
