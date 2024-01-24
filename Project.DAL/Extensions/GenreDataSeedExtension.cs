using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Extensions
{
    public static class GenreDataSeedExtension
    {
        public static void SeedGenres(ModelBuilder modelBuilder)
        {
            List<Genre> genres = new();
            
            Genre g1 = new()
            {
                ID = 1,
                GenreName = "Drama"
            };
            genres.Add(g1);
            Genre g2 = new()
            {
                ID = 2,
                GenreName = "Action",

            };
            genres.Add(g2);
            Genre g3 = new()
            {
                ID = 3,
                GenreName = "Adventure",

            };
            genres.Add(g3);
            Genre g4 = new()
            {
                ID = 4,
                GenreName = "Animation",

            };
            genres.Add(g4);
            Genre g5 = new()
            {
                ID = 5,
                GenreName = "Biography",

            };
            genres.Add(g5);
            Genre g6 = new()
            {
                ID = 6,
                GenreName = "Comedy",

            };
            genres.Add(g6);
            Genre g7 = new()
            {
                ID = 7,
                GenreName = "Crime",

            };
            genres.Add(g7);
            Genre g8 = new()
            {
                ID = 8,
                GenreName = "Documentary",

            };
            genres.Add(g8);
            Genre g9 = new()
            {
                ID = 9,
                GenreName = "Family",

            };
            genres.Add(g9);
            Genre g10 = new()
            {
                ID = 10,
                GenreName = "Fantasy",

            };
            genres.Add(g10);
            Genre g11 = new()
            {
                ID = 11,
                GenreName = "History",

            };
            genres.Add(g11);
            Genre g12 = new()
            {
                ID = 12,
                GenreName = "Horror",

            };
            genres.Add(g12);
            Genre g13 = new()
            {
                ID = 13,
                GenreName = "Mystery",

            };
            genres.Add(g13);
            Genre g14 = new()
            {
                ID = 14,
                GenreName = "Romance",

            };
            genres.Add(g14);
            Genre g15 = new()
            {
                ID = 15,
                GenreName = "War",

            };
            genres.Add(g15);
            Genre g16 = new()
            {
                ID = 16,
                GenreName = "Western",

            };
            genres.Add(g16);
            Genre g17 = new()
            {
                ID = 17,
                GenreName = "Sci-Fi",

            };
            genres.Add(g17);
            Genre g18 = new()
            {
                ID = 18,
                GenreName = "Sport",

            };
            genres.Add(g18);
            Genre g19 = new()
            {
                ID = 19,
                GenreName = "Thriller",

            };
            genres.Add(g19);
            
            modelBuilder.Entity<Genre>().HasData(genres);
        }
    }
}
