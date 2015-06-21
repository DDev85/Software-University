using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersDividableFive
{
    class NumbersDividableFive
    {
        static void Main(string[] args)
        {
            int a, b, count = 0;
            Console.Write("Enter start number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter end number: ");
            b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0) { count++; }
            }
            Console.WriteLine(count + " numbers devidet by 5 !");
        }
    }
}
