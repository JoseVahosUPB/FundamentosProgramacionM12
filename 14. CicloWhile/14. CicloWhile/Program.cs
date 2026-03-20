using System;
using System.Runtime.InteropServices;

namespace _14.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 14. Crear un algoritmo que permita calcular y mostrar por pantalla los números primos hasta el número 100.

            /*int contadorNumeros = 1;
            int contador = 1;
            int contadorDivisores = 0;

            do
            {
                do
                {
                    if (contadorNumeros%contador == 0)
                    {
                        contadorDivisores++;
                    }
                    contador++;

                } while (contador <= contadorNumeros);

                contador = 1;

                if (contadorDivisores == 2)
                {
                    //Console.WriteLine(contadorDivisores +"== 2?");
                    Console.WriteLine(contadorNumeros);
                }

                contadorDivisores = 0;

                // Console.WriteLine(contadorNumeros);
                contadorNumeros++;

            } while (contadorNumeros <= 100);*/

            // 14. Escribe un algoritmo que actúe como una calculadora básica. El algoritmo le debe permitir al usuario elegir una operación (suma, resta, multiplicación, división), y luego ingresar dos números. El ciclo debe continuar permitiendo al usuario realizar más cálculos hasta que elija salir.

            /*string operacion = "";
            float numero1 = 0f;
            float numero2 = 0f;
            string resultado = "";
            bool bandera = false;


            do
            {

                Console.WriteLine("¿Qué operación desea realizar? [suma], [resta], [multiplicacion], [division]");
                operacion = Console.ReadLine().ToLower();
                Console.WriteLine("Ahora, ingrese dos números");
                numero1 = float.Parse(Console.ReadLine());
                numero2 = float.Parse(Console.ReadLine());

                switch (operacion)
                {
                    case "suma":
                        resultado = (numero1 + numero2).ToString();
                        break;
                    case "resta":
                        resultado = (numero1 - numero2).ToString();
                        break;
                    case "multiplicacion":
                        resultado = (numero1 * numero2).ToString();
                        break;
                    case "division":
                        resultado = (numero1 / numero2).ToString();
                        break;
                    default:
                        resultado = "UN ERROR, ingrese una operación válida";
                        break;
                }

                Console.WriteLine("El resultado es: " + resultado);

                Console.WriteLine("Ingrese un 0 si desea efectuar otra operación");

            } while (Console.ReadLine() == "0");

            Console.WriteLine("Chaíto");*/

            // Crear un algoritmo que permita ingresar números:
            //     Contar cuantos son pares y cuántos impares
            //     Calcular el promedio de todos los números ingresados
            //     terminar cuando el usuario lo indique

            /*int numero = 0;
            int pares = 0;
            int impares = 0;
            int sumatoria = 0;

            do
            {
                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());

                if (numero%2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                sumatoria += numero;

                Console.WriteLine("Si desea ingresar otro número ingrese un 0");
            } while (Console.ReadLine() == "0");

            Console.WriteLine($"Usted ingresó {pares} números pares");
            Console.WriteLine($"Usted ingresó {impares} números impares");
            Console.WriteLine("El promedio de los números que ingresó es: "+sumatoria/(pares+impares));*/

            // Permita al usuario ingresar una contraseña
            // Se repita hasta que ingrese la contraseña correcta (por ejemplo: 1234)
            // Mostrar cuantos intentos realizó

            int intentos = 0;
            string contrasena = "";

            Console.WriteLine("¿Cuál le gustaría que fuera su contraseña?");
            contrasena = Console.ReadLine();

            do
            {
                intentos++;
                Console.WriteLine("Escriba su contraseña");
            } while (Console.ReadLine() != contrasena);

            Console.WriteLine("Usted escribió la contraseña correcta al intento " + intentos);

        }
    }
}
