using System;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? integer = null;
            double? Double= null;
            Console.WriteLine("(1) Integer value: {0}\r\nDouble value: {1}\r\n", integer, Double);
            integer += 56;
            Double += 65.65;
            Console.WriteLine("(2) Integer value: {0}\r\nDouble value: {1}\r\n", integer, Double);
            integer = 56;
            Double = 65.65;
            Console.WriteLine("(3) Integer value: {0}\r\nDouble value: {1}\r\n", integer, Double);
        }
    }
}
