
using System.Diagnostics.Metrics;

namespace Batalla_Naval_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coord;
            int result;

            Console.WriteLine("Batlla Naval.\n\n");
            Funciones.fillTablero();
            Funciones.showTablero();
            do
            {
                Console.Write("\n\nIngresa las Coordenadas Ej: A1, E5, J10 (0 en Cualquier Momento para Salir.): ");
                coord = Console.ReadLine().ToUpper();
                if (coord != "0")
                {
                    result = Funciones.disparo(coord);
                    switch (result)
                    {
                        case 1:
                            Console.WriteLine("Agua.\n Presiona ENTER para Continuar.");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Tocado.\n");
                            Funciones.checkGame(coord);
                            if (Funciones.counter[0] > 0)
                            {
                                if (Funciones.counter[0] > 1)
                                {
                                    Console.WriteLine("Has tocado el Barco Grande: {0} Veces.", Funciones.counter[0]);
                                }
                                else
                                {
                                    Console.WriteLine("Has tocado el Barco Grande: {0} Vez.", Funciones.counter[0]);
                                }
                            }
                            if (Funciones.counter[1] > 0)
                            {
                                if (Funciones.counter[1] > 1)
                                { 
                                    Console.WriteLine("Has tocado el Barco Mediano: {0} Veces.", Funciones.counter[1]);
                                }
                                else
                                {
                                    Console.WriteLine("Has tocado el Barco Mediano: {0} Vez.", Funciones.counter[1]);
                                }
                            }
                            Console.WriteLine("Presiona ENTER para Continuar.");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Revisa tus Dioptrías, ya Habías Disparado Ahí, Tiro Repetido.\n Presiona ENTER para Continuar.");
                            Console.ReadKey();
                            break;
                    }
                }
                Funciones.showTablero();
            }
            while (coord != "0");
        }
    }
}