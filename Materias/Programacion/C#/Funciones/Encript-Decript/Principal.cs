namespace Encript_Decript
{
    internal class Principal
    {
        static void Main(string[] args)
        {
            string word;
            string result;
            string concat;

            Console.WriteLine("Este Programa Llama a la Función Encripta para Encriptar una Palabra y También la Desencripta.\n");
            Console.Write("Ingresa la Palabra a Encriptar: ");
            word = Console.ReadLine();
            result = Funciones.encrypt(word);
            concat = Funciones.concatena(word, result);
            Funciones.separador(word.Length);
            Console.WriteLine(result);
            Funciones.separador(word.Length);
            result = Funciones.decrypt(result);
            Console.WriteLine(result);
            Funciones.separador(word.Length);
            Console.WriteLine(concat);
            Funciones.separador(concat.Length);
        }
    }
}