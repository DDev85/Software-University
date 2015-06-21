using System;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            int a;
            double b, c;
            Console.Write("Enter number 1: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter number 3: ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("|{0,-10:X}|{1}|{2,10:.##}|{3,-10:F3}|", a, Convert.ToString(a,2).PadLeft(10,'0'), b, c);
        }
    }
}
