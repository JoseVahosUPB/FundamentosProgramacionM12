using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicialización de variables y constantes
            string nombre = "";
            int anosTrabajados = 0;
            float calificacionActual = 0f;
            float calificacionAnterior = 0f;
            float promedioCalificacion = 0f;
            float porcentajeAumento = 0f;
            float valorAumento = 0f;

            const int sueldoBase = 2500000;

            // Ingreso de datos
            Console.WriteLine("Ingrese el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese los años trabajados por el empleado");
            anosTrabajados = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la calificación actual del empleado");
            calificacionActual = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la calificación anterior del empleado");
            calificacionAnterior = float.Parse(Console.ReadLine());

            // Validación de calificaciones
            if ((calificacionActual != 0.0f && calificacionActual != 0.4f && calificacionActual != 0.6f && calificacionActual != 1.0f) || (calificacionAnterior != 0.0f && calificacionAnterior != 0.4f && calificacionAnterior != 0.6f && calificacionAnterior != 1.0f))
            {
                Console.WriteLine("Error: calificación inválida. El programa terminará.");
            }
            else
            {
                // Calculo del promedio
                promedioCalificacion = (calificacionActual + calificacionAnterior) / 2;

                // Determinación del porcentaje de aumento salarial
                if (anosTrabajados < 1)
                {
                    porcentajeAumento = 0f;
                }
                else if (anosTrabajados > 5)
                {
                    porcentajeAumento = 30f;
                }
                else
                {
                    if (promedioCalificacion < 0.4f)
                    {
                        porcentajeAumento = 5f;
                    }
                    else if (promedioCalificacion < 0.6f)
                    {
                        porcentajeAumento = 10f;
                    }
                    else
                    {
                        porcentajeAumento = 20f;
                    }
                }

                // Calculo del valor del aumento
                valorAumento = sueldoBase * (porcentajeAumento / 100);

                // Salida de datos
                Console.WriteLine("Nombre del empleado: " + nombre);
                Console.WriteLine("Promedio de calificación: " + promedioCalificacion);
                Console.WriteLine("Porcentaje de aumento aplicado: " + porcentajeAumento+"%");
                Console.WriteLine("Valor del aumento en pesos: $" + valorAumento);
            }
        }
    }
}
