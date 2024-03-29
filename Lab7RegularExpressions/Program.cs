﻿using System;
using System.Text.RegularExpressions;

namespace Lab7RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool namePass = ValidateNames();
            if (namePass == true)
            {
                Console.WriteLine(namePass);
            }
            else
            {
                Console.WriteLine("Sorry, name is not valid");
            }

            bool emailPass = ValidateEmails();
            if (emailPass == true)
            {
                Console.WriteLine(emailPass);
            }
            else
            {
                Console.WriteLine("Sorry, email is not valid");
            }

            bool phonePass = ValidatePhone();
            if (phonePass == true)
            {
                Console.WriteLine(phonePass);
            }
            else
            {
                Console.WriteLine("Sorry, phone number is not valid");
            }

            bool datePass = ValidateDate();
            if (datePass == true)
            {
                Console.WriteLine(datePass);
            }
            else
            {
                Console.WriteLine("Sorry, date is not valid");
            }
        }
        public static bool ValidateNames()
        {
            Console.WriteLine("Please type a first or last name below and press enter, it should be capitalized.");
            string name = Console.ReadLine();
            bool namePass = Regex.IsMatch(name, @"^([A-Z]{1})+([a-z]{2,})$");
            return namePass;
        }
        public static bool ValidateEmails()
        {
            Console.WriteLine("Please type your email and then press enter");
            string userEmail = Console.ReadLine();
            bool emailPass = Regex.IsMatch(userEmail, @"^(.[A-Za-z0-9]{5,30})@([A-Za-z0-9]{5,10})+[.]+([A-Za-z0-9]{2,3})$");
            return emailPass;
        }
        public static bool ValidatePhone()
        {
            Console.WriteLine("Please input a ten digit phone number with no spaces.");
            string phoneNumber = Console.ReadLine();
            bool phonePass = Regex.IsMatch(phoneNumber, @"^([0-9]{1,3})+[-]+([0-9]{1,3})+[-]+([0-9]{1,4})|([0-9]{1,3})([0-9]{1,3})([0-9]{1,4})$");
            return phonePass;
        }
        public static bool ValidateDate()
        {
            Console.WriteLine("Please input a date using this format: dd/mm/yyy");
            string date = Console.ReadLine();
            bool datePass = Regex.IsMatch(date, @"^(0?[1-9]|[0-2])/(0?[1-9]|1[0-9]|2[0-9]|3[01])/\d{4}$");
            //This will include values from 01-12 (includes the values with 0's infront of them.) and d{4} is any number from 0000 to 9999.
            return datePass;
        }
    }
}
