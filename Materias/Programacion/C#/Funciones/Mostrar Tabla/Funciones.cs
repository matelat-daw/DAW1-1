using System.Drawing;

namespace Mostrar_Tabla;

internal class Funciones
{
    public static void mostrarTabla(int[,] tabla)
    {
        Console.Write(' ');
        for (int i = 0; i < tabla.GetLength(0); i++)
        {
            Console.Write("{0, 4}", (char)('A' + i));
        }
        Console.WriteLine("\n");
        for (int i = 0; i < tabla.GetLength(0); i++)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write((char)('A' + i));
            for (int j = 0; j < tabla.GetLength(1); j++)
            {
                if (tabla[i, j] < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    if (tabla[i, j] > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.Write("{0, 4}", tabla[i, j]);
            }
            Console.WriteLine("\n");
        }
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    public static void rellenarTabla(int[,] tabla)
    {
        Random rnd = new Random();

        Console.WriteLine("Este Programa Crea una Tabla de Enteros y Usa una Función en Otra Clase para Mostrarla por Pantalla.\n");
        for (int i = 0; i < tabla.GetLength(0); i++)
        {
            for (int j = 0; j < tabla.GetLength(1); j++)
            {
                tabla[i, j] = rnd.Next(-10, 11);
            }
        }
    }

    public static void separador (int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write('-');
        }
        Console.WriteLine("\n");
    }
}