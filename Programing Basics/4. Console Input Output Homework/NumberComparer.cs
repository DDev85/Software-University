using System;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Enter Number 1: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("The greater is: {0}", a > b ? a : b);
        }
    }
}
