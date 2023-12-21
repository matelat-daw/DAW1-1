
namespace Concatenar_Arrays
{
    internal class Funciones
    {
        internal static double[] concatena(double[] a, double[] b)
        {
            int i;
            int j;
            double[] c = new double[a.Length + b.Length];

            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }

            for (j = 0; j < b.Length; j++, i++)
            {
                c[i] = b[j];
            }
            return c;
        }

        internal static double[] merge(double[] a, double[] b)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            double[] c = new double[a.Length + b.Length];

            while (i < a.Length && j < b.Length)
            {
                if (a[i] <= b[j])
                {
                    c[k] = a[i];
                    i++;
                }
                else
                {
                    c[k] = b[j];
                    j++;
                }
                k++;
            }

            while (i < a.Length)
            {
                c[k] = a[i];
                k++;
                i++;
            }

            while (j < b.Length)
            {
                c[k] = b[j];
                k++;
                j++;
            }
            return c;
        }

        internal static void mostrar(double[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                if (i < result.Length - 1)
                {
                    Console.Write("{0}, ", result[i]);
                }
                else
                {
                    Console.Write("{0}.\n", result[i]);
                }
            }
        }
    }
}