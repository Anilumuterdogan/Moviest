using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.BLL.DTOClasses;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.COREMVC.Areas.Admin.Models.Movies.PageVms;
using Project.COREMVC.Areas.Admin.Models.Movies.SharedVMs;
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
        readonly IMovieCastManager _movieCastManager;
        readonly IMovieGenreManager _movieGenreManager;

        public MovieController(IMovieManager movieManager, IMapper mapper, ICastManager castManager, IGenreManager genreManager, IMovieCastManager movieCastManager, IMovieGenreManager movieGenreManager)
        {
            _movieManager = movieManager;
            _mapper = mapper;
            _castManager = castManager;
            _genreManager = genreManager;
            _movieCastManager = movieCastManager;
            _movieGenreManager = movieGenreManager;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
                RedirectToAction("Index", "Home");

            return View(_mapper.Map<List<Movie>>(_movieManager.GetAll()));
        }

        public IActionResult CreateMovie(int id)
        {
            //ViewBag.Casts = new SelectList(_castManager.GetAll());  
            //ViewBag.Genres = new SelectList(_genreManager.GetAll());

            SharedVM model = new()
            {
                 =  id
            };
            return View(model);

           
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(MovieRequestPageVM model , int[] selectedCasts, int[] selectedGenres) 
        {
            if (ModelState.IsValid) 
            {
                Movie movie = new()
                {
                    MovieName = model.Movie.MovieName,
                    Description = model.Movie.Description,
                    ImagePath = model.Movie.ImagePath,
                    VideoPath = model.Movie.VideoPath

                };
                await _movieManager.AddAsync(_mapper.Map<MovieDTO>(movie));

                foreach (var castId in selectedCasts)
                {
                    _movieCastManager.Add(new MovieCastDTO { MovieID = movie.ID, CastID = castId });
                }
                await _movieCastManager.AddAsync(_mapper.Map<MovieCastDTO>(selectedCasts));
                foreach (var genretId in selectedGenres)
                {
                    _movieGenreManager.Add(new MovieGenreDTO { MovieID = movie.ID, GenreID = genretId});
                }
                await _movieGenreManager.AddAsync(_mapper.Map<MovieGenreDTO>(selectedGenres));

                return RedirectToAction("Index");
            }

            //ViewBag.Casts = new SelectList(_castManager.GetAll());
            //ViewBag.Genres = new SelectList(_genreManager.GetAll());
            model.Casts = _castManager.Select(c => new SelectListItem
            {
                Value = c.ID.ToString(),
                Text = c.FirstName
            }).ToList();

            model.Genres = _genreManager.Select(g => new SelectListItem
            {
                Value = g.ID.ToString(),
                Text = g.GenreName
            }).ToList();

            

            return View(model);
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
