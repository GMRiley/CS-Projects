using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Person
    {
        private String firstName;
        private String middleName;
        private String lastName;
        private String streetOne;
        private String streetTwo;
        private String cityStr;
        private String stateStr;
        private String zipStr;
        private String phoneStr;
        private String emailStr;

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public String MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public String StreetOne
        {
            get { return streetOne; }
            set { streetOne = value; }
        }
        public String StreetTwo
        {
            get { return streetTwo; }
            set { streetTwo = value; }
        }
        public String CityStr
        {
            get { return cityStr; }
            set { cityStr = value; }
        }
        public String StateStr
        {
            get { return stateStr; }
            set { stateStr = value; }
        }
        public String ZipStr
        {
            get { return zipStr; }
            set { zipStr = value; }
        }
        public String PhoneStr
        {
            get { return phoneStr; }
            set { phoneStr = value; }
        }
        public String EmailStr
        {
            get { return emailStr; }
            set { emailStr = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person temp = new Person();

            Console.WriteLine("Enter your First name: ");
            temp.FirstName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter your Middle name: ");
            temp.MiddleName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter your Last name: ");
            temp.LastName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter your Primary Address: ");
            temp.StreetOne = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter your Secondary Address: ");
            temp.StreetTwo = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter your Town name: ");
            temp.CityStr = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter your State name: ");
            temp.StateStr = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter your Zip Code: ");
            temp.ZipStr = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter your Phone Number: ");
            temp.PhoneStr = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter your Email Address: ");
            temp.EmailStr = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("This is the information you input:");
            Console.WriteLine($"Full Name: {temp.FirstName} {temp.MiddleName} {temp.LastName}");
            Console.WriteLine($"Primary Address: {temp.StreetOne}");
            Console.WriteLine($"Secondary Address: {temp.StreetTwo}");
            Console.WriteLine($"Town Name: {temp.CityStr}");
            Console.WriteLine($"Zip Code: {temp.ZipStr}");
            Console.WriteLine($"Phone Number: {temp.PhoneStr}");
            Console.WriteLine($"Email Address: {temp.EmailStr}");
            Console.WriteLine("\n\nPress Any Key To Coninue ...");
            Console.ReadKey();
        }
    }
}
