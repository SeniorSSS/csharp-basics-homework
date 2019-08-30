using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace Execrise4
{
    class Movie
    {
        private string _title;
        private string _studio;
        private string _rating;
        private static List<Movie> _movies = new List<Movie>(); 

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;

            _movies.Add(this);
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }

        /*   public static Movie[] GetPG()
           {
               //List<House> houseOnes = houses.Where(house => house.Name == "House 1").ToList();
               List<Movie> pgMovies = _movies.Where(movie => movie._rating == "PG").ToList();
               var moviesCount = pgMovies.Count;
               Movie[] result = new Movie[moviesCount+1];
               Console.WriteLine("PG movies:");
               for (var i = 0; i < moviesCount; i++)
               {
                   result[i] = pgMovies[i];
                   Console.WriteLine("title: {0}, studio: {1}, rating: {2}",result[i]._title, result[i]._studio);
               }

               return result;
           }

           public static void GetPG()
           {
               //List<House> houseOnes = houses.Where(house => house.Name == "House 1").ToList();
               List<Movie> pgMovies = _movies.Where(movie => movie._rating == "PG").ToList();

               pgMovies.ForEach(el => Console.WriteLine(el._title));


           }
   */
        public Movie[] GetPG(Movie[] movies)
        {
            var pgCount = 0;
            List<Movie> pgMoviesList = new List<Movie>();
            for (var i = 0; i < movies.Length; i++)
            {
                if (movies[i]._rating == "PG")
                {
                //   pgCount++;
                    pgMoviesList.Add(movies[i]);
                }
            }
            Movie[] pgMovies = new Movie[pgCount+1];
            for (var i = 0; i < pgMoviesList.Count;i++)
            {
                pgMovies[i] = pgMoviesList[i];
            }

            return pgMovies;
        }
        public void PrintMovie()
        {
            Console.WriteLine("title: {0}, studio: {1}, rating: {2}", _title, _studio, _rating);
        }
    }
}
