using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class MovieGenreController : Controller
    {
        IMapper _mapper;
        readonly IMovieGenreManager _movieGenreManager;
        readonly IMovieManager _movieManager;
        readonly IGenreManager _genreManager;

        public MovieGenreController(IMapper mapper, IMovieGenreManager movieGenreManager, IMovieManager movieManager, IGenreManager genreManager)
        {
            _mapper = mapper;
            _movieGenreManager = movieGenreManager;
            _movieManager = movieManager;
            _genreManager = genreManager;
        }

        public IActionResult Index()
        { 
            return View();
        }
    }
}
