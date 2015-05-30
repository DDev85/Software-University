using System;

namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string firstString = "The \"use\" of quotations causes difficulties.";
            string secondString = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine("{0}\r\n{1}",
                firstString,
                secondString);
        }
    }
}
