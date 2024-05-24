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

        public MovieGenreController(IMapper mapper, IMovieGenreManager movieGenreManager)
        {
            _mapper = mapper;
            _movieGenreManager = movieGenreManager;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
                RedirectToAction("Index", "Home");

            return View(_mapper.Map<List<MovieGenre>>(_movieGenreManager.GetAll()));
        }
    }
}
