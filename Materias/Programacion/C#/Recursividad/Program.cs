namespace Recursividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que Llama a una Función y la Función se Llama Recursivamente Hasta Terminar.\n");
            Funciones.showNumbers();
            Funciones.showNumbers2();
            Funciones.showNumbers(1);
            Funciones.showNumbers2(1);
        }
    }
}