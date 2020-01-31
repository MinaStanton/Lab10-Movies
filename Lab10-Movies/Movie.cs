using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_Movies
{
    class Movie
    {
        //fields
        private string title;
        private string category;

        //properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        //constructors
        public Movie() { }

        public Movie(string _title, string _category)
        {
            title = _title;
            category = _category;
        }

        //methods

        private static List<string> GetListOfCategoryType(List<Movie> movieCategory)//Get the list of categories 
        {
            List<string> categoryType = new List<string>();
            foreach (Movie _movie in movieCategory)
            {
                if (!categoryType.Contains(_movie.category))
                {
                    categoryType.Add(_movie.category);
                }
            }
            return categoryType;
        }
        public static void PrintListOfCategoryType(List<Movie> movieType)//print the categories
        {
            List<string> categoryType = GetListOfCategoryType(movieType);

            for (int i = 0; i < categoryType.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {categoryType[i]}");
            }
            Console.WriteLine();

        }
        public static List<string> GetListOfMovies(List<Movie> moviesCategory, string select)//Get the list of movies
        {
            List<string> moviesList = new List<string>();

            foreach (Movie _movie in moviesCategory)
            {
                if (_movie.category == select)
                {
                    moviesList.Add(_movie.title);
                }
            }
            return moviesList;
        }

        public static void PrintListOfMovies(List<Movie> moviesList, string select)//print the movies
        {
            List<string> printMovies = GetListOfMovies(moviesList, select);
            printMovies.Sort();
            Console.WriteLine($"The list of {select} movies are: ");
            for (int i = 0; i < printMovies.Count; i++)
            {
                Console.WriteLine($"{printMovies[i]}");
            }

        }

    }
}
