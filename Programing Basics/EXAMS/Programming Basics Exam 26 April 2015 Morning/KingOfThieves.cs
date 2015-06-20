using System;

namespace KingOfThieves
{
    class KingOfThieves
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] g = Console.ReadLine().ToCharArray();

           
            char[] array = new string('-',n).ToCharArray();
            array[n / 2] = g[0];
            Console.WriteLine(array);
            for (int i = 1; i <= n/2; i++)
            {
                array[(n / 2) - i] = g[0];
                array[(n / 2) + i] = g[0];
                Console.WriteLine(array);
            }
            for (int i = 0; i <= n / 2 - 1; i++)
            {
                array[i] = '-';
                array[n - i - 1 ] = '-';
                Console.WriteLine(array);
            }

        }
    }
}
