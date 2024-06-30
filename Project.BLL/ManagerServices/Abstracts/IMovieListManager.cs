﻿using Project.BLL.DTOClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Abstracts
{
    public interface IMovieListManager : IManager<MovieListDTO, MovieList>
    {
        Task<MovieListDTO> FirstOrDefaultAsync(int userId);
    }
}
