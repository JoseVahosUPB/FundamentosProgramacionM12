using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Parcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota = 0f;

            float sumatoria = 0f;
            float promedio = 0f;

            int excelentes = 0;
            int buenos = 0;
            int regulares = 0;
            int descuidados = 0;

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("Ingrese la nota final del estudiante "+i);
                nota = float.Parse(Console.ReadLine());

                sumatoria += nota;

                if (nota >= 4.8f)
                {
                    excelentes++;
                }
                else if (nota >= 4.0f && nota < 4.8f)
                {
                    buenos++;
                }
                else if (nota >= 3.0f && nota < 4.0f)
                {
                    regulares++;
                }
                else if (nota < 3.0f)
                {
                    descuidados++;
                }
            }

            promedio = sumatoria / 12f;

            Console.WriteLine("Esta es la cantidad de estudiantes por categoría:");
            Console.WriteLine("Excelentes: " + excelentes);
            Console.WriteLine("buenos: " + buenos);
            Console.WriteLine("regulares: " + regulares);
            Console.WriteLine("descuidados: " + descuidados);
            Console.WriteLine();
            Console.WriteLine("El promedio del grupo es: " + promedio);

        }
    }
}
