﻿using System;

namespace LongSequence
{
    class LongSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i * -1);
                }
            }
        }
    }
}
