using System;

namespace CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter is {0:F2}", 2 * 3.14159265359 * r);
            Console.WriteLine("The area is {0:F2}", 3.14159265359 * Math.Pow(r,2));
        }
    }
}
