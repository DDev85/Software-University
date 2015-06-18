using System;
using System.Linq;
using System.Collections.Generic;




namespace EncryptTheMessages
{
    class EncryptMessages
    {
        static void Main(string[] args)
        {
            //a   b 	c 	d 	e 	f 	g 	h 	i 	j 	k 	l 	m 	n 	o 	p 	q 	r 	s 	t 	u 	v 	w 	x 	y 	z
            char[] chars =  { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' ', ',', '.', '?', '!',
                              
                              'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', '+', '%', '&', '#', '$'
                               
                            };
          
            //Console.Write("Write START or start to send messages: ");
            string start = Console.ReadLine();
            while (start != "START" && start != "start")
            {
                //Console.Write("Write START or start to send messages: ");
                start = Console.ReadLine();  
            }
            List<string> messages = new List<string>();
            while (start != "END" && start != "end")
            {
                //Console.Write("Write messages: ");
                start = Console.ReadLine();
                if (start != "") { messages.Add(start); }
            }
            if (messages.Count > 1)
            {
                Console.WriteLine("Total number of messages: {0}", messages.Count - 1);
            }
            else
            {
                Console.WriteLine("No messages sent.");
            }

            for (int i = 0; i < messages.Count - 1; i++)
            {
                char[] messagesChar = messages[i].ToCharArray();
                for (int c = 0; c < messagesChar.Length; c++)
                {
                    for (int b = 0; b < chars.Length / 2; b++)
                    {
                        if (messagesChar[c] == chars[b])
                        {
                            messagesChar[c] = chars[chars.Length / 2 + b];
                            break;
                        }
                    }
                }
                Array.Reverse(messagesChar);
                messages[i] = new string(messagesChar);
            }

            for (int i = 0; i < messages.Count - 1; i++)
            {
                Console.WriteLine(messages[i]);
            }
            
        
        }
    }
}
