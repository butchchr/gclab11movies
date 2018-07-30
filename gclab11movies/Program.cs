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
            List<Movie> movieList = new List<Movie>();

            movieList.Add(new Movie("Finding Nemo", "animated"));
            movieList.Add(new Movie("Shrek", "animated"));
            movieList.Add(new Movie("Frozen", "animated"));
            movieList.Add(new Movie("Citizen Kane", "drama"));
            movieList.Add(new Movie("Metropolis", "drama"));
            movieList.Add(new Movie("The Godfather", "drama"));
            movieList.Add(new Movie("Blair Witch Project", "horror"));
            movieList.Add(new Movie("It", "horror"));
            movieList.Add(new Movie("The Ring", "horror"));
            movieList.Add(new Movie("The Matrix", "scifi"));
            movieList.Add(new Movie("Galaxy Quest", "scifi"));
            movieList.Add(new Movie("Star Trek II, The Wrath of Khan", "scifi"));
            
            bool run = true;
            while (run)
            {
                Console.WriteLine($"Welcome to the Movies List Application\nThere are num number of movies in this list.\nWhat category are you interested in? (animated, drama, horror, scifi) ");
                string userChoice = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(userChoice))
                {
                    if (userChoice == Animated)
                    {
                        foreach(Movie movie in movieList)
                        {
                            if(movie.GetGenre() == Animated)
                            {
                                Console.WriteLine(movie.GetTitle());
                            }
                        }
                    }
                    else if (userChoice == Drama)
                    {
                        foreach (Movie movie in movieList)
                        {
                            if (movie.GetGenre() == Drama)
                            {
                                Console.WriteLine(movie.GetTitle());
                            }
                        }
                    }
                    else if (userChoice == Horror)
                    {
                        foreach (Movie movie in movieList)
                        {
                            if (movie.GetGenre() == Horror)
                            {
                                Console.WriteLine(movie.GetTitle());
                            }
                        }
                    }
                    else if (userChoice == Scifi)
                    {
                        foreach (Movie movie in movieList)
                        {
                            if (movie.GetGenre() == Scifi)
                            {
                                Console.WriteLine(movie.GetTitle());
                            }
                        }
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
