
using System.Runtime.ConstrainedExecution;

namespace Funcion_1
{
    internal class Funcion_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Llamada a una Función que Hace Algo y Retorna el Control al Flujo del Código\n");
            separador();
            Console.WriteLine("Esto Aparece Separado.");
        }

        private static void separador()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine("\n");
        }
    }
}