using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            String strName = "", select = "", strGrade = "", studentStr = "";
            Int32 studentNum = 0, result;
            Double homeWeight = .2, assignment = .2, quiz = .25, test = .35;
            Double gradeFinal = 0, hwGrade = 0, aGrade = 0, quizGrade = 0, testGrade = 0;
            Double hwAvg = 0, clAvg = 0, quizAvg = 0, testAvg = 0, finalAvg = 0;
            List<String> topList = new List<String>();
            List<String> hwList = new List<String>();
            List<String> clList = new List<String>();
            List<String> quizList = new List<String>();
            List<String> testList = new List<String>();
            List<String> finalList = new List<String>();

            topList.Insert(0, "          ");
            hwList.Insert(0, "Homework  ");
            clList.Insert(0, "Classwork ");
            quizList.Insert(0, "Quiz      ");
            testList.Insert(0, "Test      ");
            finalList.Insert(0, "Final     ");

            do
            {
                Console.WriteLine("How many students are you entering?");
                Console.Write("Input: ");
                studentStr = Console.ReadLine();
            }
            while((Int32.TryParse(studentStr, out result)) == false);
            studentNum = Int32.Parse(studentStr);
            for (int counter = 0; counter < studentNum; counter++)
            {
                select = "0";
                Console.Write("Please enter the student's name: ");
                strName = Console.ReadLine();
                topList.Add(strName);
                Console.Clear();
                do
                {
                    Console.Clear();
                    Console.WriteLine("Select the option: \n1. Homework: 20% \n2. Classwork: 20% \n3. Quiz: 25% \n4. Test: 35% \n5. Final Grading");
                    Console.Write("Input: ");
                    select = Console.ReadLine();
                    switch (select)
                    {
                        case "1":
                            Console.Clear();
                            hwGrade = gradeCalc();
                            Console.WriteLine($"The homework grade is: {hwGrade}");
                            strGrade = hwGrade.ToString();
                            hwList.Add(strGrade);
                            hwAvg = hwAvg + hwGrade;
                            break;

                        case "2":
                            Console.Clear();
                            aGrade = gradeCalc();
                            Console.WriteLine($"The classwork grade is: {aGrade}");
                            strGrade = aGrade.ToString();
                            clList.Add(strGrade);
                            clAvg = clAvg + aGrade;
                            break;

                        case "3":
                            Console.Clear();
                            quizGrade = gradeCalc();
                            Console.WriteLine($"The quiz grade is: {quizGrade}");
                            strGrade = quizGrade.ToString();
                            quizList.Add(strGrade);
                            quizAvg = quizAvg + quizGrade;
                            break;

                        case "4":
                            Console.Clear();
                            testGrade = gradeCalc();
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
                while (select != "5");

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
            listPrint(topList, studentNum);
            Console.WriteLine();
            listPrint(hwList, studentNum);
            Console.WriteLine();
            listPrint(clList, studentNum);
            Console.WriteLine();
            listPrint(quizList, studentNum);
            Console.WriteLine();
            listPrint(testList, studentNum);
            Console.WriteLine();
            listPrint(finalList, studentNum);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press Any Key to Continue . . . ");
            Console.ReadKey();
        }
        static double gradeCalc()
        {
            Console.Clear();
            double grade = 0, finalGrade;
            Int32 gradeNum, result;
            String strGrade;
            do
            {
                Console.WriteLine("How many grades are you enterring? ");
                Console.Write("Input: ");
                strGrade = Console.ReadLine();
            }
            while ((Int32.TryParse(strGrade, out result)) == false);
            gradeNum = Int32.Parse(strGrade);
            for (int x = 1; x <= gradeNum; x++)
            {
                Console.Clear();
                do
                {
                    Console.WriteLine($"Enter grade number {x}: ");
                    Console.Write("Input: ");
                    strGrade = Console.ReadLine();
                } while ((Int32.TryParse(strGrade, out result)) == false);
                grade = grade + Int32.Parse(strGrade);
            }
            finalGrade = grade / gradeNum;
            Console.Clear();
            return finalGrade;
        }
        static void listPrint(List<String>listStuff, int studentNum)
        {
            int strLength;
            for (int counter = 0; counter <= studentNum + 1; counter++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                if (counter == 0)
                    Console.ForegroundColor = ConsoleColor.Cyan;
                if (counter == (studentNum + 1))
                    Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(listStuff[counter]);
                strLength = listStuff[counter].Length;
                for (int counterTwo = strLength; counterTwo < 10; counterTwo++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
            }
        }
    }
}
