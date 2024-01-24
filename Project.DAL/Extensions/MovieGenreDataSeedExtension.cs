using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Extensions
{
    public static class MovieGenreDataSeedExtension
    {
        public static void SeedMovieGenres(ModelBuilder modelBuilder)
        {
            List<MovieGenre> movieGenres = new List<MovieGenre>();

            //The Dark Knight
            MovieGenre mG1 = new MovieGenre()
            {
                GenreID = 1,
                MovieID = 1,
            };
            movieGenres.Add(mG1);
            MovieGenre mG2 = new MovieGenre()
            {
                GenreID = 2,
                MovieID = 1,
            };
            movieGenres.Add(mG2);
            MovieGenre mG3 = new MovieGenre()
            {
                GenreID = 7,
                MovieID = 1,
            };
            movieGenres.Add(mG3);

            //American Psycho
            MovieGenre mG4 = new MovieGenre()
            {
                GenreID = 7,
                MovieID = 2,
            };
            movieGenres.Add(mG4);
            MovieGenre mG5 = new MovieGenre()
            {
                GenreID = 1,
                MovieID = 2,
            };
            movieGenres.Add(mG5);
            MovieGenre mG6 = new MovieGenre()
            {
                GenreID = 12,
                MovieID = 2,
            };
            movieGenres.Add(mG6);

            modelBuilder.Entity<MovieGenre>().HasData(movieGenres);
        }
    }
}
