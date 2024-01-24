using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Extensions
{
    public static class MovieCastDataSeedExtension
    {
        public static void SeedMovieCasts(ModelBuilder modelBuilder)
        {
            List<MovieCast> movieCasts = new List<MovieCast>();

            //The Dark Knight
            MovieCast mC1 = new MovieCast()
            {
                MovieID=1,
                CastID=1,
                NameInMovie="Bruce Wayne"
            };
            movieCasts.Add(mC1);

            MovieCast mC2 = new MovieCast()
            {
                MovieID = 1,
                CastID = 2,
                
            };
            movieCasts.Add(mC2);
            MovieCast mC3 = new MovieCast()
            {
                MovieID = 1,
                CastID = 3,
                NameInMovie = "Joker"
            };
            movieCasts.Add(mC3);
            MovieCast mC4 = new MovieCast()
            {
                MovieID = 1,
                CastID = 4,
                NameInMovie = "Harvey Dent"
            };
            movieCasts.Add(mC4);
            MovieCast mC5 = new MovieCast()
            {
                MovieID = 1,
                CastID = 5,
                NameInMovie = "Alfred"
            };
            movieCasts.Add(mC5);
            MovieCast mC6 = new MovieCast()
            {
                MovieID = 1,
                CastID = 6,
                NameInMovie = "Lucius Fox"
            };
            movieCasts.Add(mC6);
            MovieCast mC7 = new MovieCast()
            {
                MovieID = 1,
                CastID = 7,
                NameInMovie = "Scarecrow"
            };
            movieCasts.Add(mC7);

            //American Psycho
            MovieCast mC8 = new MovieCast()
            {
                MovieID = 2,
                CastID = 1,
                NameInMovie = "Patrick Bateman"
            };
            movieCasts.Add(mC8);
            MovieCast mC9 = new MovieCast()
            {
                MovieID = 2,
                CastID = 8,
                NameInMovie = "Timothy Bryce"
            };
            movieCasts.Add(mC9);
            MovieCast mC10 = new MovieCast()
            {
                MovieID = 2,
                CastID = 9,
                NameInMovie = "Craig McDermott"
            };
            movieCasts.Add(mC10);
            MovieCast mC11 = new MovieCast()
            {
                MovieID = 2,
                CastID = 10,
                NameInMovie = "Evelyn Williams"
            };
            movieCasts.Add(mC11);
            MovieCast mC12 = new MovieCast()
            {
                MovieID = 2,
                CastID = 11,
                NameInMovie = "Courtney Rawlinson"
            };
            movieCasts.Add(mC12);
            MovieCast mC13 = new MovieCast()
            {
                MovieID = 2,
                CastID = 12,
                NameInMovie = "Paul Allen"
            };
            movieCasts.Add(mC13);
            MovieCast mC14 = new MovieCast()
            {
                MovieID = 2,
                CastID = 13,
                NameInMovie = "Donald Kimball"
            };
            movieCasts.Add(mC14);
            MovieCast mC15 = new MovieCast()
            {
                MovieID = 2,
                CastID = 14,               
            };
            movieCasts.Add(mC15);

            modelBuilder.Entity<MovieCast>().HasData(movieCasts);
        }
    }
}
