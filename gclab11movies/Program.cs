using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gclab11movies
{
    class Program
    {
        const string Animated = "animated";
        const string Drama = "drama";
        const string Horror = "horror";
        const string Scifi = "scifi";

        static void Main(string[] args)
        {
            List<string> movieType = new List<string> { Animated, Drama, Horror, Scifi };
            //Logic logic = new Logic
            bool run = true;
            while (run)
            {
                Console.WriteLine($"Welcome to the Movies List Application\nThere are num number of movies in this list.\nWhat category are you interested in? (animated, drama, horror, scifi) ");
                string userChoice = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(userChoice))
                {
                    if (userChoice == Animated)
                    {
                        //display animated
                    }
                    else if (userChoice == Drama)
                    {
                        //display drama
                    }
                    else if (userChoice == Horror)
                    {
                        //display horror
                    }
                    else if (userChoice == Scifi)
                    {
                        //display Scifi
                    }
                }
                else
                {
                    Console.WriteLine("You did not enter a valid genre");
                }

                if (IsPressedKey("Do you want to quit? y/n"))
                {
                    Console.WriteLine("Have a Great Day!");
                    Console.ReadKey();
                    run = false;
                }
                else
                {
                    run = true;
                }
            }
        }

        static bool IsPressedKey(string Prompt)
        {
            bool invalid = true;
            while (invalid)
            {
                Console.WriteLine(Prompt);
                ConsoleKeyInfo pressed = Console.ReadKey();
                Console.WriteLine();
                bool isY = pressed.Key == ConsoleKey.Y;
                bool isN = pressed.Key == ConsoleKey.N;

                invalid = !isY && !isN;
                return true;
            }
            return false;
        }
    }
}
