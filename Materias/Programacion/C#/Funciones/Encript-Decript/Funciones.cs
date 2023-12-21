namespace Encript_Decript
{
    internal class Funciones
    {
        internal static string encrypt(string word)
        {
            string result = "";

            for (int i = 0; i < word.Length; i++)
            {
                result += (char)(word[i] + 5);
            }
            return result;
        }

        internal static string decrypt(string word)
        {
            string result = "";

            for (int i = 0; i < word.Length; i++)
            {
                result += (char)(word[i] - 5);
            }
            return result;
        }

        internal static void separador(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine("\n");
        }

        internal static string concatena(string s1, string s2)
        {
            string result;
            result = s1 + s2;
            return result;
        }
    }
}