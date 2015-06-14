using System;


namespace CompoundInterest
{
    class CompoundInterest
    {
        
        static void Main(string[] args)
        {
            decimal P = decimal.Parse(Console.ReadLine()); // Price of the TV
            int N = int.Parse(Console.ReadLine()); // Credit years
            decimal I = decimal.Parse(Console.ReadLine()); // Bank loan
            decimal F = decimal.Parse(Console.ReadLine()); // Friend loan

            decimal BankResult = MoneyBank(P, N, I);
            decimal FriendResult = MoneyFriend(P, F);
            Console.WriteLine("{0:F2} {1}", Math.Min(BankResult,FriendResult), BankResult < FriendResult ? "Bank" : "Friend" );
        }
        /*
         * 2600 leva is needed. Bank loan = 2600 * (1 + 0.07) 2 = 2600 * 1.07 2 = 2600 * 1.1449 = 2976.74. 
         * Friend loan = 2600 * (1 + 0.4) = 2600 * 1.4 = 3640. 2976.74 < 3640
         */
        private static decimal MoneyBank(decimal TV, int CY, decimal BL)
        {
            return (decimal)(TV * (decimal)Math.Pow((1+(double)BL),(double)CY));
        }
        private static decimal MoneyFriend(decimal TV, decimal FL)
        {
            return (decimal)(TV * (1 + FL));
        }
    }
}
