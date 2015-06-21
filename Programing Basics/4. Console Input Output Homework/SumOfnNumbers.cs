using System;

namespace SumOfnNumbers
{
    class SumOfnNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int numbers = int.Parse(Console.ReadLine());
            double num = 0;
            for (int i = 0; i < numbers; i++)
            {
                num += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum is: " + num);
        }
    }
}
