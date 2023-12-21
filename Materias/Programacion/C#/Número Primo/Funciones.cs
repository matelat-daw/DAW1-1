
namespace Número_Primo
{
    internal class Funciones
    {
        static int resto;

        internal static void verificaPrimo(int num) // Función No Recursiva.
        {
            if (num > 1) // Si el Numero Recibido es Mayor que 1.
            {
                resto = num / 2; // El resto será igual a la mitad del número.
                while (resto > 1) // Minetras resto sea mayor que 1
                {
                    if (num % resto == 0) // Verifico se el resto de num es igual a 0.
                    {
                        Console.WriteLine("Ese Número No es Primo.\n"); // Si el resto da cero antes de llegar a 1, no es primo.
                        resto = 0; // Pongo reto a 0 para salir del bucle.
                    }
                    else // Si el resto no da cero decremento el número para obtener el resto.
                    {
                        resto--;
                    }
                }
                if (resto == 1) // Si a la salida resto es 1 es que el número es primo.
                {
                    Console.WriteLine("El Número: {0}, Es Primo, Solo es Divisible por si Mismo y por 1.\n", num);
                }
            }
            else
            {
                Console.WriteLine("El Número: {0}, Es Primo, Solo es Divisible por si Mismo y por 1.\n", num);
            }
        }

        internal static int verificaPrimo2(int num, int half_num)
        {
            if (half_num == 1)
            {
                return 1;
            }
            else
            {
                if (num % half_num == 0)
                    return 0;
                else
                    return verificaPrimo2(num, half_num - 1); // Llama a la función Recursivamente.
            }
        }
    }
}