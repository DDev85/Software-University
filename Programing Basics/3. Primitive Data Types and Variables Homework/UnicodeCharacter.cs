using System;

namespace UnicodeCharacter
{
    class UnicodeCharacter
    {
        static void Main(string[] args)
        {
            int decimalNumber = 42;    
            Console.WriteLine("Hexadecimal code of {0} is: {0:X} ", decimalNumber);
            char unicodeSymbol = '\u002A';
            Console.WriteLine("The unicode symbol is: {0}", unicodeSymbol);
        }
    }
}
