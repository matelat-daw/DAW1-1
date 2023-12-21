
namespace Contador_de_Caracter
{
    internal class Funciones
    {
        static int result = 0;

        internal static int cuentaCaracter(string cadena, char caracter)
        {
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == caracter)
                {
                    result++;
                }
            }
            return result;
        }
    }
}