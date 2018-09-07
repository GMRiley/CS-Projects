using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolLib;
using CustomerLib;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer temp = new Customer();
            Validator Checker = new Validator();
            //CsTools tool = new CsTools();

            DateTime dateParse;
            String strTemp;
            Double dblTemp;
            Int32 intTemp;

            Console.WriteLine("What is your first name. ");
            Console.Write("Input: ");
            temp.FirstName = Console.ReadLine();
            while (temp.FirstName.Contains("ERROR:"))
            {
                Console.Clear();
                Console.WriteLine(temp.FirstName);
                Console.WriteLine("The string must not contain special characters or numbers.");
                Console.Write("Input:");
                temp.FirstName = Console.ReadLine();
            }

            Console.WriteLine("What is your middle name. ");
            Console.Write("Input: ");
            temp.MiddleName = Console.ReadLine();
            while (temp.MiddleName.Contains("ERROR:"))
            {
                Console.Clear();
                Console.WriteLine(temp.MiddleName);
                Console.WriteLine("The string must not contain special characters or numbers.");
                Console.Write("Input:");
                temp.MiddleName = Console.ReadLine();
            }

            Console.WriteLine("What is your last name.");
            Console.Write("Input: ");
            temp.LastName = Console.ReadLine();
            while (temp.LastName.Contains("ERROR:"))
            {
                Console.Clear();
                Console.WriteLine(temp.LastName);
                Console.WriteLine("The string must not contain special characters or numbers.");
                Console.Write("Input:");
                temp.LastName = Console.ReadLine();
            }

            Console.WriteLine("Enter Street Address 1.");
            Console.Write("Input: ");
            temp.StreetOne = Console.ReadLine();

            Console.WriteLine("Enter Street Address 2.");
            Console.Write("Input: ");
            temp.StreetTwo = Console.ReadLine();

            Console.WriteLine("Enter your City.");
            Console.Write("Input: ");
            temp.CityStr = Console.ReadLine();
            while (temp.CityStr.Contains("ERROR:"))
            {
                Console.Clear();
                Console.WriteLine(temp.CityStr);
                Console.WriteLine("The string must not contain special characters or numbers.");
                Console.Write("Input:");
                temp.CityStr = Console.ReadLine();
            }

            Console.WriteLine("Enter your State.");
            Console.Write("Input: ");
            temp.StateStr = Console.ReadLine();
            while (temp.StateStr.Contains("ERROR:"))
            {
                Console.Clear();
                Console.WriteLine(temp.StateStr);
                Console.WriteLine("The string must not contain special characters or numbers.");
                Console.Write("Input:");
                temp.StateStr = Console.ReadLine();
            }

            Console.WriteLine("Enter your Zip Code.");
            Console.Write("Input: ");
            temp.ZipStr = Console.ReadLine();
            while (temp.ZipStr.Contains("ERROR:"))
            {
                Console.Clear();
                Console.WriteLine(temp.ZipStr);
                Console.WriteLine("The string must not contain special characters, letters, and must meet a length of 5.");
                Console.Write("Input:");
                temp.ZipStr = Console.ReadLine();
            }

            Console.WriteLine("Enter your Home Phone.");
            Console.Write("Input: ");
            temp.PhoneStr = Console.ReadLine();
            while (temp.PhoneStr.Contains("ERROR:"))
            {
                Console.Clear();
                Console.WriteLine(temp.PhoneStr);
                Console.WriteLine("The string must not contain letters.");
                Console.Write("Input:");
                temp.PhoneStr = Console.ReadLine();
            }

            Console.WriteLine("Enter your Cell Phone.");
            Console.Write("Input: ");
            temp.CellPhone = Console.ReadLine();
            while (temp.CellPhone.Contains("ERROR:"))
            {
                Console.Clear();
                Console.WriteLine(temp.CellPhone);
                Console.WriteLine("The string must not contain letters.");
                Console.Write("Input:");
                temp.CellPhone = Console.ReadLine();
            }

            Console.WriteLine("Enter your Email Address.");
            Console.Write("Input: ");
            temp.EmailStr = Console.ReadLine();
            while(temp.EmailStr.Contains("ERROR:"))
            {
                Console.Clear();
                Console.WriteLine(temp.EmailStr);
                Console.WriteLine("The string did not follow a proper email format.");
                Console.Write("Input: ");
                temp.EmailStr = Console.ReadLine();
            }

            Console.WriteLine("Enter your FaceBook URL.");
            Console.Write("Input: ");
            temp.FaceBook = Console.ReadLine();
            while(temp.FaceBook.Contains("ERROR: "))
            {
                Console.Clear();
                Console.WriteLine(temp.FaceBook);
                Console.WriteLine("Must either contain facebook.com/ or fb.com/");
                temp.FaceBook = Console.ReadLine();
            }

            Console.WriteLine("At what date did you become a customer?");
            Console.Write("Input: ");
            strTemp = Console.ReadLine();
            while ((DateTime.TryParse(strTemp, out dateParse)) == false)
            {
                Console.Clear();
                Console.WriteLine("That is an incorrect value.");
                Console.Write("Enter a new value: ");
                strTemp = Console.ReadLine();
            }
            temp.CustomerSince = DateTime.Parse(strTemp);

            Console.WriteLine("How much have you spent?");
            strTemp = Console.ReadLine();
            while ((Double.TryParse(strTemp, out dblTemp)) == false)
            {
                Console.Clear();
                Console.WriteLine("That is an incorrect value.");
                Console.Write("Enter a new value: ");
                strTemp = Console.ReadLine();
            }
            temp.TotalPurchases = Double.Parse(strTemp);

            Console.WriteLine("Are you a Discount Member? (y/n)");
            Console.Write("Input: ");
            strTemp = Console.ReadLine();
            if (strTemp == "y" || strTemp == "Y")
                temp.DiscountMember = true;
            else
                temp.DiscountMember = false;

            Console.WriteLine("How many rewards have you earned?");
            Console.Write("Input: ");
            strTemp = Console.ReadLine();
            while ((Int32.TryParse(strTemp, out intTemp)) == false)
            {
                Console.Clear();
                Console.WriteLine("That is an incorrect value.");
                Console.Write("Enter a new value: ");
                strTemp = Console.ReadLine();
            }
            temp.RewardsEarned = Int32.Parse(strTemp);
            Console.Clear();

            Console.WriteLine("Your information: ");
            Console.WriteLine($"First Name: {temp.FirstName}");
            Console.WriteLine($"Middle Name: {temp.MiddleName}");
            Console.WriteLine($"First Name: {temp.FirstName}");
            Console.WriteLine($"Street Address 1: {temp.StreetOne}");
            Console.WriteLine($"Street Address 2: {temp.StreetTwo}");
            Console.WriteLine($"City Name: {temp.CityStr}");
            Console.WriteLine($"State Name: {temp.StateStr}");
            Console.WriteLine($"Zip Code: {temp.ZipStr}");
            Console.WriteLine($"City Name: {temp.CityStr}");
            Console.WriteLine($"Home Phone: {temp.PhoneStr}");
            Console.WriteLine($"Cell Phone: {temp.CellPhone}");
            Console.WriteLine($"Email Address: {temp.EmailStr}");
            Console.WriteLine($"FaceBook: {temp.FaceBook}");
            Console.WriteLine($"Customer Date: {temp.CustomerSince}");
            Console.WriteLine($"Total Purchases: ${temp.TotalPurchases}");
            Console.WriteLine($"Discount Member: {temp.DiscountMember}");
            Console.WriteLine($"Rewards Earned: {temp.RewardsEarned}");
            CsTools.Pause();
        }
    }
}