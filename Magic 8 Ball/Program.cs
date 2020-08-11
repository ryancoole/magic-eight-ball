using System;
using System.Threading;

namespace Magic_8_Ball
{
    class Program
    {
        static Random randomObject = new Random();

        static void Main(string[] args)
        {
            programInfo();

            // Loop infinitely
            while (true)
            {
                string questionString = getQuestion();

                // Make the computer look like its thinking
                int numberOfSecondsToSleep = ((randomObject.Next(5) + 1) * 1000);
                Console.WriteLine("Thinking...");
                Thread.Sleep(numberOfSecondsToSleep);

                // if user types specific question
                if (questionString.Length == 0)
                {
                    Console.WriteLine("For an answer, I need a question.");
                    continue;
                }

                if (questionString.ToLower() == "are you a robot")
                {
                    Console.WriteLine("Well, I don't want to brag, but I got a B+ on the Turing test.");
                    continue;
                }

                if (questionString.ToLower() == "how much do you earn")
                {
                    Console.WriteLine("The work is my reward.");
                    continue;
                }

                if (questionString.ToLower() == "talk dirty to me")
                {
                    Console.WriteLine("The carpet needs vacuuming.");
                    continue;
                }

                if (questionString.ToLower() == "who let the dogs out")
                {
                    Console.WriteLine("Woof, woof, woof woof.");
                    continue;
                }

                definedBallReplies();
            }
        }

        static void programInfo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Magic 8 Ball ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("(By: Ryan Coole)");

            Console.WriteLine();
            Console.WriteLine();
        }

        static string getQuestion()
        {
            // This block of code will ask user for a question and store the question text in questionString variable
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask a question?: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            String questionString = Console.ReadLine();

            return questionString;
        }

        static void definedBallReplies()
        {
            // Create a random number to determine response
            int randomNumber = randomObject.Next(20);

            switch (randomNumber)
            {
                case 0:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("It is certain.");
                        break;
                    }
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("As I see it, yes.");
                        break;
                    }
                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Reply hazy, try again.");
                        break;
                    }
                case 3:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Don't count on it.");
                        break;
                    }
                case 4:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("It is decidedly so.");
                        break;
                    }
                case 5:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Most likely.");
                        break;
                    }
                case 6:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Ask again later.");
                        break;
                    }
                case 7:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("My reply is no.");
                        break;
                    }
                case 8:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Without a doubt.");
                        break;
                    }
                case 9:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Outlook good.");
                        break;
                    }
                case 10:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Better not tell you now.");
                        break;
                    }
                case 11:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("My sources say no.");
                        break;
                    }
                case 12:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Yes - definitely.");
                        break;
                    }
                case 13:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Yes.");
                        break;
                    }
                case 14:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Cannot predict now.");
                        break;
                    }
                case 15:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Outlook not so good.");
                        break;
                    }
                case 16:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You may rely on it.");
                        break;
                    }
                case 17:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Signs point to yes.");
                        break;
                    }
                case 18:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Concentrate and ask again.");
                        break;
                    }
                case 19:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Very doubtful.");
                        break;
                    }
            }
        }
    }
}