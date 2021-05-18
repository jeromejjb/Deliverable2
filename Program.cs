using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string previousUserInput = "";

            while (true)
            {
                Console.WriteLine("What would you like to say");
                userInput = Console.ReadLine().ToLower();
                if (userInput == previousUserInput)
                {
                    Console.WriteLine("I'm sorry but you have already said that");
                }
                else
                {
                    if (userInput == "hello")
                    {
                        Console.WriteLine("Hi good to see you");
                    }

                    if (userInput == "sup")
                    {
                        Console.WriteLine("I am good");
                    }
                    if (userInput == "hello there")
                    {
                        Console.WriteLine("General Kenobi");
                    }
                    if (userInput == "bye")
                    {
                        Console.WriteLine("Good bye!");
                        break;
                    }
                }
                previousUserInput = userInput;
                    }
                }
            }
        }
