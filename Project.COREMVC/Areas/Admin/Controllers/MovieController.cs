using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.BLL.DTOClasses;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.COREMVC.Areas.Admin.Models.Genres.PageVms;
using Project.COREMVC.Areas.Admin.Models.Movies.PageVms;
using Project.COREMVC.Areas.Admin.Models.Movies.PureVms;
using Project.COREMVC.Areas.Admin.Models.Movies.SharedVMs;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class MovieController : Controller
    {
        readonly IMovieManager _movieManager;
        readonly IGenreManager _genreManager;
        readonly IMovieGenreManager _movieGenreManager;
        IMapper _mapper;

        public MovieController(IMovieManager movieManager, IGenreManager genreManager, IMovieGenreManager movieGenreManager, IMapper mapper)
        {
            _movieManager = movieManager;
            _genreManager = genreManager;
            _movieGenreManager = movieGenreManager;
            _mapper = mapper;
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
        public async Task<IActionResult> CreateMovie(MovieRequestPageVM model,IFormFile formFileImage, IFormFile formFileVideo) 
        {
            Guid uniqueName = Guid.NewGuid();
            string extension = Path.GetExtension(formFileImage.FileName);
            model.Movie.ImagePath = $"/images/{uniqueName}{extension}";
            string path = $"{Directory.GetCurrentDirectory()}/wwwroot{model.Movie.ImagePath}";
            FileStream stream = new FileStream(path, FileMode.Create);
            formFileImage.CopyTo(stream);

            Guid uniqueName2 = Guid.NewGuid();
            string extension2 = Path.GetExtension(formFileVideo.FileName);
            model.Movie.VideoPath = $"/videos/{uniqueName2}{extension2}";
            string pathVideo = $"{Directory.GetCurrentDirectory()}/wwwroot{model.Movie.VideoPath}";
            FileStream stream2 = new FileStream(pathVideo, FileMode.Create);
            formFileVideo.CopyTo(stream2);

           


            Movie movie = new()
                {
                    MovieName = model.Movie.MovieName,
                    Description = model.Movie.Description,
                    ImagePath = path,
                    VideoPath = pathVideo
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
        public async Task<IActionResult> UpdateMovie(Movie model, IFormFile formFileImage, IFormFile formFileVideo)
        {
            
                Guid uniqueName = Guid.NewGuid();
            string extension = Path.GetExtension(formFileImage.FileName);
            model.ImagePath = $"/images/{uniqueName}{extension}";
            string path = $"{Directory.GetCurrentDirectory()}/wwwroot{model.ImagePath}";
            FileStream stream = new FileStream(path, FileMode.Create);
            formFileImage.CopyTo(stream);
            
            
                Guid uniqueName2 = Guid.NewGuid();
            string extension2 = Path.GetExtension(formFileVideo.FileName);
            model.VideoPath = $"/videos/{uniqueName2}{extension2}";
            string pathVideo = $"{Directory.GetCurrentDirectory()}/wwwroot{model.VideoPath}";
            FileStream stream2 = new FileStream(pathVideo, FileMode.Create);
            formFileVideo.CopyTo(stream2);
            

            await _movieManager.UpdateAsync(_mapper.Map<MovieDTO>(model));
            return RedirectToAction("Index");
        }

        
    }
}
