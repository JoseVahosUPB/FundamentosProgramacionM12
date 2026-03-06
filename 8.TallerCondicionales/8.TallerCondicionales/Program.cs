using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _8.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1, numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en pantalla los números de menor a mayor.
            // Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben ingresar números diferentes. 

            /*int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

            Console.WriteLine("Ingrese 3 números diferentes");
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());
            numero3 = int.Parse(Console.ReadLine());

            if ((numero1 != numero2) && (numero1 != numero2) && (numero2 != numero3))
            {
                if (numero1 > numero2)
                {
                    if (numero1 > numero3)
                    {
                        Console.WriteLine("El número mayor es: " + numero1);
                        Console.WriteLine("Sus números organizados de menor a mayor:");
                        if (numero2 > numero3)
                        {
                            Console.WriteLine($"{numero3} {numero2} {numero1}");
                        }
                        else
                        {
                            Console.WriteLine($"{numero2} {numero3} {numero1}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El número mayor es: " + numero3);
                        Console.WriteLine("Sus números organizados de menor a mayor:");
                        Console.WriteLine($"{numero2} {numero1} {numero3}");
                    }
                }
                else
                {
                    if (numero2 > numero3)
                    {
                        Console.WriteLine("El número mayor es: " + numero2);
                        Console.WriteLine("Sus números organizados de menor a mayor:");
                        if (numero1 > numero3)
                        {
                            Console.WriteLine($"{numero3} {numero1} {numero2}");
                        }
                        else
                        {
                            Console.WriteLine($"{numero1} {numero3} {numero2}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El número mayor es: " + numero3);
                        Console.WriteLine("Sus números organizados de menor a mayor:");
                        Console.WriteLine($"{numero1} {numero2} {numero3}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Se deben ingresar números diferentes");
            }*/

            // 2.El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si cuenta con munición y si se encuentra en estado invencible, crear un programa que:
            // a.Permita ingresar por teclado si el personaje está en estado invencible(True).
            // b.La cantidad de munición que tiene el personaje en el momento será calculada por el sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#.
            // Ejemplo:
            /*int numero;
            Random rnd = new Random();
            numero = rnd.Next(1, 6);//Devuelve un número entre 0 y 5
            Console.WriteLine(numero);*/
            // c.Si el estado del personaje es invencible(true) y su cantidad de munición está entre 1 y 10, mostrar un mensaje en la consola “El personaje está disparando”, en caso contrario no hacer nada.

            /*Random rnd = new Random();

            bool invencible = false;
            int ammo = rnd.Next(0, 11);

            Console.WriteLine("¿Su personaje esta invencible? Copie [True] ");
            invencible = bool.Parse(Console.ReadLine());

            if (ammo > 0)
            {
                Console.WriteLine("El personaje está disparando");
            }*/

            // 3. Crear un algoritmo que permita ingresar las coordenadas x,y, para tres puntos: P1(x1,y1), P2(x2, y2), P3(x3, y3).Luego calcular la distancia entre los puntos P1  P2, P2  P3, P1 P3.La distancia entre dos puntos está dada por la siguiente formula:
            // d = √((x2 - x1)² +(y2 - y1)²)
            // Después de haber calculado la distancia entre los puntos, el algoritmo debe decir si con dichas distancias se puede construir un triángulo, consultar las condiciones que se deben cumplir para realizar dicha construcción.En caso contrario, decir cuál o cuáles de las condiciones no se cumplen.

            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 0;
            double x3 = 0;
            double y3 = 0;

            Console.WriteLine("Ingrese la coordenada x para el punto 1");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada y para el punto 1");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada x para el punto 2");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada y para el punto 2");
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada x para el punto 3");
            x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada y para el punto 3");
            y3 = double.Parse(Console.ReadLine());

            double distancia1_2 = System.Math.Sqrt((System.Math.Pow((x2 - x1), 2) + System.Math.Pow((y2 - y1), 2)));
            double distancia1_3 = System.Math.Sqrt((System.Math.Pow((x3 - x1), 2) + System.Math.Pow((y3 - y1), 2)));
            double distancia2_3 = System.Math.Sqrt((System.Math.Pow((x3 - x2), 2) + System.Math.Pow((y3 - y2), 2)));

            if (distancia1_2 == 0 || distancia1_3 == 0 || distancia2_3 == 0)
            {
                Console.WriteLine("No se puede formar un triangulo, las coordenadas de dos puntos no pueden ser iguales porque se genera una línea recta");
            }
            else if (System.Math.Round(distancia1_2 + distancia1_3) == System.Math.Round(distancia2_3) || System.Math.Round(distancia1_3 + distancia2_3) == System.Math.Round(distancia1_2) || System.Math.Round(distancia1_2 + distancia2_3) == System.Math.Round(distancia1_3))
            {
                Console.WriteLine("No se puede formar un triangulo, las coordenadas de los puntos están alineadas de manera que se genera una línea recta");
            }
            else
            {
                Console.WriteLine("Se forma un triángulo muy bonito");
            }
            Console.WriteLine(distancia1_2);
            Console.WriteLine(distancia1_3);
            Console.WriteLine(distancia2_3);

            // 4. El personaje de un juego, solo se puede mover en forma horizontal (Izquierda o Derecha), crear un programa que muestre en la consola un mensaje diciendo si el personaje se mueve hacia la izquierda o hacia la derecha, según la tecla que se presione en el teclado.
            //  Si se ingresa el carácter ‘d’, se muestra el mensaje “El personaje se mueve hacia la derecha"
            //  Si se ingresa el carácter ‘i’, se muestra el mensaje “El personaje se mueve hacia la izquierda"
            //  En caso contrario, se debe mostrar un mensaje de error “No me puedo mover en otra dirección” 

            /*char direction = ' ';

            Console.WriteLine("¿Derecha [d] o izquierda [i]?");

            direction = Console.ReadLine()[0];

            if (direction == 'd')
            {
                Console.WriteLine("El personaje se mueve hacia la derecha");
            }
            else if (direction == 'i')
            {
                Console.WriteLine("El personaje se mueve hacia la izquierda");
            }
            else
            {
                Console.WriteLine("No me puedo mover en otra dirección");
            }*/

            // 5. El personaje de un juego, puede realizar diferentes acciones dependiendo del carácter que el usuario ingrese, y de la cantidad de vidas que posee. Crear un programa que permita:
            //  Generar un número aleatorio entre 0 y 5 para simular el número de vidas del personaje. (Función Random)
            //  Si el número de vidas es mayor a 0, el personaje puede realizar acciones en el juego.En caso contrario escribir el mensaje “el personaje no posee vidas, y no puede realizar ninguna acción”.
            //  Si el personaje puede realizar acciones, escribir los siguientes mensajes de acuerdo al carácter que se ingrese:
            //  o Si se ingresa ‘c’, mostrar en consola “el personaje está disparando”
            //  o Si se ingresa ‘x’, mostrar en consola “el personaje está hablando con la Rana”
            //  o Si se ingresa ‘t’, mostrar en consola “el personaje está en modo Turbo”
            //  o Si se presiona ‘i’, mostrar en consola “el personaje es Invencible” 

            /*Random rnd = new Random();

            int vidas = rnd.Next(0, 6);
            char actions = ' ';

            if (vidas > 0)
            {
                actions = Console.ReadLine()[0];
                switch (actions)
                {
                    case 'c':
                        Console.WriteLine("el personaje está disparando");
                        break;
                    case 'x':
                        Console.WriteLine("el personaje está hablando con la Rana");
                        break;
                    case 't':
                        Console.WriteLine("el personaje está en modo Turbo");
                        break;
                    case 'i':
                        Console.WriteLine("el personaje es Invencible");
                        break;
                    default:
                        Console.WriteLine("el personaje no hace nada");
                        break;
                }
            }
            else
            {
                Console.WriteLine("el personaje no posee vidas, y no puede realizar ninguna acción");
            }*/
        }
    }
}
