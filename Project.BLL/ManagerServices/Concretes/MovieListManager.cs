using AutoMapper;
using Project.BLL.DTOClasses;
using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concretes
{
    public class MovieListManager : BaseManager<MovieListDTO, MovieList>, IMovieListManager
    {
        IMovieListRepository _mlRep;
        public MovieListManager(IMovieListRepository mlRep, IMapper mapper) : base(mlRep, mapper)
        {
            _mlRep=mlRep;
        }

        public Task<MovieListDTO> FirstOrDefaultAsync(int userId)
        {
            throw new NotImplementedException();
        }

        
    }
}
