using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a, b, c, D;
            
            //input
            Console.Write("Enter A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter C: ");
            c = double.Parse(Console.ReadLine());

            // Calculate Discriminant
            D = Math.Pow(b, 2) - (4 * a * c);
            if (D < 0) { Console.WriteLine("no real roots"); }
            else if (D == 0) { Console.WriteLine("x1=x2={0}", (-b / (2 * a))); }
            else { Console.WriteLine("x1={0} x2={1}", ((-b - Math.Sqrt(D)) / (2 * a)), ((-b + Math.Sqrt(D)) / (2 * a))); }
        }
    }
}
