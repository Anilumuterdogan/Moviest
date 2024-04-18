using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.DTOClasses;
using Project.BLL.ManagerServices.Abstracts;
using Project.COREMVC.Areas.Admin.Models.Genres.PageVms;
using Project.COREMVC.Areas.Admin.Models.Genres.PureVms;
using Project.COREMVC.Areas.Admin.Models.Genres.RequestModels;
using Project.COREMVC.Areas.Admin.Models.MapperClasses;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class GenreController : Controller
    {
        readonly IGenreManager _genreManager;
        IMapper _mapper;
        public GenreController(IGenreManager genreManager, IMapper mapper)
        {
            _genreManager = genreManager; 
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
                RedirectToAction("Index", "Home");

            return View(_mapper.Map<List<Genre>>(_genreManager.GetAll()));
        }

        public IActionResult CreateGenre() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateGenre(GenreRequestPageVM model)
        {
            Genre genre = new()
            {
                GenreName = model.Genre.GenreName
            };
            await _genreManager.AddAsync(_mapper.Map<GenreDTO>(genre));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteGenre(int id) 
        {
            _genreManager.Delete(await _genreManager.FindAsync(id));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DestroyGenre (int id) 
        {
           _genreManager.Destroy(await _genreManager.FindAsync(id));
            return RedirectToAction("Index");
        }

        
        public async Task<IActionResult> UpdateGenre (int id)
        {
            
            
            
            return View(_mapper.Map<Genre>(await _genreManager.FindAsync(id)));

        }

        [HttpPost]
        public async Task<IActionResult> UpdateGenre (Genre model)
        {
            await _genreManager.UpdateAsync(_mapper.Map<GenreDTO>(model));
            return RedirectToAction("Index");
        }
    }
}
