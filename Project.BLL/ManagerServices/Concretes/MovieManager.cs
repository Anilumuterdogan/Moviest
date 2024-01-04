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
    public class MovieManager : BaseManager<MovieDTO, Movie>, IMovieManager
    {
        IMovieRepository _mvRep;

        public MovieManager(IMovieRepository mvRep, IMapper mapper) : base(mvRep, mapper)
        {
            _mvRep = mvRep;
        }
    }
}
