using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Sample1_Structs
{
    class Program
    {
        struct Book
        {   
            public string Title;
            public string AuthorFirst;
            public string AuthorLast;
            public string Email;
            public DateTime DatePublished;
            public int Pages;
            public double Price;

        }
        static void Main(string[] args)
        {

            bool blnResult = false;   

            Book temp = new Book();


            Console.Write("\nPlease enter the title: ");
            temp.Title = Console.ReadLine();

            Console.Write("\nPlease enter the Author's First Name: ");
            temp.AuthorFirst = Console.ReadLine();

            Console.Write("\nPlease enter the Author's Last Name: ");
            temp.AuthorLast = Console.ReadLine();

            Console.Write("\nPlease enter the Author's Email: ");
            temp.Email = Console.ReadLine();


            do
            {
                Console.Write("\nPlease enter the Date Published: ");
                blnResult = DateTime.TryParse(Console.ReadLine(), out temp.DatePublished);

                if (blnResult == false)
                {
                    Console.Write("\nSorry incorrect date format.  Please try again. (Ex: 10/31/2000) ");
                }

            } while (blnResult == false);



            do
            {
                Console.Write("\nPlease enter the # of pages: ");
                blnResult = Int32.TryParse(Console.ReadLine(), out temp.Pages);

                if (blnResult == false)
                {
                    Console.Write("\nSorry incorrect page #.  Please try again. (Ex: 214) ");
                }

            } while (blnResult == false);


            do
            {
                Console.Write("\nPlease enter the Cost of the book : $");
                blnResult = Double.TryParse(Console.ReadLine(), out temp.Price);

                if (blnResult == false)
                {
                    Console.Write("\nSorry incorrect price.  Please try again. (Ex: 19.50) ");
                }

            } while (blnResult == false);




            Console.Write("\n\nWe now have the following book:");
            Console.Write($"\n Title: {temp.Title}");
            Console.Write($"\n Written by {temp.AuthorFirst} {temp.AuthorLast}");
            Console.Write($"\n Email: {temp.Email}");
            Console.Write($"\n Published: {temp.DatePublished.ToShortDateString()}");
            Console.Write($"\n Pages: {temp.Pages}");
            Console.Write($"\n Price: ${temp.Price}");


            BasicTools.Pause();




        }
    }
}
