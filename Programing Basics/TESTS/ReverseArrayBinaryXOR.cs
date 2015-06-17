/*
 * Reversing types using Binnary XOR Swap 
 * by DimiturJeliazkov
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseArrayBinaryXOR
{
    class ReverseArrayBinaryXOR
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 33, 4, 5, 66, 7, -8, 9000, 1 };
            char[] charArray = { 'H', 'o', 'M', 'e' };
            string[] stringArray = { "Lets", "go", "home" }; // Cant reverse Binnary XOR Swap
            string str = "Lets go home !";  //Cant reverse words in string using Binnary XOR Swap
            int integer = 123456789;

            // reverse int array
            Array.ForEach(intArray, x => Console.Write(x + " "));
            Console.Write("=> ");
            int len = intArray.Length - 1;
            for (int i = 0; i < len; i++, len--)
            {
                intArray[i] ^= intArray[len] ^= intArray[i];
                intArray[len] ^= intArray[i];
            }
            Array.ForEach(intArray, x => Console.Write(x + " "));
            Console.WriteLine();

            // reverse char array
            Array.ForEach(charArray, x => Console.Write(x));
            Console.Write(" => ");
            len = charArray.Length - 1;
            for (int i = 0; i < len; i++, len--)
            {
                charArray[i] ^= charArray[len] ^= charArray[i];
                charArray[len] ^= charArray[i];
            }
            Array.ForEach(charArray, x => Console.Write(x));
            Console.WriteLine();

            // reverse string chars
            Console.Write("Lets go home ! => ");
            char[] strChar = str.ToCharArray();
            len = strChar.Length - 1;
            for (int i = 0; i < len; i++, len--)
            {
                strChar[i] ^= strChar[len] ^= strChar[i];
                strChar[len] ^= strChar[i];
            }
            Array.ForEach(strChar, x => Console.Write(x));
            Console.WriteLine();

            //reverse integer
            Console.Write("123456789 => ");
            int[] integerChar = integer.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            len = integerChar.Length - 1;
            for (int i = 0; i < len; i++, len--)
            {
                integerChar[i] ^= integerChar[len] ^= integerChar[i];
                integerChar[len] ^= integerChar[i];
            }
            Array.ForEach(integerChar, x => Console.Write(x));
            Console.WriteLine();
        }
    }
}
