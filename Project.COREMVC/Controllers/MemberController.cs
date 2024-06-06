using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Project.BLL.DTOClasses;
using Project.BLL.ManagerServices.Abstracts;
using Project.COREMVC.Models.Members.MemberPageVM;
using Project.COREMVC.Models.Members.Movies;
using Project.ENTITIES.Models;
using System.Collections.Generic;
using X.PagedList;

namespace Project.COREMVC.Controllers
{
    public class MemberController : Controller
    {
        readonly IGenreManager _genreManager;
        readonly IMovieManager _movieManager;
        readonly IMovieGenreManager _movieGenreManager;
        readonly IMapper _mapper;

        public MemberController(IGenreManager genreManager, IMovieManager movieManager, IMapper mapper, IMovieGenreManager movieGenreManager)
        {
            _genreManager = genreManager;
            _movieManager = movieManager;

            _mapper = mapper;
            _movieGenreManager = movieGenreManager;
        }

        public IActionResult Index(int? page, int? genreID)
        {
            MemberMovieVM memberMovie = new MemberMovieVM()
            {
                Movies = genreID == null ? _movieManager.GetActives().ToPagedList(page ?? 1,9): _movieGenreManager.Where(x => x.GenreID == genreID).ToList().ToPagedList(page ?? 1, 9),

                Genres = _genreManager.GetActives()
            };
            
            
            return View(memberMovie);
        }
    }
}
