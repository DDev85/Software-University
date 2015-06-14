using System;


namespace TheSun
{
    class Sunlight
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // construct string 

            string sunlight = new string('.', (n * 3));
            char[] star = sunlight.ToCharArray(); ;
            int len = sunlight.Length;

            // print first

            for (int i = 1; i < len / 2; i++)
            {
                
                if (i < n)
                {
                    char[] temp = sunlight.ToCharArray();
                    if (i == 1) { temp[len / 2] = '*'; Console.WriteLine(temp); }
                    temp[i] = '*';
                    temp[len - 1 - i] = '*';
                    temp[len / 2] = '*';
                    Console.WriteLine(temp);
                }
                else
                {
                    for (int f = 0; f < n / 2; f++)
                    {
                        star[i + f] = '*';
                        star[len - 1 - i - f] = '*';
                        star[len / 2] = '*';
                    }
                    Console.WriteLine(star); 
                }
                
                
            }

            // print second

            sunlight = new string('*', n * 3);
            star = sunlight.ToCharArray(); 
            len = sunlight.Length;
            
            Console.WriteLine(sunlight); // print the middle

            for (int i = 1; i <= len / 2; i++)
            {
                if (i <= n / 2 )
                {
                    for (int f = 0; f < n; f++)
                    {
                        star[f] = '.';
                        star[len - 1 - f] = '.';
                    }
                    Console.WriteLine(star);
                }
                else if (i != len / 2)
                {
                    char[] temp = new string('.', n * 3).ToCharArray();
                    temp[len / 2 - i] = '*';
                    temp[len / 2] = '*';
                    temp[len / 2 + i] = '*';
                    Console.WriteLine(temp);
                }
                else
                {
                    char[] temp = new string('.', n * 3).ToCharArray();
                    temp[len / 2] = '*';
                    Console.WriteLine(temp);
                }
            }
                
        }
    }
}