using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int acumulador = 0;

            while (contador <= 5)
            {
                acumulador += contador;
                Console.WriteLine($"Contador: {contador} - Acumulador: {acumulador}");
                contador++;
            }

            Console.WriteLine($"La suma de los cinco primero números enteros es: {acumulador}");*/

            // Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1*2*3*4*5)

            int contador = 1;
            int acumulador = 1;
            int numero = 0;

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            while (contador <= numero)
            {
                Console.WriteLine($"Contador: {contador} - Acumulador: {acumulador}");
                acumulador *= contador;
                contador++;
            }

            Console.WriteLine($"el factorial de {numero}: {acumulador}");
        }
    }
}
