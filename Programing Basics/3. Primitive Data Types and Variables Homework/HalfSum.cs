using System;

namespace HalfSum
{
    class HalfSum
    {
        static void Main(string[] args)
        {
            int first = 0;
            int second = 0;
            Console.Write("Enter how many numbers: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter first {0} numbers. Number {1}: ", n,i);
                first += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter second {0} numbers. Number {1}: ", n, i);
                second += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            if (first == second)
            {
                Console.WriteLine("Yes, Sum={0}", first);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(first-second));
            }
        }
    }
}
