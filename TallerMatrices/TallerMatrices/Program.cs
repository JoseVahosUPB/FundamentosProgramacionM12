using System;
using System.IO;

namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por pantalla la suma de los elementos de cada columna.

            /*int[,] numeros =
            {
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}
            };

            int suma = 0;

            for (int i = 0; i < numeros.GetLength(1); i++)
            {
                for (int j = 0; j < numeros.GetLength(0); j++)
                {
                    suma += numeros[j, i];
                }
                Console.WriteLine($"La suma de los elementos de la columna {i+1} es {suma}");
                suma = 0;
            }*/

            // 2. Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa caracteres en cada posición de la matriz hasta llenarla.El programa debe intercambiar la primera fila con la última fila de la matriz.Al final se debe imprimir la matriz original, y la matriz con el intercambio de filas. 

            /*int n = 0;
            int m = 0;

            Console.WriteLine("¿Cuántas filas quiere?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuantas columnas quiere?");
            m = int.Parse(Console.ReadLine());

            char[,] caracteres = new char[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición [{i},{j}]");
                    caracteres[i, j] = char.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("La matriz que usted ingreso fue esta");

            for (int i = 0; i < n; i++)
            {
                Console.Write("{");
                for (int j = 0; j < m - 1; j++)
                {
                    Console.Write($"{caracteres[i, j]}, ");
                }
                Console.WriteLine(caracteres[i,m-1]+"}");
            }

            Console.WriteLine();

            Console.WriteLine("La matriz con la primera y última fila intercambiadas es");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{" + caracteres[i, m - 1]+", ");
                for (int j = 1; j < m-1; j++)
                {
                    Console.Write($"{caracteres[i, j]}, ");
                }
                Console.WriteLine(caracteres[i, 0] + "}");
            }*/

            // 3. Crear una matriz que cuente la frecuencia de cada número del 1 al 10 en una matriz de 5x5 llena de números aleatorios.
            // *El algoritmo debe permitir:*
            //  Usa la función Random para generar los números aleatorios.
            //  Crea un arreglo adicional para almacenar la frecuencia de cada número.
            //  mostrar la matriz y el nuevo arreglo con la frecuencia de cada número

            /*Random rnd = new Random();

            int[,] numeros = new int[5, 5];
            int[] frecuencia = new int[10];

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    numeros[i, j] = rnd.Next(1, frecuencia.Length+1);
                    frecuencia[numeros[i, j] - 1]++;
                }
            }

            Console.WriteLine("El arreglo generado fue:");

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                Console.Write("{");
                for (int j = 0; j < numeros.GetLength(1)-1; j++)
                {
                    Console.Write($"{numeros[i, j]}, ");
                }
                Console.WriteLine(numeros[i, numeros.GetLength(1) - 1] + "}");
            }

            Console.WriteLine();

            for (int i = 0; i < frecuencia.Length; i++)
            {
                Console.WriteLine($"La frecuencia del {i + 1} fue: {frecuencia[i]}");
            }*/

            // 4. Crea un algoritmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X" en posiciones aleatorias. Luego, el algoritmo debe permitir al usuario intentar adivinar la posición de una "X".
            // *El algoritmo debe permitir:*
            //  Usar la función Random para colocar las "X" en la matriz.
            //  Realizar 3 intentos para ingresar coordenadas y verificar si ha acertado.
            //  Al final sacar un mensaje de éxito o error. Si el mensaje es de éxito mostrar la posición de la X en la matriz. Si elmensaje es de error, mostrar la matriz.

            Random rnd = new Random();

            char[,] tablero = new char[5, 5];
            int filaRandom = 0;
            int columnaRandom = 0;

            for (int i = 0; i < 3; i++)
            {
                filaRandom = rnd.Next(0, tablero.GetLength(0));
                columnaRandom = rnd.Next(0, tablero.GetLength(1));

                while (tablero[filaRandom, columnaRandom] == 'X')
                {
                    filaRandom = rnd.Next(0, tablero.GetLength(0));
                    columnaRandom = rnd.Next(0, tablero.GetLength(1));
                }

                tablero[filaRandom, columnaRandom] = 'X';
            }

        }
    }
}
