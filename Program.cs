using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Sharp_Module_1_Lab_1_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";
            int age = 0;
            string street = "";
            string city = "";
            string country = "";
            DateTime birthdate;

            firstName = "Johnny";
            lastName = "Henderson";
            age = 65;
            street = "First Street";
            city = "Waco";
            country = "United States";
            birthdate = new DateTime(1952, 08, 14);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            //Write out the age
            Console.WriteLine("{0} years old", age);

            //String Concatenation
            Console.WriteLine(street + ", " + city + ", " + country);

            //String Interpolation
            Console.WriteLine($"Born on {birthdate}");

        }
    }
}
