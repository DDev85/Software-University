using System;

namespace StringsAndObjects
{
    class StringAndObjects
    {
        static void Main(string[] args)
        {
            string myHello = "Hello";
            string myWorld = "World";
            object myObject = myHello + " " + myWorld;
            Console.WriteLine(myObject);
            string getObject = (string)myObject; // OR string getObject = myObject.ToString();
            Console.WriteLine(getObject);
        }
    }
}
