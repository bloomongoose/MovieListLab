using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieListLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>
            {
            new Movie ("Interstellar", "Scifi"),
            new Movie ("The Martian", "Scifi"),
            new Movie ("The Lion King", "Animated"),
            new Movie ("Spider-Man: Into The Spider-Verse", "Animated"),
            new Movie ("Hereditary", "Horror"),
            new Movie ("Scary Movie 4", "Horror"),
            new Movie ("Uncut Gems", "Drama"),
            new Movie ("Knives Out", "Drama"),
            new Movie ("The Other Guys", "Comedy"),
            new Movie ("Rush Hour 2", "Comedy"),
            };

            Console.WriteLine("Welcome to Radeen's Screens! You name it, we've got it.");

            bool runProgram = true;
            while (runProgram)
            {
                //getting user input
                displayGenres();
                string genre = "";

                //validate genre
                while (true)
                {
                    genre = Console.ReadLine();
                    if(genre == "")
                    {
                        Console.WriteLine("That was blank, try again");
                    }
                    else
                    {
                        break;
                    }
                }

                //retrieving list of movies
                List<Movie> result = getMovies(genre, movies);

                foreach (Movie m in result)
                {
                    Console.WriteLine(m.Title);
                }

                //using validator class
                runProgram = Validator.Validator.getContinue("Would you like to keep browsing movies?");
            }
        
        }

        //displaying genres for user to choose from
        static void displayGenres()
        {
            Console.WriteLine("Please choose a genre from the list of categories below.");

            List<string> genres = new List<string>();
            genres.Add("Scifi");
            genres.Add("Animated");
            genres.Add("Horror");
            genres.Add("Drama");
            genres.Add("Comedy");
            foreach (string m in genres)
            {
                Console.WriteLine(m);
            }
            
        }

        //spitting out movies for genre
        static List<Movie> getMovies(string genre, List<Movie> movies)
        {
            return movies.Where(m => m.Category == genre).ToList();
        }
    }
}
