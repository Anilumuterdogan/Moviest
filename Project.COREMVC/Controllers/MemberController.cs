using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Controllers
{
    public class MemberController : Controller
    {
        readonly IGenreManager _genreManager;
        readonly IMovieManager _movieManager;
        readonly IMapper _mapper;

        public MemberController(IGenreManager genreManager, IMovieManager movieManager, IMapper mapper)
        {
            _genreManager = genreManager;
            _movieManager = movieManager;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(_mapper.Map<List<Movie>>(_movieManager.GetAll()));
        }
    }
}
