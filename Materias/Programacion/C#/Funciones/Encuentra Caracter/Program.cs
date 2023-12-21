namespace Encuentra_Caracter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            char ch;

            Console.Write("Ingresa una Palabra: ");
            word = Console.ReadLine();
            Console.Write("Ahora Ingresa el Carácter a Buscar: ");
            ch = Convert.ToChar(Console.ReadLine());
            int result = Funciones.busca(word, ch); // Asigno el resultado de la función a la variable result.

            if (result > 0) // Si result es mayor que 0, se ha encontrado el caracter en la palabra o frase.
            {
                Console.WriteLine("\nLa posición del Carácter en la Palabra es: {0}", result); // Muestro la posición del caracter en l Cadena
            }
            else // Si No.
            {
                Console.WriteLine("El Caracter No Está en la Cadena."); // El caracter no está en la cadena.
            }
        }
    }
}