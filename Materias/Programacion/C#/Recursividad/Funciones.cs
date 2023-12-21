
namespace Recursividad
{
    internal class Funciones
    {
        static int num = 1;

        internal static void showNumbers() // Función Recursiva.
        {
            if (num < 100)
            {
                Console.Write("{0}, ", num); // Muestra de 1 a 99, separados por coma ','.
                num++;
                showNumbers(); // La Función Se Llama Recursivamente.
            }
            else
            {
                Console.Write("{0}.\n\n", num); // Muestra el 100.
                num = 1;
            }
        }

        internal static void showNumbers2() // Función No Recursiva con bucle for.
        {
            for (;  num < 101; num++) // Bucle de 1 a 100.
            {
                if (num < 100)
                {
                    Console.Write("{0}, ", num); // Muestra de 1 a 99, separados por coma ','.
                }
                else
                {
                    Console.Write("{0}.\n\n", num); // Muestra el 100.
                }
            }
        }

        internal static void showNumbers(int numero) // Función Recursiva, con Parámetro.
        {
            if (numero < 100)
            {
                Console.Write("{0}, ", numero); // Muestra de 1 a 99, separados por coma ','.
                numero++;
                showNumbers(numero); // La Función Se Llama Recursivamente, se Pasa como Parámetro el Número.
            }
            else
            {
                Console.Write("{0}.\n\n", numero); // Muestra el 100.
            }
        }

        internal static void showNumbers2(int numero) // Función No Recursiva con bucle for, con Parámetro.
        {
            for (; numero < 101; numero++) // Bucle de 1 a 100.
            {
                if (numero < 100)
                {
                    Console.Write("{0}, ", numero); // Muestra de 1 a 99, separados por coma ','.
                }
                else
                {
                    Console.Write("{0}.\n\n", numero); // Muestra el 100.
                }
            }
        }
    }
}