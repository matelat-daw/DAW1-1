
namespace Fuciones_2
{
    internal class Funciones
    {
        static double result;

        internal static double convert2Kelvin(double celcius)
        {
            result = celcius + 273.15;
            return result;
        }

        internal static double convert2Farenheit(double celcius)
        {
            result = (celcius * 9 / 5) + 32;
            return result;
        }

        internal static double convert2Option(double celcius, char kind)
        {
            if (kind == 'K')
            {
                result = convert2Kelvin(celcius);
            }
            else
            {
                result = convert2Farenheit(celcius);
            }
            return result;
        }

        internal static void subrayador(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine("\n");
        }
    }
}