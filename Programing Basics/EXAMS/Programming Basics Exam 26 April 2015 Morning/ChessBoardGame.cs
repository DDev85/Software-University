using System;

namespace ChessBoardGame
{
    class ChessBoardGame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), W = 0, B = 0;
            char[] strArray = Console.ReadLine().ToCharArray();
            for (int i = 0; i < strArray.Length; i++)
            {
                if (i >= n * n) { break; }
                if (i % 2 == 0 && char.IsUpper(strArray[i])) { W += strArray[i]; }
                else if(i % 2 != 0 && char.IsUpper(strArray[i])) { B+= strArray[i]; }
                else if(i % 2 == 0 && char.IsLetterOrDigit(strArray[i])) { B+= strArray[i]; }
                else if(i%2 != 0 && char.IsLetterOrDigit(strArray[i])) {W+=strArray[i];}
            }
            if (B == W) { Console.WriteLine("Equal result: {0}", W); }
            else
            {
                Console.WriteLine("The winner is: {0} team", W > B ? "white" : "black");
                Console.WriteLine(Math.Abs(B-W));
            }
        }
    }
}
