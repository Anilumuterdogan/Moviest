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
    public class MovieCastManager : BaseManager<MovieCastDTO, MovieCast>, IMovieCastManager
    {
        IMovieCastRepository _mcRep;

        public MovieCastManager(IMovieCastRepository mcRep, IMapper mapper) : base(mcRep, mapper)
        {
            _mcRep = mcRep;
        }
    }
}
