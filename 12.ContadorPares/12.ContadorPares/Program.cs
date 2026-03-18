using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ContadorPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 12. Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n.

            /*int contador = 1;
            float acumulador = 0f;

            int numeroMaximo = 0;

            Console.WriteLine("¿Hasta que número le gustaría contar?");
            numeroMaximo = int.Parse(Console.ReadLine());

            while (contador <= numeroMaximo)
            {
                acumulador += 0.5f;
                contador++;
            }
           *//*int resultado = (int)acumulador;
            Math.Truncate(acumulador);*//*

            Console.WriteLine($"Hay {(int)acumulador} números pares entre 1 y {numeroMaximo}");*/

            // Otra forma

            int n = 0;
            Console.WriteLine("¿Hasta que número le gustaría contar?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hay {(int)(n/2)} números pares entre 1 y {n}");

        }
    }
}
