namespace Batalla_Naval_Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 10;
            char[,] tablero = new char[SIZE, SIZE];
            Console.WriteLine("Batalla Naval");
            Funciones.disparar(tablero, "C5");
        }
    }
}