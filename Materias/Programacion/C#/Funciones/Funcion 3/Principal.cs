namespace Funcion_3;

internal class Principal
{
    static void Main(string[] args)
    {
        int num;
        int result;
        string title = "Esto Aparece Subrayado.";

        Console.WriteLine("Funciones con Dos Clases.\n");
        Console.WriteLine("Llamada a una Función que Hace Algo Pasandole un Parámetro y Retorna el Control al Flujo del Código\n");
        Funciones.separador();
        Console.WriteLine(title);
        Funciones.subrayador(title.Length);
        Console.WriteLine("Separado Con Guiones del Mismo Tamaño que la Frase.\n");
        Console.Write("Introduce un Número Real: ");
        num = int.Parse(Console.ReadLine());
        result = Funciones.absoluto(num);
        Console.WriteLine("El Valor Absoluto del Número {0} es: {1}", num, result);
    }
}