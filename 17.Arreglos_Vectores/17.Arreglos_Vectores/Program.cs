using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace _17.Arreglos_Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numeros = new int[5]; // El rango de este vector es 5
            numeros[0] = 12;
            numeros[1] = 13;
            numeros[2] = 42;
            numeros[3] = 201;
            numeros[4] = 0;
            // numeros[5] = 1; la posición 6 con índice 5 no existe, porque el rango del vector es 5
            Console.WriteLine($"El valor almacenado en la posición 3, con índice 2 es: {numeros[2]}");

            // Recorrer el vector para llenarlo

            string[] nombres = new string[5];

            for ( int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Ingrese el nombre para guardar en la posición {i+1} con índice {i}");
                nombres[i] = Console.ReadLine();
            }

            char[] simbolos = new char[] { '#', '%', '?', '|', 'Q', 'ñ', '&', '9', '*'};

            // Recorrer vector para recuperar los datos almacenados en él
            Console.Clear();
            for ( int i = 0;i < simbolos.Length;i++)
            {
                Console.Write(simbolos[i] + " | ");
            }*/

            // Crear un arreglo llamado "numeros" de 100 elementos asignar el número 10 en cada una de las posiciones del arreglo. Leer el contenido de cada elemento y escribirlo en pantalla.

            /*int[] numeros = new int[100];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 10;
            }

            for (int i = 0;i < numeros.Length; i++)
            {
                Console.WriteLine($"El número guardado en la posición {i+1} con índice {i} es {numeros[i]}");
            }*/

            // Llene un arreglo con 15 números ingresados por teclado. Una vez registrado el total de valores, muestre en pantalla todos los elementos del arreglo. Finalmente, determine cuál es el número mayor y cuál es el número menor, junto con la posición que ocupa cada uno dentro del arreglo.

            int[] numeros = new int[15];

            int mayor = 0;
            int menor = 0;
            int posicionMayor = 0;
            int posicionMenor = 0;


            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese el número {i + 1}");
                numeros[i] = int.Parse(Console.ReadLine());

            }

            mayor = numeros[0];
            menor = numeros[0];

            Console.WriteLine();

            Console.WriteLine("Los números ingresados fueron:");
            for (int i = 1; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);

                if (numeros[i]>mayor)
                {
                    mayor = numeros[i];
                    posicionMayor = i;
                }
                else if (numeros[i]<menor)
                {
                    menor = numeros[i];
                    posicionMenor = i;
                }
            }

            Console.WriteLine();

            Console.WriteLine($"El número mayor fue {mayor} en la posicion {posicionMayor + 1}");
            Console.WriteLine($"El número menor fue {menor} en la posicion {posicionMenor + 1}");

        }
    }
}
