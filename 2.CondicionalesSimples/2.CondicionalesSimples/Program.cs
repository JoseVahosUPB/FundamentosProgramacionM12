using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CondicionalesSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera  los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos*/

            /*string nombre = "";
            float sueldo = 0f;
            Console.WriteLine("Ingrese el nombre del usuario");
            nombre = Console.ReadLine();//Lo que llega desde la consola, es de tipo string
            Console.WriteLine("Ingrese el sueldo del usuario");
            sueldo = Convert.ToSingle(Console.ReadLine());

            if (sueldo>=3000)
            {
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }*/

            /*2.Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje:"Bienvenido a mi sitio web"*/
            int edad = 0;
            Console.WriteLine("Ingrese la edad del usuario");
            edad = Convert.ToInt16(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }
        }
    }
}
