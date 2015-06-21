using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                Console.Write("{0} ", Fibonacci(i));
            }
            Console.WriteLine();
        }
        private static int Fibonacci(int n)
        {
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
