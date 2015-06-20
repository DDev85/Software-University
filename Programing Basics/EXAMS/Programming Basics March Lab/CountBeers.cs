using System;

namespace CountBeers
{
    class CountBeers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int stacks = 0, beers = 0;
            while (input != "End")
            {
                string[] words = input.Split(' ');
                if (words[1] == "stacks") { stacks += int.Parse(words[0]); }
                else if (words[1] == "beers") { beers += int.Parse(words[0]); }
                input = Console.ReadLine();
            }
            stacks += beers / 20; beers = beers % 20; 
            Console.WriteLine("{0} stacks + {1} beers", stacks, beers);
            
        }
    }
}
