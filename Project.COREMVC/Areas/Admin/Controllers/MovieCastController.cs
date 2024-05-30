using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.DTOClasses;
using Project.BLL.ManagerServices.Abstracts;
using Project.COREMVC.Areas.Admin.Models.MovieCasts.ResponseModels;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class MovieCastController : Controller
    {
        readonly ICastManager _castManager;
        readonly IMovieManager _movieManager;
        readonly IMovieCastManager _movieCastManager;
        IMapper _mapper;

        public MovieCastController(ICastManager castManager, IMovieManager movieManager, IMovieCastManager movieCastManager, IMapper mapper)
        {
            _castManager = castManager;
            _movieManager = movieManager;
            _movieCastManager = movieCastManager;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            if (!User.Identity.IsAuthenticated)
                RedirectToAction("Index", "Home");

            return View(_mapper.Map<List<Movie>>(_movieManager.GetAll()));
        }

        public async Task<IActionResult> AddCast(int id) 
        {
            List<Cast> casts = new();
            List<CastDTO> castDTOs = _castManager.GetActives();
            foreach (CastDTO item in castDTOs) 
            {
                casts.Add(_mapper.Map<Cast>(item));
            }
            MovieCastSharedPageVM mCSPVM = new()
            {
                MovieID = id,
                Casts = casts
            };
            TempData["id"] = id;

            return View(mCSPVM);
        }

        [HttpPost]
        public async Task<IActionResult> AddCast(MovieCastSharedPageVM model) 
        {
            int x = Convert.ToInt16(TempData["id"]);
            MovieCast movieCast = new()
            {
                MovieID = x,
                CastID = model.CastID,
                NameInMovie =model.NameInMovie
            };
            
            await _movieCastManager.AddAsync(_mapper.Map<MovieCastDTO>(movieCast));

            return RedirectToAction("Index");
        }
    }
}
