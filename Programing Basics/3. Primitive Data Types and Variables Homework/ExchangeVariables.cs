using System;

namespace ExchangeVariables
{
    class ExchangeVariables
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before exchange a={0} and b={1}", a, b);
            a ^= b ^= a;
            b ^= a;
            Console.WriteLine("After exchange a={0} and b={1}", a, b);
        }
    }
}
