namespace Funcion_3;

internal class Funciones
{
    public static void separador()
    {
        for (int i = 0; i < 30; i++)
        {
            Console.Write('-');
        }
        Console.WriteLine("\n");
    }

    public static void subrayador(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write('-');
        }
        Console.WriteLine("\n");
    }

    public static int absoluto(int num)
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