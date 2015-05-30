/*
 * Програмата брои прости числа.
 * Димитър Желязков - https://github.com/DDev85
 */
using System;


namespace FindSomePrimes
{
    class SomePrimes
    {
        public bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;    
            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        
       {
            Console.Write("Въведете позиция: ");
            int br = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= br; i++)
            {
                SomePrimes Prime = new SomePrimes();
                if (Prime.isPrime(i)) { Console.WriteLine(i + " е просто число!"); }
                else { Console.WriteLine(i + " не е просто число!"); br++; }
            }
        }
    }
}
