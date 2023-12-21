namespace Chess_Board
{
    internal class Ajedrez
    {
        const int SIZE = 8; // Tamaño del Tablero de Ajedrez, La Constante Será Estática y las Otras Variables Estáticas Para Usar en Todo el Código.
        static char[,] tablero = new char[SIZE, SIZE]; // Creo el Tablero de 8 x 8.
        static string letras = "ABCDEFGH"; // Cadena con las Letras del Tablero, Además se Usa Para Obtener el Índice de la Letra que Será la Posición del Caballo en las Columnas.

        static void Main(string[] args) // Método Principal(Main) de los Programas de Consola de C#.
        {
            string coord; // La Coordenada del Caballo.
            string letra; // La Letra de la Coordenada.
            int row; // La Fila de la Coordenada.
            int col; // La Columna de la Coordenada.
            int result; // La Cantidad de Movimientos.

            Console.WriteLine("Programa que Muestra el Tablero de Ajedrez, Pide las Coordenadas de Inicio de la Pieza Caballo y Muestra los Posibles Movimientos del Corsel.");
            draw(row = -1, col = -1); // Llama al Método draw(), Dibuja el Tablero, lo Rellena con el Carácter Espacio, le Paso -1 y -1 en Fila y Columna.
            show(); // Llama al Método show(), Muestra el Tablero en Pantalla.
            do // Haz
            {
                Console.Write("Ingresa las Coordenadas del Equino: ");
                coord = Console.ReadLine(); // Pide la Coordenada Desde el Teclado.
                if (coord != "") // Si la Coordenada es Dstinta de "".
                {
                    letra = coord.Substring(0, 1); // Obtiene la Letra en la String letra, de la Coordenada Introducida con Substring(0, 1), Desde la Primera Posición 1 Caracter.
                    for (int i = 0; i < SIZE; i++) // Bucle para Obtener la Columna de la Coordenada con la Letra Obtenida.
                    {
                        if (letra == letras[i].ToString()) // Si la Letra letra está en el Array de Letras letras.
                        {
                            col = i; // La i del Bucle es la Posición de la Columna Ingresada, se la Asigno a col.
                        }
                    }
                    row = Convert.ToByte(coord.Substring(1)) - 1; // Obtengo el Número de la Coordenada Ingresada, le Resto 1 y se lo Asigno a row, es la Posición de la Fila Ingresada.
                    draw(row, col); // Llamo al Método draw(), Para Dibujar la C de Caballo en la Coordenada Ingresada.
                    Console.Clear(); // Borro la Pnatalla.
                    show(); // Muestro el Tablero con el Caballo en su Nueva Coordenada.
                    result = moves(row, col); // Asigno a la Variable result la Devolución de la Llamada al Métdodo moves(row, col)(Devuelve un Entero, los Movimientos del Caballo en esa Coordenada), al cual le paso la Fila row y la Columna col.
                    Console.WriteLine("Desde Las Coordenadas Ingresadas el Cavallino Rampante puede Moverse: {0} Veces.", result); // Muestro la Cantidad de Movimientos en Pantalla.
                }
            }
            while (coord != ""); // Mientras que coord sea != "".
        }

        private static int moves(int col, int row) // Método que calcula los Movimientos Posibles del Caballo.
        {
            int[] X = { 2, 1, -1, -2, -2, -1, 1, 2 }; // Admiro Profundamente a la Persona que se Puso a Dibujar en un Papel Todas las Posibles Combinaciones y Llego a Esta Maravillosa Conclución, Este Array Mágico es Para las Columnas.
            int[] Y = { 1, 2, 2, 1, -1, -2, -2, -1 }; // Este Array Mágico es Para las Filas.
            int count = 0; // Declara e Incializa la variable count a 0;

            for (int i = 0; i < SIZE; i++) // Bucle Hasta el Tamaño del Tablero de Ajedrez.
            {
                int x = col + X[i]; // A la Coordenada col Ingresada por Teclado le suma el Contenido del Array X en la Posición i, y se lo Asigna a la Variable x.
                int y = row + Y[i]; // A la Coordenada row Ingresada por Teclado le Suma el Contenido del Array Y en la Posición i, y se lo Asigna a la Variable y.

                if (x >= 0 && y >= 0 && x < SIZE && y < SIZE) // Si x es mayor que 0 e y es Mayor que 0, pero ni x ni y son Mayores o Iguales que SIZE.
                    count++; // Incrementa el Contador count, Quiere Decir que el Caballo se puede Mover.
            }
            return count; // Devuelvo La Variable count, La Cantidad de Movimientos que Puede Hacer el Caballo Desde la Coordenada Ingresada.
        }

        private static void draw(int row, int col) // Método para Dibujar el Tablero Vacio, Arriba, y el Caballito en las Coordenadas Ingresadas, Abajo.
        {
            if (col < 0) // Si col es Menor que 0.
            {
                for (int i = 0; i < SIZE; i++) // Hago el Bucle Externos al Tamaño del Tablero.
                {
                    for (int j = 0; j < SIZE; j++) // Hago el Bucle Interno al Tamaño de Tablero.
                    {
                        tablero[i, j] = ' '; // Pongo el Espacio en el Array de char Tablero de 8 x 8.
                    }
                }
            }
            else // Si no, es que le Pasé las Coordenadas, Para Poner la C.
            {
                tablero[row, col] = 'C'; // Dibujo la C en las Coordenadas Ingresadas.
            }
        }

        private static void show() // Método Para Mostrar el Tablero.
        {
            Console.Write("   "); // Dibujo 3 Espacios en la Pantalla.
            for (int i = 0; i < SIZE; i++) // Hago un Bucle hasta el Tamaño del Tablero
            {
                Console.Write(" {0} ", letras[i]); // A Continuación de los 3 Espacios dibujo las Letras del Array de Letras letras con un Espacio Delante y Otro Detrás.
            }
            Console.WriteLine("\n"); // Después de Mostrar las Letras hago 2 Saltos de Línea.
            for (int i = 0; i < SIZE; i++) // Hago el Bucle Externo del Tamaño del Tablero.
            {
                Console.Write("{0}  ", i + 1); // Muestro en Pantalla los Números que serán las Filas, Seguidos de 2 Espacios Después de Cada Número.
                for (int j = 0; j < SIZE; j++) // Hago el Bucle Interno del Tamaño del Tablero.
                {
                    if ((j + i) % 2 == 0) // Verifico si la Coordenada del Tablero es Par.
                    {
                        Console.BackgroundColor = ConsoleColor.White; // Cambio el Color de Fondo de la Consola a Blanco.
                        Console.Write(" {0} ", tablero[i, j]); // Muestro en Pantalla 3 Espacios, el del Centro es el Contenido del Tablero.
                    }
                    else // Si la Coordenada del Tablero es Impar.
                    {
                        Console.BackgroundColor = ConsoleColor.Black; // Cambio el Color de Fondo de la Consola a Negro.
                        Console.Write(" {0} ", tablero[i, j]); // Muestro en Pantalla 3 Espacios, el del Centro es el Contenido del Tablero.
                    }
                }
                Console.BackgroundColor = ConsoleColor.Black; // Cuando salgo del Bucle Anidado Vuelvo a Poner el Color de Fondo de la Consola a Negro.
                Console.WriteLine(); // Escribo un Salto de Línea.
            }
            Console.WriteLine("\n"); // Escribo 2 Saltos de Línea.
        }

        /* private static int moves(int row, int col)
        {
            int moves;
            int total = row + col;

            switch (total)
            {
                case 0:
                case 14:
                    moves = 2;
                    break;
                case 1:
                case 13:
                    moves = 3;
                    break;
                default:
                    if (row > 1 && col > 1 && row < 6 && col < 6)
                    {
                        moves = 8;
                    }
                    else if (row > 1 && col == 1 && row < 6 && col == 1 || row == 1 && col > 1 && row == 1 && col < 6 || row > 1 && col == 6 && row < 6 && col == 6 || row == 6 && col > 1 && row == 6 && col < 6)
                    {
                        moves = 6;
                    }
                    else if (row > 1 && col == 0 && row < 6 && col == 0 || row == 0 && col > 1 && row == 0 && col < 6 || row > 1 && col == 7 && row < 6 && col == 7 || row == 7 && col > 1 && row == 7 && col < 6)
                    {
                        moves = 4;
                    }
                    else if (row == 0 && col == 6 || row == 1 && col == 7 || row == 6 && col == 0 || row == 7 && col == 1)
                    {
                        moves = 3;
                    }
                    else
                    {
                        if (row == 1 && col == 1 || row == 1 && col == 6 || row == 6 && col == 1 || row == 6 && col == 6)
                        {
                            moves = 4;
                        }
                        else
                        {
                            moves = 2;
                        }
                    }
                    break;
            }
            return moves;
        } */
    }
}