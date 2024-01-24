using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Extensions
{
    public static class CastDataSeedExtension
    {
        public static void SeedCasts(ModelBuilder modelbuilder) 
        {
            List<Cast> casts = new List<Cast>();

            Cast c1 = new Cast()
            {
                ID = 1,
                FirstName = "Christian",
                LastName = "Bale",                      
            };
            casts.Add(c1);
            Cast c2 = new Cast()
            {
                ID = 2,
                FirstName = "Christopher",
                LastName = "Nolen",
            };
            casts.Add(c2);
            Cast c3 = new Cast()
            {
                ID = 3,
                FirstName = "Heath",
                LastName = "Ledger",
            };
            casts.Add(c3);
            Cast c4 = new Cast()
            {
                ID = 4,
                FirstName = "Aaron",
                LastName = "Eckhart",
            };
            casts.Add(c4);
            Cast c5 = new Cast()
            {
                ID = 5,
                FirstName = "Michael",
                LastName = "Caine",
            };
            casts.Add(c5);
            Cast c6 = new Cast()
            {
                ID = 6,
                FirstName = "Morgon",
                LastName = "Freeman",
            };
            casts.Add(c6);
            Cast c7 = new Cast()
            {
                ID = 7,
                FirstName = "Cillian",
                LastName = "Murphy",
            };
            casts.Add(c7);
            Cast c8 = new Cast()
            {
                ID = 8,
                FirstName = "Justin",
                LastName = "Theroux",
            };
            casts.Add(c8);
            Cast c9 = new Cast()
            {
                ID = 9,
                FirstName = "Josh",
                LastName = "Lucas",
            };
            casts.Add(c9);
            Cast c10 = new Cast()
            {
                ID = 10,
                FirstName = "Reese",
                LastName = "Witherspoon",
            };
            casts.Add(c10);
            Cast c11 = new Cast()
            {
                ID = 11,
                FirstName = "Samantha",
                LastName = "Mathis",
            };
            casts.Add(c11);
            Cast c12 = new Cast()
            {
                ID = 12,
                FirstName = "Jared",
                LastName = "Leto",
            };
            casts.Add(c12);
            Cast c13 = new Cast()
            {
                ID = 13,
                FirstName = "Willem",
                LastName = "Dafoe",
            };
            casts.Add(c13);

            modelbuilder.Entity<Cast>().HasData(casts);

        }
    }
}
