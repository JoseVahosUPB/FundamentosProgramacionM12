using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CondicionalesDoblesCompuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar wl mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos. De lo contrario mostrar el mensaje "Persona exenta de impuestos".
            /*string nombre = "";
            float sueldo = 0;
            Console.WriteLine("Ingrese el nombre del usuario");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el valor del sueldo");
            sueldo = Single.Parse(Console.ReadLine());

            if (sueldo>=3000)
            {
                //Si la condición es verdadera
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }
            else
            {
                //Si la codición es falsa
                Console.WriteLine("La persona está exenta de impuestos");
            }*/

            //Crear un algoritmo que permita ingresar dos números, si el primer número es mayor al segundo número informar su suma y diferencia, en caso contrario informar el producto y la división del primer número respecto al segundo número
            float n1 = 0;
            float n2 = 0;
            Console.WriteLine("Ingrese dos números");
            n1 = Single.Parse(Console.ReadLine());
            n2 = Single.Parse(Console.ReadLine());
            if (n1>n2)
            {
                Console.WriteLine("Su suma es: " + (n1 + n2));
                Console.WriteLine("Su diferencia es: " + (n1 - n2));
            }
            else
            {
                Console.WriteLine("Su producto es: " + (n1 * n2));
                Console.WriteLine("Su división es: " + (n1 / n2));
            }
        }
    }
}
