using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Program
    {
        static string firstName;
        static string lastName;
        static DateTime birthdate;
        static string addressLine1;
        static string addressLine2;
        static string city;
        static string stateProvince;
        static string zipPostal;
        static string country;

        static void Main(string[] args)
        {
            requestInfo();
            displayInfo();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        private static void requestInfo()
        {
            Console.WriteLine("Enter student first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter student last name:");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter student birthdate:");
            birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter student address line 1:");
            addressLine1 = Console.ReadLine();
            Console.WriteLine("Enter student address line 2:");
            addressLine2 = Console.ReadLine();
            Console.WriteLine("Enter student city:");
            city = Console.ReadLine();
            Console.WriteLine("Enter student state/province:");
            stateProvince = Console.ReadLine();
            Console.WriteLine("Enter student zip/postal:");
            zipPostal = Console.ReadLine();
            Console.WriteLine("Enter student country:");
            country = Console.ReadLine();
        }

        private static void displayInfo()
        {
            Console.WriteLine("Student information");
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Birthdate: {birthdate.ToShortDateString()}");
            Console.WriteLine($"Addess line 1: {addressLine1}");
            Console.WriteLine($"Addess line 2: {addressLine2}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"State/Province: {stateProvince}");
            Console.WriteLine($"Zip/Postal: {zipPostal}");
            Console.WriteLine($"Country: {country}");
        }
    }
}
