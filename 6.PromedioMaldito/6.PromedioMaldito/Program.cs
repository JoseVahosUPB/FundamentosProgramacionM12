using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.PromedioMaldito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Realizar un algoritmo que permita solicitar 3 calificaciones, calcular el promedio. Si el promedio se ubica en los siguientes rangos, escribir los correspondientes mensajes. Considerar la situación en donde el promedio generado no esté contemplado en los rangos establecidos, mostrar mensaje de error. 
            //9.5 - 10.0 Excelente
            //8.5 - 9.4 Muy bien
            //7.5 - 8.4 Bien
            float nota1 = 0f;
            float nota2 = 0f;
            float nota3 = 0f;
            float promedio = 0f;

            Console.WriteLine("Ingrese las tres calificaciones");
            nota1 = float.Parse(Console.ReadLine());
            nota2 = float.Parse(Console.ReadLine());
            nota3 = float.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3f;

            if (promedio >= 9.5f && promedio <= 10f)
            {
                Console.WriteLine("Excelente");
            }
            else if (promedio >= 8.5f && promedio <= 9.4f)
            {
                Console.WriteLine("Muy bien");
            }
            else if (promedio >= 7.5f && promedio <= 8.4f)
            {
                Console.WriteLine("Bien");
            }
            else
            {
                Console.WriteLine("ERROR: Su nota es indescriptible");
            }
        }
    }
}
