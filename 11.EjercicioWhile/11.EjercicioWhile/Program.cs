using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EjercicioWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Realizar un algoritmo que permita obtener la suma de todos los números impares hasta el 99.

            /*int acumulador = 0;
            int contador = 0;

            while (contador < 50)
            {
                //Console.WriteLine($"{acumulador} + {contador * 2 + 1} = {acumulador + contador * 2 + 1}");
                acumulador += contador * 2 + 1;
                contador++;
            }

            Console.WriteLine("La suma de todos los números impares hasta el 99 es: " + acumulador);*/

            // 2. Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir.
            //     a. El algoritmo debe escribir en pantalla:
            //         i. La cantidad de números introducidos que son mayores que 0
            //         ii. La cantidad de números introducidos menores que 0
            //         iii. La cantidad de números introducidos iguales a 0

            int contador = 0;

            int cantidadNumeros = 0;
            int numero = 0;
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;

            Console.WriteLine($"¿Cuántos números desea ingresar?");
            cantidadNumeros = int.Parse(Console.ReadLine());

            while (contador < cantidadNumeros)
            {
                Console.WriteLine($"Ingrese un número");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    positivos++;
                }
                else if (numero < 0)
                {
                    negativos++;
                }
                else
                {
                    ceros++;
                }

                //Console.WriteLine(contador);
                contador++;
            }

            Console.WriteLine("Cantidad de números mayores a 0: " + positivos);
            Console.WriteLine("Cantidad de números menores a 0: " + negativos);
            Console.WriteLine("Cantidad de números iguales a 0: " + ceros);
        }
    }
}
