using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.COREMVC.Models.Members.MemberPageVM;
using Project.ENTITIES.Models;
using X.PagedList;

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

        public IActionResult Index(int? page, int? genreID)
        {
            MemberMovieVM memberMovie = new MemberMovieVM()
            {
                Movies = genreID == null ? _movieManager.GetActives().ToPagedList(page ?? 1,9) : _movieManager.Where(x => x.)
            };
            
        }
    }
}
