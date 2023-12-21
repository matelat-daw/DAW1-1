namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int result;

            Console.WriteLine("Serie de Fibonacci\n");
            Console.Write("Ingresa el Número Hasta el que Quieras ver la Serie: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            result = Funciones.fibonacci(num);
            Console.WriteLine(result);
            Funciones.separador(result.ToString().Length);
        }
    }
}