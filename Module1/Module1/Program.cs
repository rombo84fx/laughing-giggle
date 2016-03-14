using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            DateTime birthdate;
            string addressLine1;
            string addressLine2;
            string city;
            string stateProvince;
            string zipPostal;
            string country;

            firstName = "Gerardo";
            lastName = "Martinez";
            birthdate = new DateTime(1984, 5, 7);
            addressLine1 = "Evergureen 123";
            addressLine2 = "Somewhere";
            city = "New York";
            stateProvince = "New York";
            zipPostal = "134945RE";
            country = "Mexico";

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

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }
    }
}
