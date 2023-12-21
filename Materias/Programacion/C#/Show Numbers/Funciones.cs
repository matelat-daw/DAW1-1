
namespace Show_Numbers
{
    internal class Funciones
    {
        internal static void numberList()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i < 100)
                {
                    Console.Write("{0}, ", i);
                }
                else
                {
                    Console.Write("{0}.", i);
                }
            }
        }

        internal static int numberListRecursive(int num)
        {
            if (num < 100)
            {
                Console.Write("{0}, ", numberListRecursive(++num));
            }
            Console.Write("{0}.", num);
            return 0;
        }
    }
}