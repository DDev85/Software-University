using System;
using System.Collections.Generic;

namespace DecryptTheMessages
{
    class DecryptTheMessages
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> specials = new Dictionary<char, char>
                {
                    {'+', ' '},
                    {'%', ','},
                    {'&', '.'},
                    {'#', '?'},
                    {'$', '!'}
                };
            //Console.Write("Enter Start: ");
            string start = Console.ReadLine();
            while (start != "START" && start != "start")
            {
                //Console.Write("Enter Start: ");
                start = Console.ReadLine();
            }
            //Console.Write("Enter word or end for stop: ");

            List<string> words = new List<string>();
            while (start != "END" && start != "end")
            {
                start = Console.ReadLine();
                if (start != "") { words.Add(start); }
            }

            for (int L = 0; L < words.Count - 1; L++)
            {
                char[] messagesChars = words[L].ToCharArray();
                for (int M = 0; M < messagesChars.Length; M++)
                {
                    char symbol = messagesChars[M];
                    if (specials.ContainsKey(symbol)) { messagesChars[M] = specials[symbol]; }
                    else if (65 <= symbol && symbol <= 77) { messagesChars[M] = (char)(messagesChars[M] + 13); }
                    else if (78 <= symbol && symbol <= 90) { messagesChars[M] = (char)(messagesChars[M] - 13); }
                    else if ('a' <= symbol && symbol <= 'm') { messagesChars[M] = (char)(messagesChars[M] + 13); }
                    else if ('n' <= symbol && symbol <= 'z') { messagesChars[M] = (char)(messagesChars[M] - 13); }
                }
                Array.Reverse(messagesChars);
                words[L] = new string(messagesChars);
            }
            if (words.Count > 1) { Console.WriteLine("Total number of messages: " + (words.Count - 1)); }
            else { Console.WriteLine("No message received."); }
            for (int i = 0; i < words.Count - 1; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
