/*
 * Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:

    Calculates the sum of the digits (in our example 2+0+1+1 = 4).
    Prints on the console the number in reversed order: dcba (in our example 1102).
    Puts the last digit in the first position: dabc (in our example 1201).
    Exchanges the second and the third digits: acbd (in our example 2101).

The number has always exactly 4 digits and cannot start with 0. Examples: 
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace ForDigit
{
    class ForDigit
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            
            //sum
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum += (int)Char.GetNumericValue(a.ToString().ToCharArray()[i]);
            }
            Console.WriteLine(sum);
            
            // reverse 1 type
            char[] b = a.ToString().ToCharArray();
            Array.Reverse(b);
            Console.WriteLine(new string(b));
            
            // reverse 2 type
            b = new char[4];
            for (int i = 4; i > 0; i--)
            {
                b[Math.Abs(i - 4)] = a.ToString().ToCharArray()[i - 1];
            }
            Console.WriteLine(b);

            // last to first
            for (int i = 4; i > 0; i--)
            {
                if (i == 4) 
                {
                    b[i - 4] = a.ToString().ToCharArray()[i - 1];
                }
                else 
                {
                    b[Math.Abs(i - 4)] = a.ToString().ToCharArray()[Math.Abs(i - 4 + 1)];
                }
            }
            Console.WriteLine(b);

            // exchange second and third using a Binary XOR Swap

            b = a.ToString().ToCharArray();
            b[1] ^= b[2] ^= b[1];
            b[2] ^= b[1];
            Console.WriteLine(b);


            // creating a int array
            int[] digits = a.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray(); // Select() => using System.Linq;
            Array.ForEach(digits, x => Console.Write(x)); // print array in one line
            Console.WriteLine(); // blank line

            /*
             * To take it to the next level and you want to convert an unknown string
             * you can use regex to strip out non numeric characters. 
             * Code (Text):
             * int[] digits = Regex.Replace(numberToParse, "[^0-9]", "").Select(x => (int)Char.GetNumericValue(x)).ToArray();
             * 
             */

        }
    }
}
