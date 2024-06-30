using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.COREMVC.Models.Members.Movies;
using Project.COREMVC.Models.Members.WatchlistTools;
using Project.COREMVC.Models.Members.Genres;
using Project.COREMVC.Models.Members.MemberPageVM;
using Project.COREMVC.Models.SessionService;
using Project.ENTITIES.Models;
using X.PagedList;
using Project.BLL.DTOClasses;
using Project.BLL.ManagerServices.Concretes;
using Project.COREMVC.Models.Members.MovieDetailsVM;
using Project.COREMVC.Models.Members.Casts;
using System.Security.Claims;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.COREMVC.Models.Members.WatchlistTools;
using Project.DAL.ContextClasses;

namespace Project.COREMVC.Controllers
{
    public class MemberController : Controller
    {
        readonly IGenreManager _genreManager;
        readonly IMovieManager _movieManager;
        readonly IMovieGenreManager _movieGenreManager;
        readonly IMovieCastManager _movieCastManager;
        readonly ICastManager _castManager;
        readonly IMapper _mapper;
        readonly IMovieListManager _movieListManager;
        readonly UserManager<AppUser> _userManager;


        public MemberController(IGenreManager genreManager, IMovieManager movieManager, IMapper mapper, IMovieGenreManager movieGenreManager, ICastManager castManager, IMovieCastManager movieCastManager, IMovieListManager movieListManager, UserManager<AppUser> userManager)
        {
            _genreManager = genreManager;
            _movieManager = movieManager;
            _mapper = mapper;
            _movieGenreManager = movieGenreManager;
            _castManager = castManager;
            _movieCastManager = movieCastManager;
            _movieListManager = movieListManager;
            _userManager = userManager;
        }

        private List<MovieVM> MovieDtoToVM()
        {
            List<MovieVM> liste = _movieManager.GetActives().Select(x => new MovieVM
            {
                VideoPath = x.VideoPath,
                MovieName = x.MovieName,
                ImagePath = x.ImagePath,
                ID = x.ID
            }).ToList();

            return liste;
        }
        private List<MovieVM> GenreDtoToVm(int? id)
        {
            List<MovieVM> list = _movieManager.GetActives().Where(x => x.MovieGenres.Any(y => y.GenreID == id)).Select(a => new MovieVM
            {
                VideoPath = a.VideoPath,
                MovieName = a.MovieName,
                ImagePath = a.ImagePath,
                ID = a.ID
            }).ToList();

            return list;
        }

        public IActionResult Index(int? page, int? genreID)
        {
            MemberMovieVM memberMovie = new MemberMovieVM()
            {
                Movies = genreID == null ? MovieDtoToVM().ToPagedList(page ?? 1, 9) : GenreDtoToVm(genreID).ToPagedList(page ?? 1, 9),

                Genres = _genreManager.GetActives().Select(x => new GenreVM
                {
                    GenreName = x.GenreName,
                    ID = x.ID
                }).ToList(),
            };
            if (genreID != null) TempData["genreID"] = genreID;//page degistirdigimizde genre'nin bir sonraki sayfada unutulmaması icin gecici bir depolama alanında tutuyoruz.GenreID ilkel bir tip oldugu icin tempdata da saklıyoruz .Viewdata kullanmamamızın sebebi bir sonra ki sayfada tamamen farklı bir request olacagı icin view dan çıkar o yuzden kullanmayız.

            return View(memberMovie);
        }

        public async Task<IActionResult> AddToMovie(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                TempData["message"] = "You need to be logged in to add a movie to your watch list.";
                return RedirectToAction("Index"); 
            }

            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var movie = await _movieManager.FindAsync(id);
            if (movie == null)
            {
                TempData["message"] = "Movie not found.";
                return RedirectToAction("Index");
            }
            MovieListDTO existingMovie = await _movieListManager.FirstOrDefaultAsync(m => m.AppUserID == userId && m.MovieID == id);

            if (existingMovie == null)
            {
                var watchList = new MovieListDTO
                {
                    AppUserID = userId,
                    MovieID = id
                };

                await _movieListManager.AddAsync(_mapper.Map<MovieListDTO>(watchList));
                

                TempData["message"] = $"{movie.MovieName} added to movie watch list.";
            }
            else
            {
                TempData["message"] = "This movie is already in your watch list.";
            }          

            return RedirectToAction("Index");
        }

        private void SetMovieList(MovieList m)
        {
            HttpContext.Session.SetObject("dmovie", m);
           
        }
        
        public async Task<IActionResult> MovieListPage()
        {
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            
            var movieList =  _movieListManager.Where(m =>m.AppUserID ==userId).ToList();
            var task = movieList.Select(async ml =>
            {
                var movie = await _movieManager.FindAsync(ml.MovieID);
                return new MovieVM
                {
                    ID = movie.ID,
                    MovieName = movie.MovieName,
                    ImagePath = movie.ImagePath,
                };
            });
            var movies = await Task.WhenAll(task);

            List<MovieVM> moviess = movies.ToList();

            WatchListVM model = new WatchListVM
            {
                Movies = moviess
            };

            return View(model);


        }

        public async Task<IActionResult> DeleteFromMovieList(int id)
        {
            _movieListManager.Delete(await _movieListManager.FindAsync(id));

            return RedirectToAction("MovieListPage");
        }

        

        public MovieDetailsVM GetMovieById(int id)
        {
            var movie = _movieManager.Where(m => m.ID == id).Select(m => new MovieVM
            {
                ID = m.ID,
                MovieName = m.MovieName,
                Description = m.Description,
                ImagePath = m.ImagePath,
                VideoPath = m.VideoPath
                
                
            }).FirstOrDefault();

            List<CastVM> casts = _movieCastManager.Where(c => c.MovieID == id).Select(c => new CastVM
            {
                ID = c.Cast.ID,
               FirstName  = c.Cast.FirstName,
               LastName = c.Cast.LastName,
               Description = c.Cast.Description,
               ImagePath = c.Cast.ImagePath

            }).ToList();
            return new MovieDetailsVM
            {
                Movie = movie,
                Casts = casts,
            };

        }
        public IActionResult MovieDetails(int id)
        {
            var movie = GetMovieById(id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }
       
        public IActionResult CastDetails(int id)
        {
            var cast = _castManager.Where(c => c.ID == id).Select(c => new CastVM
            {
                ID = c.ID,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Description = c.Description,
                ImagePath = c.ImagePath

            }).FirstOrDefault();

            if (cast == null)
            {
                return NotFound();
            }

            return View(cast);

        }

        public IActionResult Search(string model)
        {
            if (string.IsNullOrEmpty(model))
            {
                return View(new List<MovieVM>());
            }
            var movies = _movieManager.Where(m => m.MovieName.Contains(model)).Select(m => new MovieVM
            {
                ID = m.ID,
                MovieName = m.MovieName,
                ImagePath = m.ImagePath
            }).ToList();

            return View(movies);
        }
    }
}
