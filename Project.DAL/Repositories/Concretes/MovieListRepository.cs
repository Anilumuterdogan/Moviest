using Project.DAL.ContextClasses;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Concretes
{
    public class MovieListRepository : BaseRepository<MovieList>, IMovieListRepository
    {
        public MovieListRepository(MyContext db) : base(db)
        {
        }
    }
}
