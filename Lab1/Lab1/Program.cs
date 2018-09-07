/*  Kyle Riley SE245.04
 *  Lab One 07/24/18
 *  Grading program, includes assignment weighting. Built into a two while loops, one asking if you have more students to grade (Would you like to continue).
 *  The other while loop enabling someone to keep selecting their grading option until they select the final option.
 *  Homework being the first case, has a percentage of 20
 *  Classwork being the second case, has a percentage of 20
 *  Quiz being the third case, has a percentage of 25
 *  Test being the fourth case, has a percentage of 35
 *  The Final option closes the while, and leads to an empty case so it isn't sent to the default option.
 *  A Final grade is then calculated, including each grade's weight respective of it's percentage.
 *  There is a default case included in a situation where an invalid input is included.
 *  Each case enables the individual to input how many grades they would like to add.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            String strName, select = "", strGrade = "";
            Int32 gradeNum;
            Double homeWeight = .2, assignment = .2, quiz = .25, test = .35;
            Double grade = 0, gradeFinal, hwGrade = 0, aGrade = 0, quizGrade = 0, testGrade = 0;
            String ans = "y";
            while (ans == "y" || ans == "Y")
            {
                Console.Write("Please enter the student's name: ");
                strName = Console.ReadLine();
                Console.Clear();
                while (select != "5")
                {
                    Console.WriteLine("Select the option: \n1. Homework: 20% \n2. Classwork: 20% \n3. Quiz: 25% \n4. Test: 35% \n5. Final Grading");
                    Console.Write("Input: ");
                    select = Console.ReadLine();
                    switch (select)
                    {
                        case "1":
                            grade = 0;
                            Console.WriteLine("How many grades are you enterring? ");
                            Console.Write("Input: ");
                            strGrade = Console.ReadLine();
                            gradeNum = Int32.Parse(strGrade);
                            for (int x = 1; x <= gradeNum; x++)
                            {
                                Console.Clear();
                                Console.WriteLine($"Enter grade number {x}: ");
                                Console.Write("Input: ");
                                strGrade = Console.ReadLine();
                                grade = grade + Int32.Parse(strGrade);
                            }
                            Console.Clear();
                            hwGrade = grade / gradeNum;
                            Console.WriteLine($"The homework grade is: {hwGrade}");
                            break;

                        case "2":
                            grade = 0;
                            Console.WriteLine("How many grades are you enterring? ");
                            Console.Write("Input: ");
                            strGrade = Console.ReadLine();
                            gradeNum = Int32.Parse(strGrade);
                            for (int x = 1; x <= gradeNum; x++)
                            {
                                Console.Clear();
                                Console.WriteLine($"Enter grade number {x}: ");
                                Console.Write("Input: ");
                                strGrade = Console.ReadLine();
                                grade = grade + Int32.Parse(strGrade);
                            }
                            Console.Clear();
                            aGrade = grade / gradeNum;
                            Console.WriteLine($"The classwork grade is: {aGrade}");
                            break;

                        case "3":
                            grade = 0;
                            Console.WriteLine("How many grades are you enterring? ");
                            Console.Write("Input: ");
                            strGrade = Console.ReadLine();
                            gradeNum = Int32.Parse(strGrade);
                            for (int x = 1; x <= gradeNum; x++)
                            {
                                Console.Clear();
                                Console.WriteLine($"Enter grade number {x}: ");
                                Console.Write("Input: ");
                                strGrade = Console.ReadLine();
                                grade = grade + Int32.Parse(strGrade);
                            }
                            Console.Clear();
                            quizGrade = grade / gradeNum;
                            Console.WriteLine($"The quiz grade is: {quizGrade}");
                            break;

                        case "4":
                            grade = 0;
                            Console.WriteLine("How many grades are you enterring? ");
                            Console.Write("Input: ");
                            strGrade = Console.ReadLine();
                            gradeNum = Int32.Parse(strGrade);
                            for (int x = 1; x <= gradeNum; x++)
                            {
                                Console.Clear();
                                Console.WriteLine($"Enter grade number {x}: ");
                                Console.Write("Input: ");
                                strGrade = Console.ReadLine();
                                grade = grade + Int32.Parse(strGrade);
                            }
                            Console.Clear();
                            testGrade = grade / gradeNum;
                            Console.WriteLine($"The test grade is: {testGrade}");
                            break;

                        case "5":
                            break;

                        default:
                            Console.Write("That was an incorrect operation.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                gradeFinal = (hwGrade * homeWeight) + (aGrade * assignment) + (quizGrade * quiz) + (testGrade * test);
                Console.Clear();
                Console.WriteLine($"{strName}'s Grades are: \nHomework: {hwGrade} \nClasswork: {aGrade} \nQuiz: {quizGrade} \nTest: {testGrade} \nFinal: {gradeFinal}");
                Console.WriteLine("Would you like to continue? (y/n)");
                Console.Write("Input: ");
                ans = Console.ReadLine();
            }
        }
    }
}

