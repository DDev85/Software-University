using System;

namespace JoroTheFootballPlayer
{
    class JoroTheFootballPlayer
    {
        static void Main(string[] args)
        {
            int weekends = 52;
            Console.Write("Enter year leap: ");
            string leap = Convert.ToString(Console.ReadLine());
            Console.Write("Enter number of holidays: ");
            int holidays = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of weekends in hometown: ");
            int hometowns = Convert.ToInt32(Console.ReadLine());
            int answer = (weekends - hometowns) * 2 / 3;
            answer += hometowns;
            answer += holidays * 1 / 2;
            if (leap == "t") { answer += 3; }
            Console.WriteLine("Answer: " + answer);  
        }
    }
}
