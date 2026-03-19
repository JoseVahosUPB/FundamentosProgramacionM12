using System;
using System.Security.Policy;

namespace _13.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int sumaEnteros = 0; // Variable tipo Acumulador

            do
            {
                sumaEnteros += contador;
                contador++;

            } while (contador <= 5);

            Console.WriteLine($"La suma de los cinco primeros números enteros es: {sumaEnteros}");*/

            // Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10. Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar.

            /*int numero = 0;
            char respuesta = ' ';
            int contador = 1;

            do
            {
                Console.Clear(); // Borra lo que haya en pantalla
                Console.WriteLine("Digite el número para calcualar su tabla de multiplicar");
                numero = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                    contador++;

                } while (contador <= 10);

                contador = 1;
                Console.WriteLine("¿Desea calcular más tablas de multiplicar? s=Sí, n=No");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta=='s');*/

            // Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente:
            //     1. Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “Es apto para el crédito”
            //     2. Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “No es apto para el crédito”
            // El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar más.
            // Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos.

            string nombre = "";
            int numeroCuenta = 0;
            int saldo = 0;

            int numeroUsuarios = 0;
            int sumaSaldos = 0;

            int respuesta = ' ';

            float promedioSaldos = 0f;

            do
            {

                numeroUsuarios++;

                Console.WriteLine("Ingrese el nombre del usuario "+numeroUsuarios);
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el número de cuenta del usuario " + numeroUsuarios);
                numeroCuenta = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el saldo del usuario " + numeroUsuarios);
                saldo = int.Parse(Console.ReadLine());

                Console.WriteLine("Nombre de usuario: "+nombre);
                Console.WriteLine("Número de cuenta: " + numeroCuenta);
                Console.WriteLine("Saldo: $" + saldo);

                if (saldo >= 3000000)
                {
                    Console.WriteLine("Es apto para el crédito");
                }
                else
                {
                    Console.WriteLine("No es apto para el crédito");
                }

                sumaSaldos += saldo;

                Console.WriteLine("¿Desea encuestar más usuarios? s=Sí, n=No");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta == 's');

            promedioSaldos = sumaSaldos / numeroUsuarios;

            Console.WriteLine($"Se le preguntó a {numeroUsuarios} usuarios");
            Console.WriteLine("El promedio de sus saldos es $"+promedioSaldos);
        }
    }
}
