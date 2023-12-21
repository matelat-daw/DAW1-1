
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fibonacci
{
    internal class Funciones
    {
        internal static int fibonacci(int num)
        {
            int result = 0;
            int actual = 0;
            int acumulador = 1;
            int anterior;

            //if (num == 1 || num == 0)
            //{
            //    result = num;
            //}
            //else
            //{
            //    result = fibonacci(num - 1) + fibonacci(num - 2);
            //}

            //return result;

            Console.Write("{0}, ", actual);
            for (int i = 0; i < num; i++) // Bucle Hasta el Número Deseado.
            {
                anterior = actual; // El Anterior es Igual al Actual.
                actual = acumulador; // El Actual es Igual al Acumulado
                acumulador = anterior + actual; // El Acmulado es igual a la suma del Actual + el Anterior.
                if (i < num - 1) // Si i no llego al Número.
                {
                    Console.Write("{0}, ", actual); // Muestro los Números Separados por, y un espacio.
                }
                else // Si i Llega el Final.
                {
                    Console.Write("{0}.\n\n", actual); // Muestro el Último Número y el Punto Final.
                }
            }
            return actual;
        }

        internal static void separador(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine("\n");
        }
    }
}