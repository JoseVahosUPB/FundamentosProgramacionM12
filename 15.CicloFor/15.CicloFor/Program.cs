using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int acumulador = 0;

            for (int contador = 1; contador <= 5; contador++)
            {
                acumulador += contador;
            }

            Console.WriteLine($"La suma de los cinco primeros números enteros es {acumulador}");*/

            // Realizar un programa que permita obtener la factorial de un numero entero ingresado por el teclado

            /*int acumulador = 1;
            int numero = 0;

            Console.WriteLine("Ingrese un número para obtener su factorial");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                acumulador *= i;
            }

            Console.WriteLine($"{numero}! = {acumulador}");*/

            // Realizar un programa que permita imprimir por pantalla los números múltiplos de de 5, el usuuario debe ingresar por el teclado el rango de números a evaluar

            /*int limiteSuperior = 0;
            int limiteInferior = 0;

            Console.WriteLine("Este algoritmo mostrará los números múltiplos de 5 en cierto rango");
            Console.WriteLine("Ingrese el limite inferior del rango");
            limiteInferior = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número superior del rango");
            limiteSuperior = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Los números múltiplos de 5 en [{limiteInferior},{limiteSuperior}] son: ");

            for (int i = limiteInferior; i <= limiteSuperior; i++)
            {
                if (i%5 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            // En un grupo de 100 alumnos, se desea saber cuántos de los estudiantes son hombres y cuántos son mujeres, además se desea saber cuántos son mayores de edad y cuántos no.

            string genero = "";
            int edad = 0;
            int hombres = 0;
            int mujeres = 0;
            int mayores = 0;

            Console.WriteLine("Usted se va a poner a ingresar los géneros y edades de 100 estudiantes, que le rinda:");

            for (int contador = 1; contador <= 100; contador++)
            {
                Console.WriteLine($"Ingrese el género del estudiante {contador}");
                genero = Console.ReadLine().ToLower();
                Console.WriteLine($"Ingrese la edad del estudiante {contador}");
                edad = int.Parse(Console.ReadLine());

                if (genero == "hombre")
                {
                    hombres++;
                }
                else if (genero == "mujer")
                {
                    mujeres++;
                }

                if (edad >= 18)
                {
                    mayores++;
                }
            }

            Console.WriteLine($"Entre sus estudiantes hay {hombres} hombres, {mujeres} mujeres y {mayores} mayores de edad");
        }
    }
}
