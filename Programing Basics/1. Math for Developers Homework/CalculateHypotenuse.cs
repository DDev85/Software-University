/*
 * Програма за смятане на хипотенузата на правоъгълен триъгълник при дадени 2 страни.
 * Димитър Желязков - https://github.com/DDev85
 * 
 */

using System;

namespace CalcHypotenuse
{
    class CalculateHypotenuse
    {
        static void Main(string[] args)
        {
            bool loop = true;
            Console.WriteLine("Програма за намиране на хипотенуза (Питагорова теорема). За изход въведете 0 за всеки от катетите.");
            while (loop)
            {
                Console.WriteLine();
                Console.Write("Въведи дължината на катет 1: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Въведи дължината на катет 2: ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (a == 0 || b == 0) { loop = false; }
                else
                {
                    Console.WriteLine("Хипотенузата е с дължина: " + Math.Sqrt(a * a + b * b));
                }
            }
        }
    }
}
