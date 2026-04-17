using System;

namespace _19.Arreglos_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*// Declaración e inicialización de matrices
            int[,] numeros = new int[2,3]; // r = #f x #c
            numeros[0, 0] = 13;
            numeros[0, 1] = 65;
            numeros[0, 2] = 0;
            numeros[1, 0] = 45;
            numeros[1, 1] = 100;
            numeros[1, 2] = 29;

            string[,] nombres =
            {
                {"Ferney", "Juan"},
                {"Maria", "Esteban"},
                {"Álvaro", "Carlos"}
            };
            // Recorrer matriz para llenarla
            char[,] simbolos = new char[2, 5];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)//Recorre las columnas
                {
                    Console.WriteLine($"Ingrese el valor para la matriz[{i},{j}]:");
                    simbolos[i, j] = char.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            //Recorrer matriz para recuperar datos
            for (int i = 0; i < simbolos.GetLength(0); i++)//GetLength(0) devuelve el # de filas
            {
                for (int j = 0; j < simbolos.GetLength(1); j++)//GetLength(1) devuelve el # de columnas
                {
                    Console.Write($"{simbolos[i, j]} | ");
                }
                Console.WriteLine();
            }*/

            // Escribe un programa que realice la suma de dos matrices de dimensiones 2x3
            // Requisitos del programa:
            // Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas.
            // Solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones(2x3).
            // Calcula la matriz suma, resultado de sumar cada elemento correspondiente de las fos matrices.
            // Muestra la matriz resultante de la suma en formato de matriz (2 filas, 3 columnas).

            /*int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];

            int[,] suma = new int[2, 3];

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el valor para la matriz1[{i},{j}]:");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el valor para la matriz2[{i},{j}]:");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();

            for (int i = 0; i < suma.GetLength(0); i++)
            {
                for (int j = 0; j < suma.GetLength(1); j++)
                {
                    suma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            for (int i = 0; i < suma.GetLength(0); i++)
            {
                for (int j = 0; j < suma.GetLength(1); j++)
                {
                    Console.Write($"{suma[i, j]} | ");
                }
                Console.WriteLine();
            }*/

            // Desarrolla un algoritmo que realice las siguientes tareas:
            // Capturar los nombres de cuatro empleados ingresados por teclado.
            // Para cada empleado, capturar los sueldos recibidos durante los últimos 3 meses.
            // Calcular y mostrar el total acumulado de sueldos que ha recibido cada empleado en ese periodo.
            // Identificar y mostrar el nombre del empleado con el mayor sueldo acumulado, junto con el monto total que recibió.

            const int empleados = 4;
            const int meses = 3;

            string[] nombres = new string[empleados];
            int[,] saldos = new int[empleados, meses];

            Console.WriteLine("Ingrese los nombres de sus empleados");
            for (int i = 0; i < empleados; i++)
            {
                nombres[i] = Console.ReadLine();
            }
        }
    }
}
