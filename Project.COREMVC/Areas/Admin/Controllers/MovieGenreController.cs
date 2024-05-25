using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.COREMVC.Areas.Admin.Models.Movies.PageVms;
using Project.COREMVC.Areas.Admin.Models.Movies.ResponseModels;
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

        public  IActionResult GetMovies()
        {
            List<MovieResponseModel> movies =  _movieManager.Select(x => new MovieResponseModel
            {

                ID = x.ID,
                MovieName = x.MovieName

            }).ToList();
            MovieResponsePageVM mRp = new MovieResponsePageVM
            {
                Movies = movies
            };


            return View(mRp);
        }

    }
}
