using System;

namespace BankAccountsData
{
    class BankAccountsData
    {
        static void Main(string[] args)
        {
            string firstName = "Todor";
            string middleName = "Ivanov";
            string lastName = "Todorov";
            decimal money = 300560.63m;
            string bankName = "FIBank";
            string iban = "BG32 FIBS 8887 8888 8888 88";
            long cardNumber1 = 123456789999999;
            long cardNumber2 = 123456789999999;
            long cardNumber3 = 123456789999999;
            Console.WriteLine("{0} {1} {2}\nAvailable amount of money: " +
                              "{3}\n{4} IBAN: {5}\nCard number: {6}\nCard number: " +
                              "{7}\nCard number: {8}",
                firstName,
                middleName,
                lastName,
                money,
                bankName,
                iban,
                cardNumber1,
                cardNumber2,
                cardNumber3);
        }
    }
}
