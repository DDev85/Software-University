using System;

namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            // define 
            string companyName, companyAdress, phoneNumber,
                   faxNumber, webSite, managerFirstName,
                   managerLastName, managerAge, managerPhone;

            // input
            Console.Write("Company name: ");
            companyName = Console.ReadLine();

            Console.Write("Company Adress: ");
            companyAdress = Console.ReadLine();

            Console.Write("Phone number: ");
            phoneNumber = Console.ReadLine();

            Console.Write("Fax number: ");
            faxNumber = Console.ReadLine();

            Console.Write("Web site: ");
            webSite = Console.ReadLine();

            Console.Write("Manager first name: ");
            managerFirstName = Console.ReadLine();

            Console.Write("Manager last name: ");
            managerLastName = Console.ReadLine();

            Console.Write("Manager age: ");
            managerAge = Console.ReadLine();

            Console.Write("Manager phone: ");
            managerPhone = Console.ReadLine();

            // output
            Console.WriteLine();
            Console.WriteLine(companyName);
            Console.WriteLine("Adress: {0}", companyAdress);
            Console.WriteLine("Tel. {0}", phoneNumber);
            Console.WriteLine("Fax: {0}", faxNumber != "" ? faxNumber : "(no fax)");
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",
                managerFirstName, managerLastName, managerAge, managerPhone);
        }
    }
}
