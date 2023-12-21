namespace Concatenar_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] a = { -5.25, -2.5, 0, 2.5, 5.25 };
            double[] b = { -6.25, -3.5, -1.1, 0, 2.25, 5.5, 7.75 };
            Console.WriteLine("Este Progrmama Concatena y Une dos Arrays.\n");
            Console.Write("Array A: ");
            Funciones.mostrar(a);
            Funciones.mostrar(b);
            Funciones.mostrar(Funciones.concatena(a, b));
            Funciones.mostrar(Funciones.merge(a, b));
            
        }
    }
}