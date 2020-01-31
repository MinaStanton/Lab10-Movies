//Mina Stanton
//January 20, 2020
//Program description: This program will list movies by category based on user selection. It implements a class and a list.


using System;
using System.Collections.Generic;

namespace Lab10_Movies
{
    class Program
    {
        static void Main(string[] args)
        {   //greeting user
            Console.WriteLine($"Hello and welcome to Movie World!\n");
            //created list of class Moive to store the data for title and category per movie
            List<Movie> MovieList = new List<Movie>
            {
                new Movie("Star Wars (complete series)", "scifi"),
                new Movie("Avatar", "scifi"),
                new Movie("The Matrix", "scifi"),
                new Movie("The ring", "horror"),
                new Movie("Saw", "horror"),
                new Movie("The Shining", "horror"),
                new Movie("Atonement", "drama"),
                new Movie("Never let me go", "drama"),
                new Movie("Pride and Prejudice", "drama"),
                new Movie("Hitch", "romcom"),
                new Movie("The importance of being Earnest", "romcom"),
                new Movie("About Time", "romcom"),
            };

            bool userContinue = true;
            while (userContinue)
            {
                Console.WriteLine("Here is a list of categories: ");
                Movie.PrintListOfCategoryType(MovieList); //printing list of categories
                string categorySelection = SelectCategory("Please enter the number of the category you would like to select.");
                Movie.PrintListOfMovies(MovieList, categorySelection);
                userContinue = UserSelection("\nWould you like to continue? (y/n)", "y", "n");
            }
            Console.WriteLine("\nOtay, thanks for checking out Movie World. See ya!");
        }



        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static bool UserSelection(string message, string option1_true, string option2_false)
        {
            string select = GetUserInput(message);

            if(select == option1_true)
            {
                return true;
            }
            else if(select == option2_false)
            {
                return false;
            }
            else
            {
                return UserSelection("\nInvalid Entry!" + message, option1_true, option2_false);
            }
        }

        public static string SelectCategory(string message)
        {
            string input = GetUserInput(message);
            if (input == "")
            {
                return SelectCategory("Empty Entry! " + message);
            }
            else
            {
                int number = int.Parse(input);
                Console.WriteLine();

                if (number - 1 == 0)
                {
                    return "scifi";
                }
                else if (number - 1 == 1)
                {
                    return "horror";
                }
                else if (number - 1 == 2)
                {
                    return "drama";
                }
                else if (number - 1 == 3)
                {
                    return "romcom";
                }
                else
                {
                    return SelectCategory("Invalid Entry! " + message);
                }
            }
        }
    }
}
