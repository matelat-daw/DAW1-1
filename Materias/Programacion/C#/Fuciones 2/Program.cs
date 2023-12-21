namespace Fuciones_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degree = 0;
            double result;

            Console.WriteLine("Este Programa Convierte los Grados Centígraqdos a Kelvin y Farenheit.\n");
            // Console.Write("Ingresa los Grados Centígrados: ");
            // degree = Convert.ToDouble(Console.ReadLine());
            result = Funciones.convert2Kelvin(degree);
            Funciones.subrayador(10);
            result = Funciones.convert2Farenheit(degree);
            Funciones.subrayador(10);
            result = Funciones.convert2Option(degree, 'K');
            Funciones.subrayador(10);
            result = Funciones.convert2Option(degree, 'F');
        }
    }
}