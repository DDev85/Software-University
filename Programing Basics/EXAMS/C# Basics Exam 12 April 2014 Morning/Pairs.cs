using System;
using System.Collections.Generic;
using System.Linq;



namespace Pairs
{
    class Pairs
    {
        static void Main(string[] args)
        {
            int[] intArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();
            //Array.ForEach(intArray, x => Console.WriteLine(x));
            int[] temp = new int[intArray.Length / 2];
            int br = 0;
            for (int i = 0; i < intArray.Length - 1; i += 2)
            {
                temp[br] = intArray[i] + intArray[i + 1];
                br++;
            }
            //Array.ForEach(temp, x => Console.WriteLine(x));
            if (Equals(temp)) { Console.WriteLine("Yes, value=" + temp[0]); }
            else { Console.WriteLine("No, maxdiff=" + maxDiff(temp)); }
        }
        private static bool Equals(int[] arr)
        {
            int t = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                t = arr[i] - arr[i + 1];
            }
            if (t == 0) { return true; }
            else { return false; }
        }

        private static int maxDiff(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                temp = Math.Max(Math.Abs(arr[i] - arr[i + 1]), temp);
            }
            return temp;
        }
    }
}
