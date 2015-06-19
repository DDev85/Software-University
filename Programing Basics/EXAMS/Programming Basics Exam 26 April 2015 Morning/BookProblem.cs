using System;

namespace BookProblem
{
    class BookProblem
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine()); // pages of book
            int camping = int.Parse(Console.ReadLine()); // camping days in a month
            int read = int.Parse(Console.ReadLine()); // read per day
            if ((30 - camping) <= 0) { Console.WriteLine("never"); }
            else
            {
                double months = Math.Ceiling((double)pages / ((30 - camping) * read));
                double years = months / 12;
                months = (int)Math.Ceiling(months - (int)years * 12);
                Console.WriteLine("{0} years {1} months", (int)years, months);
            }
        }
    }
}
