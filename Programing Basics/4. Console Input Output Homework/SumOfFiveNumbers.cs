using System;
using System.Linq;

namespace SumOfFiveNumbers
{
    class SumOfFiveNumbers
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            double sum = 0;
            int len = input.Length;
            for (int i = 0; i < len; i++)
            {
                sum += input[i];
            }
            Console.WriteLine(sum);
        }
    }
}
