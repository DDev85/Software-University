using System;

namespace DeclareVariables
{
    class DeclareVariables
    {
        static void Main(string[] args)
        {
            ushort myUshort = 52130;
            sbyte mySbyte = -115;
            int myInt = 4825932;
            byte myByte = 97;
            short myShort = -10000;

            Console.WriteLine(" ushort: {0}\r\n sbyte: {1}\r\n int: {2}\r\n byte: {3}\r\n short: {4}",
                myUshort,
                mySbyte,
                myInt,
                myByte,
                myShort);
        }
    }
}
