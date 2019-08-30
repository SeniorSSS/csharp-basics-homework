using System;

namespace Execrise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var movie1 = new Movie("Casino Royale", "Eon Production", "PG13");
            var movie2 = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");
            var movie3 = new Movie("Movie1", "Studio1", "PG");
            var movies = new Movie[3];

            movies[0] = movie1;
            movies[1] = movie2;
            movies[3] = movie3;




            movie1.PrintMovie();

           // Movie.GetPG();

            Console.ReadKey();
        }
    }
}
