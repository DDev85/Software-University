using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For exit type 0 for each number!");
            bool loop = true;
            while (loop)
            {
                Console.Write("Enter first number: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                double b = double.Parse(Console.ReadLine());
                bool compare = (Math.Abs(a - b) < 0.000001);
                if (compare) { Console.WriteLine(compare); }
                else { Console.WriteLine(compare); }
                if (a == 0 && b == 0) { loop = false; }
            }
        }
    }
}
