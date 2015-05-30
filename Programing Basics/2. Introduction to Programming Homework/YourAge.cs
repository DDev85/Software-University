using System;

namespace YourAge
{
    class YourAge
    {
        static void Main(string[] args)
        {
            int today_year = DateTime.Now.Year;
            Console.Write("Въведете Година: ");
            int your_year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вие сте на {0} а след 10 години ще сте на {1}", today_year - your_year, today_year - your_year + 10);
        }
    }
}
