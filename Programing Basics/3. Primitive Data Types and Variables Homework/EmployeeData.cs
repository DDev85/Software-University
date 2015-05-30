using System;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Todor";
            string lastName = "Todorov";
            sbyte age = 30;
            char geneder = 'm';
            long idNumber = 8306112507;
            int empNumber = 27569999;
            Console.WriteLine("Firstname: {0}\r\nLastname: {1}\r\nAge: {2}\r\nGender: {3}\r\nIdentification Number: {4}\r\nEmployee Number: {5}",
                firstName,
                lastName,
                age,
                geneder,
                idNumber,
                empNumber);
        }
    }
}
