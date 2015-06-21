using System;

namespace SumOfThreeNumbers
{
    class SumOfThreeNumbers
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Enter number 1: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter number 3: ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("The sum of numbers are: {0}", (a + b + c));
        }
    }
}
