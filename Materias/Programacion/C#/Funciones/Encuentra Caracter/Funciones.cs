
namespace Encuentra_Caracter
{
    internal class Funciones
    {
        internal static int busca(string word, char ch)
        {
            int position = 0; // Solo se necesita una variable.

            while (position < word.Length && word[position] != ch) // Busqueda Lineal
            {
                position++; // Incrementa la posición.
            }
            if (position == word.Length) // Si a la Salida la posición es la última.
            {
                position = -1; // position = -1 no se encontró.
            }
            return position; // Retorna position.
        }
    }
}