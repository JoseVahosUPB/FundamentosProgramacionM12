using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SumaHastaNegativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            int numero = 0;

            Console.WriteLine("Ingrese un número entero positivo");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                acumulador += numero;
                Console.WriteLine("Ingrese un número entero positivo");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"La suma de los números ingresados es {acumulador}");
        }
    }
}
