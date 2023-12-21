namespace Mostrar_Tabla;

internal class Principal
{
    static void Main(string[] args)
    {
        const int SIZE = 8;
        int[,] tabla = new int[SIZE, SIZE];
        
        Funciones.mostrarTabla(tabla);
        Funciones.separador(SIZE * 5);
        Funciones.rellenarTabla(tabla);
        Funciones.mostrarTabla(tabla);
    }
}