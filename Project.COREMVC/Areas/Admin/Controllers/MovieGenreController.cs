using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.DTOClasses;
using Project.BLL.ManagerServices.Abstracts;
using Project.COREMVC.Areas.Admin.Models.MovieGenres.ResponseModels;
using Project.COREMVC.Areas.Admin.Models.Movies.PureVms;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class MovieGenreController : Controller
    {
        readonly IGenreManager _genreManager;
        readonly IMovieManager _movieManager;
        readonly IMovieGenreManager _movieGenreManager;
        IMapper _mapper;

        public MovieGenreController(IGenreManager genreManager, IMovieManager movieManager, IMapper mapper, IMovieGenreManager movieGenreManager)
        {
            _genreManager = genreManager;
            _movieManager = movieManager;
            _mapper = mapper;
            _movieGenreManager = movieGenreManager;
        }

        public async Task<IActionResult> Index()
        {
            if (!User.Identity.IsAuthenticated)
                RedirectToAction("Index", "Home");

            return View(_mapper.Map<List<Movie>>(_movieManager.GetAll()));
            
        }
        public async Task<IActionResult> AddGenre(int id)
        {
            List<Genre> genres = new();
            List<GenreDTO> genreDTOs = _genreManager.GetActives();
            foreach (GenreDTO item in genreDTOs)
            {
                genres.Add(_mapper.Map<Genre>(item));
            }
            MovieGenreSharedPageVM mGSPVM = new()
            {
                MovieID = id,
                Genres = genres
                
            };
            TempData["id"] = id;

            return View(mGSPVM);

        }

        [HttpPost]
        public async Task<IActionResult> AddGenre(MovieGenreSharedPageVM model)
        {

           int x= Convert.ToInt16(TempData["id"]);
            MovieGenre movieGenre = new()
            {
                MovieID = x,
                GenreID = model.GenreID
            };
            await _movieGenreManager.AddAsync(_mapper.Map<MovieGenreDTO>(movieGenre));
            

            return RedirectToAction("Index");

        }

    }
}