using System;

namespace _20.ProgramacionModular
{
    internal class Program
    {
        static int añoActual = 2026;

        static void Main(string[] args)
        {
            //Programación modular
            string nombre = "Ferney";
            string apellidos = "Chica Álvarez";
            Console.WriteLine($"Edad: {EdadAñoNacimiento()}");
            Saludo(nombre, apellidos);
            Saludo("Carlos", "Peréz Lopez");
            Console.WriteLine($"Edad: {EdadAñoNacimiento(2001)}");
            Console.ReadKey();
            BorrarPantalla();
        }

        //Procedimientos sin parámetros
        static void BorrarPantalla()
        {
            Console.Clear();
        }

        //Procedimientos con parámetros

        static void Saludo(string nombre, string apellidos)
        {
            Console.WriteLine($"Bienvenido {nombre} {apellidos}, a la programación modular");
        }

        //Funciones sin parámetros
        static int EdadAñoNacimiento()
        {
            int añoNacimiento = 1999;
            int edad = añoActual - añoNacimiento;
            return edad;
        }

        //Funciones con parámetros
        static int EdadAñoNacimiento(int añoNacimiento)
        {
            return añoActual - añoNacimiento;
        }

    }
}
