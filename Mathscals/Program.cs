using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsCals
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=======================WELCOME TO MathsCal======================");

            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Hello {0}", name);
            while (true)
            {
                Console.WriteLine("Please select an operation...+ (addition), - (substraction), * (multiplication) & / (Division)");
                string ops = Console.ReadLine();

                if (ops == "+" || ops == "-" || ops == "*" || ops == "/")
                {
                    Console.WriteLine("Please select a diffculty level....1, 2 or 3");
                    while (name!= null)
                    {
                        try
                        {
                            int diff = Convert.ToInt32(Console.ReadLine());
                            switch (diff)
                            {
                                case 1:
                                    Program.Lvl1(ops);
                                    Console.WriteLine("Please select diffulty level of 1, 2 or 3");
                                    break;
                                case 2:
                                    Program.Lvl2(ops);
                                    Console.WriteLine("Please select diffulty level of 1, 2 or 3");
                                    break;
                                case 3:
                                    Program.Lvl3(ops);
                                    Console.WriteLine("Please select diffulty level of 1, 2 or 3");
                                    break;
                                default:
                                    Console.WriteLine("Please select diffulty level of 1, 2 or 3");
                                    break;
                            }
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("{0} is outside the range of the Int32 type.", Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
                                              Console.ReadLine().GetType().Name, Console.ReadLine());
                        }                       
                    }
                }
                else
                {
                    Console.WriteLine("lease enter a valid operation");
                }
            }            
        }

        public static void Lvl1(string ops)
        {
            

            Console.WriteLine("You selected lvl 1");
            Console.WriteLine("How many questions do you want to answer?");
            string input = Console.ReadLine();
            int noOfQuestions = 0;
            int userAnswer = 0;
            int rightcount = 0;

            noOfQuestions = Convert.ToInt32(input);

            try
            {
                noOfQuestions = Convert.ToInt32(input);
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of the Int32 type.", Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
                                  Console.ReadLine().GetType().Name, Console.ReadLine());
            }


            for (int z = 0; z < noOfQuestions; z++)
            {
                Random q = new Random();
                int qNumQ = q.Next(1, 10);
                int qNumQ2 = q.Next(1, 10);
                int answer = 0;

                if(ops == "+")
                {
                    Console.WriteLine("what is  the sum of {0} and  {1}", qNumQ, qNumQ2);
                    userAnswer = Convert.ToInt32(Console.ReadLine());
                    answer = qNumQ + qNumQ2;
                    if (userAnswer == answer)
                    {
                        Console.WriteLine("correct");
                        rightcount++;
                    }
                    else
                    {
                        Console.WriteLine("wrong answer...the correct answer is {0}", answer);
                    }
                    
                }

                else if(ops == "-")
                {
                    Console.WriteLine("what is the difference of {0} {1} {2}", qNumQ, ops, qNumQ2);
                    userAnswer = Convert.ToInt32(Console.ReadLine());
                    answer = qNumQ - qNumQ2;
                    if (userAnswer == answer)
                    {
                        Console.WriteLine("correct");
                        rightcount++;
                    }
                    else
                    {
                        Console.WriteLine("wrong answer...the correct answer is {0}", answer);
                    }
                }
                else if(ops == "*")
                {
                    Console.WriteLine("what is the product of {0} {1} {2}", qNumQ, ops, qNumQ2);

                    userAnswer = Convert.ToInt32(Console.ReadLine());
                    answer = qNumQ * qNumQ2;
                    if (userAnswer == answer)
                    {
                        Console.WriteLine("correct");
                        rightcount++;
                    }
                    else
                    {
                        Console.WriteLine("wrong answer...the correct answer is {0}", answer);
                    }
                }
                else if(ops == "/")
                {
                    double higherNumber = Convert.ToDouble(Math.Max(qNumQ, qNumQ));
                    double lowerNumber = Convert.ToDouble(Math.Min(qNumQ, qNumQ2));
                    Console.WriteLine("what is {0} {1} {2}", higherNumber, ops, lowerNumber);
                    double dAns = higherNumber / lowerNumber;

                    double divUserAns = Convert.ToDouble(Console.ReadLine());
                    if(divUserAns == dAns)
                    {
                        Console.WriteLine("Correct answer");
                        rightcount++;
                    }
                    else
                    {
                        Console.WriteLine("wrong answer...the correct answer is {0}", divUserAns);
                    }
                }
            }
            double score = Convert.ToDouble(rightcount) / Convert.ToDouble(noOfQuestions);
            double passPercentage = score * 100.0;
            if (passPercentage > 50)
            {
                Console.WriteLine("You did alright, your total score is {0}/{1}", rightcount, noOfQuestions);
                Console.WriteLine("You have a pass rate of {0}%", passPercentage);
            }
            else
            {
                Console.WriteLine("You failed, Your total score is {0}/{1}", rightcount, noOfQuestions);
                Console.WriteLine("You have a pass rate of {0}%", passPercentage);
            }

        }

        public static void Lvl2(string ops)
        {


            Console.WriteLine("You selected lvl 2");
            Console.WriteLine("How many questions do you want to answer");
            string input = Console.ReadLine();
            int noOfQuestions = 0;
            int userAnswer = 0;
            int rightcount = 0;

            try
            {
                noOfQuestions = Convert.ToInt32(input);
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of the Int32 type.", Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
                                  Console.ReadLine().GetType().Name, Console.ReadLine());
            }

            for (int z = 0; z < noOfQuestions; z++)
            {
                Random q = new Random();
                int qNumQ = q.Next(1, 100);
                int qNumQ2 = q.Next(1, 100);
                int answer = 0;

                if (ops == "+")
                {
                    Console.WriteLine("what is  the sum of {0} and  {1}", qNumQ, qNumQ2);
                    userAnswer = Convert.ToInt32(Console.ReadLine());
                    answer = qNumQ + qNumQ2;
                    if (userAnswer == answer)
                    {
                        Console.WriteLine("correct");
                        rightcount++;
                    }
                    else
                    {
                        Console.WriteLine("wrong answer...the correct answer is {0}", answer);
                    }

                }

                else if (ops == "-")
                {
                    Console.WriteLine("what is the difference of {0} {1} {2}", qNumQ, ops, qNumQ2);
                    userAnswer = Convert.ToInt32(Console.ReadLine());
                    answer = qNumQ - qNumQ2;
                    if (userAnswer == answer)
                    {
                        Console.WriteLine("correct");
                        rightcount++;
                    }
                    else
                    {
                        Console.WriteLine("wrong answer...the correct answer is {0}", answer);
                    }
                }
                else if (ops == "*")
                {
                    Console.WriteLine("what is the product of {0} {1} {2}", qNumQ, ops, qNumQ2);

                    userAnswer = Convert.ToInt32(Console.ReadLine());
                    answer = qNumQ * qNumQ2;
                    if (userAnswer == answer)
                    {
                        Console.WriteLine("correct");
                        rightcount++;
                    }
                    else
                    {
                        Console.WriteLine("wrong answer...the correct answer is {0}", answer);
                    }
                }
                else if (ops == "/")
                {
                    double higherNumber = Convert.ToDouble(Math.Max(qNumQ, qNumQ));
                    double lowerNumber = Convert.ToDouble(Math.Min(qNumQ, qNumQ2));
                    Console.WriteLine("what is {0} {1} {2}", higherNumber, ops, lowerNumber);
                    double dAns = higherNumber / lowerNumber;

                    double divUserAns = Convert.ToDouble(Console.ReadLine());
                    if (divUserAns == dAns)
                    {
                        Console.WriteLine("Correct answer");
                        rightcount++;
                    }
                    else
                    {
                        Console.WriteLine("wrong...the correct answer is {0}", divUserAns);
                    }
                }
            }

        }

        public static void Lvl3(string ops)
        {


            Console.WriteLine("You selected lvl 3");
            Console.WriteLine("How many questions do you want to answer");
            string input = Console.ReadLine();
            int noOfQuestions = 0;
            int userAnswer = 0;
            int rightcount = 0;


            try
            {
                noOfQuestions = Convert.ToInt32(input);
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of the Int32 type.", Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
                                  Console.ReadLine().GetType().Name, Console.ReadLine());
            }

            for (int z = 0; z < noOfQuestions; z++)
            {
                Random q = new Random();
                int qNumQ = q.Next(1, 1000);
                int qNumQ2 = q.Next(1, 1000);
                int answer = 0;

                if (ops == "+")
                {
                    Console.WriteLine("what is  the sum of {0} and  {1}", qNumQ, qNumQ2);
                    userAnswer = Convert.ToInt32(Console.ReadLine());
                    answer = qNumQ + qNumQ2;
                    if (userAnswer == answer)
                    {
                        Console.WriteLine("correct");
                        rightcount++;
                    }
                    else
                    {
                        Console.WriteLine("wrong answer...the correct answer is {0}", answer);
                    }

                }

                else if (ops == "-")
                {
                    Console.WriteLine("what is the difference of {0} {1} {2}", qNumQ, ops, qNumQ2);
                    userAnswer = Convert.ToInt32(Console.ReadLine());
                    answer = qNumQ - qNumQ2;
                    if (userAnswer == answer)
                    {
                        Console.WriteLine("correct");
                        rightcount++;
                    }
                    else
                    {
                        Console.WriteLine("wrong answer...the correct answer is {0}", answer);
                    }
                }
                else if (ops == "*")
                {
                    Console.WriteLine("what is the product of {0} {1} {2}", qNumQ, ops, qNumQ2);

                    userAnswer = Convert.ToInt32(Console.ReadLine());
                    answer = qNumQ * qNumQ2;
                    if (userAnswer == answer)
                    {
                        Console.WriteLine("correct");
                        rightcount++;
                    }
                    else
                    {
                        Console.WriteLine("wrong answer...the correct answer is {0}", answer);
                    }
                }
                else if (ops == "/")
                {
                    double higherNumber = Convert.ToDouble(Math.Max(qNumQ, qNumQ));
                    double lowerNumber = Convert.ToDouble(Math.Min(qNumQ, qNumQ2));
                    Console.WriteLine("what is {0} {1} {2}", higherNumber, ops, lowerNumber);
                    double dAns = higherNumber / lowerNumber;

                    double divUserAns = Convert.ToDouble(Console.ReadLine());
                    if (divUserAns == dAns)
                    {
                        Console.WriteLine("Correct answer");
                        rightcount++;
                    }
                    else
                    {
                        Console.WriteLine("wrong answer...the correct answer is {0}", divUserAns);
                    }
                }
            }

        }
    }
}
