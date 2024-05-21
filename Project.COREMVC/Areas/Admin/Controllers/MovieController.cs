using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.DTOClasses;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.COREMVC.Areas.Admin.Models.Movies.PageVms;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class MovieController : Controller
    {
        readonly IMovieManager _movieManager;
        IMapper _mapper;
        readonly ICastManager _castManager;
        readonly IGenreManager _genreManager;

        public MovieController(IMovieManager movieManager, IMapper mapper, ICastManager castManager, IGenreManager genreManager)
        {
            _movieManager = movieManager;
            _mapper = mapper;
            _castManager = castManager;
            _genreManager = genreManager;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
                RedirectToAction("Index", "Home");

            return View(_mapper.Map<List<Movie>>(_movieManager.GetAll()));
        }

        public IActionResult CreateMovie()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(MovieRequestPageVM model) 
        {
            Movie movie = new()
            {
                MovieName = model.Movie.MovieName,
                Description = model.Movie.Description,
                ImagePath = model.Movie.ImagePath,
                VideoPath = model.Movie.VideoPath
                
            };
            await _movieManager.AddAsync(_mapper.Map<MovieDTO>(movie));
            return RedirectToAction("Index");
        }

        

        public async Task<IActionResult> DeleteMovie(int id) 
        {
            _movieManager.Delete(await _movieManager.FindAsync(id));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DestroyMovie (int id) 
        {
            _movieManager.Destroy(await _movieManager.FindAsync(id));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateMovie (int id) 
        {
            return View(_mapper.Map<Movie>(await _movieManager.FindAsync(id)));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateMovie(Movie model)
        {
            await _movieManager.UpdateAsync(_mapper.Map<MovieDTO>(model));
            return RedirectToAction("Index");
        }


    }
}
