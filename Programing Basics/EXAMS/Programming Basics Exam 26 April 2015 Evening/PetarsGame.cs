using System;
using System.Numerics;

namespace PetarsGame
{
    class PetarsGame
    {
        static void Main(string[] args)
        {
            ulong start = ulong.Parse(Console.ReadLine());
            ulong stop = ulong.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            BigInteger sum = 0;
            for (ulong i = start; i < stop; i++)
            {
                if (i % 5 == 0) { sum += i; }
                else { sum += (i % 5); }
            }
            if (sum % 2 == 0)
            {
                Console.WriteLine(sum.ToString().Replace(sum.ToString().ToCharArray()[0].ToString(), str));
            }
            else
            {
                Console.WriteLine(sum.ToString().Replace(sum.ToString().ToCharArray()[sum.ToString().Length - 1].ToString(), str));
            }
        }
    }
}
