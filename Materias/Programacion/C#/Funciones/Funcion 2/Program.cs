namespace Funcion_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int result;
            string title = "Esto Aparece Subrayado.";
            Console.WriteLine("Llamada a una Función que Hace Algo Pasandole un Parámetro y Retorna el Control al Flujo del Código\n");
            separador();
            Console.WriteLine(title);
            subrayador(title.Length);
            Console.WriteLine("Separado Con Guiones del Mismo Tamaño que la Frase.\n");
            Console.Write("Introduce un Número Real: ");
            num = int.Parse(Console.ReadLine());
            result = absoluto(num);
            Console.WriteLine("El Valor Absoluto del Número {0} es: {1}", num, result);

        }

        private static void separador()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine("\n");
        }

        private static void subrayador(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine("\n");
        }

        private static int absoluto(int num)
        {
            int result;
            if (num < 0)
            {
                result = -num;
            }
            else
            {
                result = num;
            }
            return result;
        }
    }
}