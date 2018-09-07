using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            String strName = "", select = "", strGrade = "", studentStr = "";
            Int32 gradeNum = 0, studentNum = 0, strLength;
            Double homeWeight = .2, assignment = .2, quiz = .25, test = .35;
            Double grade = 0, gradeFinal = 0, hwGrade = 0, aGrade = 0, quizGrade = 0, testGrade = 0;
            Double hwAvg = 0, clAvg = 0, quizAvg = 0, testAvg = 0, finalAvg = 0;
            List<String> topList = new List<String>();
            List<String> hwList = new List<String>();
            List<String> clList = new List<String>();
            List<String> quizList = new List<String>();
            List<String> testList = new List<String>();
            List<String> finalList = new List<String>();
            topList.Insert(0,  "          ");
            hwList.Insert(0,   "Homework  ");
            clList.Insert(0,   "Classwork ");
            quizList.Insert(0, "Quiz      ");
            testList.Insert(0, "Test      ");
            finalList.Insert(0,"Final     ");
            Console.WriteLine("How many students are you enterring?");
            Console.Write("Input: ");
            studentStr = Console.ReadLine();
            studentNum = Int32.Parse(studentStr);
            for (int counter = 0; counter < studentNum; counter++)
            {
                select = "0";
                Console.Write("Please enter the student's name: ");
                strName = Console.ReadLine();
                topList.Add(strName);
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
                            strGrade = hwGrade.ToString();
                            hwList.Add(strGrade);
                            hwAvg = hwAvg + hwGrade;
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
                            strGrade = aGrade.ToString();
                            clList.Add(strGrade);
                            clAvg = clAvg + aGrade;
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
                            strGrade = quizGrade.ToString();
                            quizList.Add(strGrade);
                            quizAvg = quizAvg + quizGrade;
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
                            strGrade = testGrade.ToString();
                            testList.Add(strGrade);
                            testAvg = testAvg + testGrade;
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
                finalAvg = finalAvg + gradeFinal;
                strGrade = gradeFinal.ToString();
                finalList.Add(strGrade);
                Console.Clear();
                Console.WriteLine($"{strName}'s Grades are: \nHomework: {hwGrade} \nClasswork: {aGrade} \nQuiz: {quizGrade} \nTest: {testGrade} \nFinal: {gradeFinal}");
            }

            hwAvg = Math.Round((hwAvg / studentNum), 2);
            hwList.Add(hwAvg.ToString());
            clAvg = Math.Round((clAvg / studentNum), 2);
            clList.Add(clAvg.ToString());
            quizAvg = Math.Round((quizAvg / studentNum), 2);
            quizList.Add(quizAvg.ToString());
            testAvg = Math.Round((testAvg / studentNum), 2);
            testList.Add(testAvg.ToString());
            finalAvg = Math.Round((finalAvg / studentNum), 2);
            finalList.Add(finalAvg.ToString());

            Console.Clear();
            topList.Add("Average");
            for (int counter = 0; counter <= studentNum + 1; counter++)
            {
                Console.Write(topList[counter]);
                strLength = topList[counter].Length;
                for (int counterTwo = strLength; counterTwo < 10; counterTwo ++)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            for (int counter = 0; counter <= studentNum + 1; counter++)
            {
                Console.Write(hwList[counter]);
                strLength = hwList[counter].Length;
                for (int counterTwo = strLength; counterTwo < 10; counterTwo++)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            for (int counter = 0; counter <= studentNum + 1; counter++)
            {
                Console.Write(clList[counter]);
                strLength = clList[counter].Length;
                for (int counterTwo = strLength; counterTwo < 10; counterTwo++)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            for (int counter = 0; counter <= studentNum + 1; counter++)
            {
                Console.Write(quizList[counter]);
                strLength = quizList[counter].Length;
                for (int counterTwo = strLength; counterTwo < 10; counterTwo++)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            for (int counter = 0; counter <= studentNum + 1; counter++)
            {
                Console.Write(testList[counter]);
                strLength = testList[counter].Length;
                for (int counterTwo = strLength; counterTwo < 10; counterTwo++)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            for (int counter = 0; counter <= studentNum + 1; counter++)
            {
                Console.Write(finalList[counter]);
                strLength = finalList[counter].Length;
                for (int counterTwo = strLength; counterTwo < 10; counterTwo++)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press Any Key to Continue . . . ");
            Console.ReadKey();
        }
    }
}
