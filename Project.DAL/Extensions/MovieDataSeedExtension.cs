using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Extensions
{
    public static class MovieDataSeedExtension
    {
        public static void SeedMovies(ModelBuilder modelBuilder) 
        {
            List<Movie> movies = new List<Movie>();

            Movie m1 = new Movie()
            {
                ID = 1,
                MovieName = "The Dark Knight"
            };
            movies.Add(m1);
            Movie m2 = new Movie()
            {
                ID = 2,
                MovieName = "American Psycho"
            };
            movies.Add(m2);

            modelBuilder.Entity<Movie>().HasData(movies);
        }
    }
}
