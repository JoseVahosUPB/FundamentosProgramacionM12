using System;
using System.Data;

namespace Parcial3_Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Bosquejo del formato de impresión del tablero
             * ---------------------------------
             * | X | X | X | X | X | X | X | X |
             * ---------------------------------
             * | X | X | X | X | X | X | X | X |
             * ---------------------------------
             * | X | X | X | X | X | X | X | X |
             * ---------------------------------
             * | X | X | X | X | X | X | X | X |
             * ---------------------------------
             * | X | X | X | X | X | X | X | X |
             * ---------------------------------
             * | X | X | X | X | X | X | X | X |
             * ---------------------------------
             * | X | X | X | X | X | X | X | X |
             * ---------------------------------
             * | X | X | X | X | X | X | X | X |
             * ---------------------------------
             */

            char[,] tableroReferencia =
            {
                {'T', 'C', 'A', 'D', 'R', 'A', 'C', 'T'},
                {'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p'},
                {'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X'},
                {'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X'},
                {'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X'},
                {'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X'},
                {'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p'},
                {'T', 'C', 'A', 'D', 'R', 'A', 'C', 'T'}
            };

            char[,] tablero =
            {
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '}
            };

            char intento = ' ';

            // Fichas válidas
            Console.WriteLine("Le voy a ayudar a memorizar las ubicaciones de las piezas en el tablero de ajedrez, tenga en cuenta la siguiente notación:");
            Console.WriteLine("Rey           (R)");
            Console.WriteLine("Dama/Reina    (D)");
            Console.WriteLine("Torre         (T)");
            Console.WriteLine("Alfil         (A)");
            Console.WriteLine("Caballo       (C)");
            Console.WriteLine("Peón          (p)");
            Console.WriteLine("Casilla vacía (X)");
            Console.WriteLine("¿Entendido?");
            Console.ReadKey();
            Console.Clear();

            // Pregunta por cada casilla
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    // Establecer la casilla activa
                    tablero[i, j] = 'o';

                    do
                    {
                        Console.WriteLine("¿Qué ficha va en esta posición?");
                        // Mostrar el estado del tablero
                        for (int k = 0; k < 8; k++)
                        {
                            Console.WriteLine("---------------------------------");
                            Console.Write("| ");
                            for (int l = 0; l < 8; l++)
                            {
                                Console.Write($"{tablero[k, l]} | ");
                            }
                        Console.WriteLine();
                        }
                        Console.WriteLine("---------------------------------");

                        // Pedir ingresar un valor
                        intento = char.Parse(Console.ReadLine());

                        // VALIDACIONES 
                        if (intento != 'R' && intento != 'D' && intento != 'T' && intento != 'A' && intento != 'C' && intento != 'p' && intento != 'X') // Validación notación correcta
                        {
                            Console.WriteLine("Esa ficha no existe, verifique la notación y vuelva a intentarlo");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (intento != tableroReferencia[i,j]) // Validación ficha correcta
                        {
                            Console.WriteLine("Esa pieza no va ahí, vuelva a intentarlo");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("CORRECTO");
                            tablero[i, j] = intento;

                            Console.ReadKey();
                            Console.Clear();
                        }

                    } while ((intento != 'R' && intento != 'D' && intento != 'T' && intento != 'A' && intento != 'C' && intento != 'p' && intento != 'X') || (intento != tableroReferencia[i, j]));

                }
            }

            // Impresión final
            Console.WriteLine("¡Su tablero quedó muy bonito!");
            for (int k = 0; k < 8; k++)
            {
                Console.WriteLine("---------------------------------");
                Console.Write("| ");
                for (int l = 0; l < 8; l++)
                {
                    Console.Write($"{tablero[k, l]} | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------");
        }
    }
}
