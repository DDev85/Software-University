/* 
 * Програмата проверява дали дадено чило е от редицата на Fibonacci.
 * Димитър Желязков - https://github.com/DDev85
 * 
 */

using System;

namespace isFibonacciNumber
{
    class CheckNumber
    {
        public bool isPerfectSquare(int x)
        {
            int s = Convert.ToInt32(Math.Sqrt(x));
            return (s * s == x);
        }
        public bool isFibonacci(int x)
        {
            return isPerfectSquare(5 * x * x + 4) || isPerfectSquare(5 * x * x - 4);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Провери числа дали са от редицата на Фибоначи - https://github.com/DDev85");
            bool loop = true;
            while (loop)
            {
                Console.WriteLine();
                Console.Write("Въведи число за проверка или 0 за изход: ");
                int s = Convert.ToInt32(Console.ReadLine());
                if (s != 0)
                {
                    CheckNumber Fi = new CheckNumber();
                    if (Fi.isFibonacci(s)) { Console.WriteLine(s + " - е Фибоначи"); } else { Console.WriteLine(s + " - не е Фибоначи"); }
                }
                else { loop = false; }
            }
        }
    }
}
