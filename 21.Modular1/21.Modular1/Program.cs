using System;

namespace _21.Modular1
{
    internal class Program
    {
        // 21. Algoritmo que muestre un menú con operaciones (+,-,*,/) y permita realizar la operación que el usuario ingrese por teclado. Si es suma o multiplicación, permitirle al usuario realizar estas operaciones con la cantidad de números que el desee ingresar. Si es división o resta solo dejar realizar la operación con dos números.
        static void Main(string[] args)
        {
            MostrarMenu();
            int opcion = CapturarOpcion();
            RealizarOperacion(opcion);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("-----------------MENÚ-------------------");
            Console.WriteLine("   1. Suma              2. Resta");
            Console.WriteLine("   3. multiplicación    4. Division");
            Console.WriteLine("----------------------------------------");
        }

        static int CapturarOpcion()
        {
            Console.WriteLine("Ingrese una opción del menú:");
            return int.Parse(Console.ReadLine());
        }
        static void BorrarPantalla()
        {
            Console.Clear();
        }

        static void RealizarOperacion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Suma();
                    break;
                case 2:
                    Resta();
                    break;
                case 3:
                    Multiplicacion();
                    break;
                case 4:
                    Division();
                    break;
                default:
                    Console.WriteLine("Ingrese una opción válida del menú");
                    break;
            }
        }

        private static void Division()
        {
            Console.WriteLine("Usted va a dividir");
        }

        private static void Multiplicacion()
        {
            Console.WriteLine("Usted va a multiplicar");
        }

        private static void Resta()
        {
            Console.WriteLine("Usted va a restar");
        }

        static void Suma()
        {
            Console.WriteLine("Usted va a sumar");
        }
    }
}
