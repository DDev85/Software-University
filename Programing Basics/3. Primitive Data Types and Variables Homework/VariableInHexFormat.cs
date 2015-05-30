using System;

namespace VariableInHexFormat
{
    class VariableInHexFormat
    {
        static void Main(string[] args)
        {
            int hexVariable = 0xFE;
            Console.WriteLine("Decimal variable of 0x{0:X} is: {0}", hexVariable);            
        }
    }
}
