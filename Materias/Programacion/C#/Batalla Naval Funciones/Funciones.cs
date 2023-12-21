namespace Batalla_Naval_Funciones
{
    internal class Funciones
    {
        internal static int disparar(char[,] tablero, string coordenada)
        {
            const char agua = '~';
            const char disparo = '*';
            const int cod_agua = 0;
            const int cod_tocado = 1;
            const int cod_repetido = 2;
            int f = 0;
            int c = 0;

            extraerCoordenada(coordenada, f, c);

            return cod_agua;
        }

        private static void extraerCoordenada(object coordDisparo, object f, object c)
        {
            throw new Exception("Esa Coordenada está fuera de Rango, las coordenadas van de la A a la J y de 1 a 10.\n");
        }
    }
}