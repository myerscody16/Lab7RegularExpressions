using System;
using System.Text.RegularExpressions;

namespace Lab7RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool namePass = ValidateNames();
            Console.WriteLine(namePass);

            bool emailPass = ValidateEmails();
            Console.WriteLine(emailPass);

            bool phonePass = ValidatePhone();
            Console.WriteLine(phonePass);

            bool datePass = ValidateDate();
            Console.WriteLine(datePass);

            bool webAddressPass = ValidateWebSite();
            Console.WriteLine(webAddressPass);

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
            bool emailPass = Regex.IsMatch(userEmail, @"^([a-z]{5,30})|([0-9]{1,})@([a-z]{5,10})+[.]+([a-z]{2,3})$");
            return emailPass;
        }
        public static bool ValidatePhone()
        {
            Console.WriteLine("Please input a nine digit phone number with no spaces.");
            string phoneNumber = Console.ReadLine();
            bool phonePass = Regex.IsMatch(phoneNumber, @"^([0-9]{1,3})+([0-9]{1,3})+([0-9]{1,4})$");
            return phonePass;
        }
        public static bool ValidateDate()
        {
            Console.WriteLine("Please input a date using this format: dd/mm/yyy");
            string date = Console.ReadLine();
            bool datePass = Regex.IsMatch(date, @"^$");
            return datePass;
        }
        public static bool ValidateWebSite()
        {
            Console.WriteLine("Please input a web address.");
            string webAddress = Console.ReadLine();
            bool webAddressPass = Regex.IsMatch(webAddress, @"^$");
            return webAddressPass;
        }

    }
}
