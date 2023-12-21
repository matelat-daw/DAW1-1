namespace Examen_ETS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dni;
            string dniBaneado = "12345678Z";

            Console.WriteLine("Bienvenido al programa para verificar el DNI.\n");
            do // Hacer.
            {
                Console.Write("Por Favor Introduce tu D.N.I.: ");
                dni = Console.ReadLine();
                bool error;
                try // Después de leer el DNI del teclado, provoco una excepción si el tamaño de la cadena es distinta de 9.
                {
                    if (dni.Length != 9) // Condición para saber si el tamaño de la cadena dni es distinta de 9
                    {
                        throw new Exception(); // Si es Distinta arrojo una excepción.
                    }
                    error = false; // Si no hay error pongo el booleano error a false.
                }
                catch (Exception err) // Capturo el error
                {
                    Console.WriteLine("\nLo siento Este Programa Solo Valida D.N.I de Tamaño 9, El D.N.I. debe seguir el formato: 12345678Z\n"); // Muestro el mensaje de error.
                    error = true; // Pongo el booleano error a true.
                }
                try
                {
                    if (dni == dniBaneado)
                    {
                        throw new Exception(); // Si los DNI son Iguales arrojo una excepción.
                    }
                    error = false; // Si no hay error pongo el booleano error a false.
                }
                catch (Exception err)
                {
                    Console.WriteLine("El Usuario que Intenta Registrar con D.N.I.: {0}, Está Baneado de la Aplicación.", dni);
                    error = true; // Pongo el booleano error a true.
                }
                if (dni != "0" && !error) // Si dni es distinto de 0 y no hubo error.
                {

                    var result = CheckDNI(dni); // Asigno a la variable result el resultado de la función CheckDNI(dni), devuelve un booleano.
                    if (result) // Si result es true.
                    {
                        Console.WriteLine("\nEl DNI introducido es correcto.\n"); // El DNI es Correcto.
                    }
                    else // Si No.
                    {
                        Console.WriteLine("\nEl DNI introducido no es correcto. Por Favor Introducelo de Nuevo.\n"); // El DNI es Incorrecto introdúcelo denuevo.
                    }
                }
            }
            while (dni != "0"); // Mientras dni sea distitno del string "0".
        }

        static bool CheckDNI(string dni)
        {
            //Comprobamos si el DNI tiene 9 digitos
            if (dni.Length != 9) { return false; }

            //Extraemos los números y la letra
            string dniNumbers = dni.Substring(0, dni.Length - 1);
            string dniLeter = dni.Substring(dni.Length - 1, 1);
            //Intentamos convertir los números del DNI a integer
            var numbersValid = int.TryParse(dniNumbers, out int dniInteger);
            if (!numbersValid)
            {
                //No se pudo convertir los números a formato númerico
                // return true; // Esta Línea está mal, aquí debería devolver false.
                return false; // Devuelve false, el número no es valido
            }
            if (CalculateDNILeter(dniInteger) != dniLeter)
            {
                //La letra del DNI es incorrecta
                // return true; // Esta Línea está mal, aquí debería devolver false.
                return false; // Si La Llamada a la Función CalculateDNILeter(number) no Retorna la Letra Correcta, esta Condición Debe Devolver false.
            }
            //DNI Valido :)
            // return false; // Esta Línea está mal, aquí debería devolver true.
            return true; // Si no se Cumplen las Dos Condiciones Anteriores devuelve true.
        }


        static string CalculateDNILeter(int dniNumbers)
        {
            //Cargamos los digitos de control
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = dniNumbers % 23;
            return control[mod];
        }
    }
}