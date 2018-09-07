using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            String strFirst, strOperand, strNum1, strNum2, answer;
            Double num1 = 0, num2 = 0, result = 0;

            Console.WriteLine("Hello There!");
            Console.Write("Please enter your first name: ");
            strFirst = Console.ReadLine(); //Name input

            Console.WriteLine("Hello " + strFirst + "! Let's do some math! ");
            while (result == 0) //Loop to allow use continuation
            {
                Console.Write("Please enter the first number: ");
                strNum1 = Console.ReadLine(); //First number input

                Console.Write("Please enter the math operation ( + , - , * , / ) ");
                strOperand = Console.ReadLine(); //Operand input

                Console.Write("Please enter the second number: ");
                strNum2 = Console.ReadLine(); //Second number input
                num1 = Double.Parse(strNum1);
                num2 = Double.Parse(strNum2); //Parse to double

                switch (strOperand) //Switch case for operands
                {
                    case "+": //Addition
                        result = num1 + num2;
                        Console.WriteLine($"\n\nThe sum of {num1} + {num2} equals: {result}");
                        break;

                    case "-": //Subtraction
                        result = num1 - num2;
                        Console.WriteLine($"\n\nThe difference of {num1} - {num2} equals: {result}");
                        break;

                    case "*": //Multiplication
                        result = num1 * num2;
                        Console.WriteLine($"\n\nThe multiple of {num1} * {num2} equals: {result}");
                        break;

                    case "/": //Division
                        result = num1 / num2;
                        Console.WriteLine($"\n\nThe quotient of {num1} / {num2} equals: {result}");
                        break;

                    default: //Default
                        Console.WriteLine("That function was not recognized.");
                        break;
                }//End switch
                Console.WriteLine("Would you like to go again? (y/n)");
                answer = Console.ReadLine();
                if (answer == "y" || answer == "Y")
                    result = 0;
            }//End loop
            Console.WriteLine("\n\nPress Any Key to Continue");
            Console.ReadKey(); //End program
        }
    }
}
