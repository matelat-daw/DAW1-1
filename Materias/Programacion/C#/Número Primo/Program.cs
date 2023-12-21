namespace Número_Primo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int prime;
             
            Console.WriteLine("Este Programa Verifica si un Número Pasado por Parámetro es Primo.\n");
            num = Convert.ToInt32(Console.ReadLine());
            Funciones.verificaPrimo(num);
            prime = Funciones.verificaPrimo2(num, num / 2);

            if (prime == 1)
            {
                Console.WriteLine("El Número: {0}, Es Primo.", num);
            }
            else
            {
                Console.WriteLine("Ese Número No es Primo.");
            }
        }
    }
}