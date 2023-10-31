using FramWork.Entity;
using FramWork;
using System;
using FramWork.Specificastion;

namespace Start
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var oldKidsMovie = new AndSpection<Movie>(new kidsAppropriateMovie(), new ComediMovie());

            var movie = new Movie()
            {
                Rate = Rating.E,
                PublishYear = DateTime.Now,
                Genre = GenreEnum.Comedy
            };


            var result = oldKidsMovie.IsStatisFieldBy(movie);
        }
    }
}
