using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _7.CondicionalesMultiplesOperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7.Tiendas La Avenida desea desarrollar un programa que permita ingresar por teclado el monto de compra y el día de la semana, para saber: 
                Si el día es martes o jueves, se realizará un descuento del 15 % por la compra.  
                Si el día es lunes o miércoles, se realizará un descuento del 10 % por la compra. 
                Si el día es viernes o sábado, se realizará un descuento del 20 % por la compra. 
                Si es domingo no se realiza descuento.
                Visualizar el día, el descuento y el total a pagar por la compra. */
            /*string diaSemana = "";
            float subtotal = 0f;
            float descuento = 0f;

            Console.WriteLine("Ingrese el monto de la compra");
            subtotal = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el día de la semana");
            diaSemana = Console.ReadLine().ToLower();

            switch (diaSemana)
            {
                case "lunes":
                    descuento = subtotal * 0.1f;
                    Console.WriteLine($"Hoy es lunes, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;
                case "martes":
                    descuento = subtotal * 0.15f;
                    Console.WriteLine($"Hoy es martes, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;
                case "miercoles":
                    descuento = subtotal * 0.1f;
                    Console.WriteLine($"Hoy es miercoles, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;
                case "jueves":
                    descuento = subtotal * 0.15f;
                    Console.WriteLine($"Hoy es jueves, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;
                case "viernes":
                    descuento = subtotal * 0.2f;
                    Console.WriteLine($"Hoy es viernes, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;
                case "sabado":
                    descuento = subtotal * 0.2f;
                    Console.WriteLine($"Hoy es sabado, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;
                case "domingo":
                    descuento = 0;
                    Console.WriteLine($"Hoy es domingo, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;
                default:
                    Console.WriteLine("Por favor ingrese un día de la semana correcto");
                    break;
            }*/
            //Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas entre dos números ingresados por el usuario. Las operaciones disponibles serán: suma, resta, multiplicación y división, las cuales se ejecutarán según la opción seleccionada por el usuario
            float numero1 = 0f;
            float numero2 = 0f;
            byte seleccion = 0;

            Console.WriteLine("Ingrese dos números");
            numero1 = float.Parse(Console.ReadLine());
            numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un número según lo que quiera hacer con estos numeros:");
            Console.WriteLine("[1]: Sumar");
            Console.WriteLine("[2]: Restar");
            Console.WriteLine("[3]: Multiplicar");
            Console.WriteLine("[4]: Dividir");

            seleccion = byte.Parse(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
                    break;
                case 2:
                    Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
                    break;
                case 3:
                    Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2}");
                    break;
                case 4:
                    Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
                    break;
                default:
                    Console.WriteLine("Ingrese una opción válida");
                    break;
            }
        }
    }
}
