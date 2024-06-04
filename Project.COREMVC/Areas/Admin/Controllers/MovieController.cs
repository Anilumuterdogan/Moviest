﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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
        public async Task<IActionResult> CreateMovie(MovieRequestPageVM model, IFormFile formFileImage, IFormFile formFileVideo) 
        {
            string extension = Path.GetExtension(formFileImage.FileName);
            string path = $"{Directory.GetCurrentDirectory()}/wwwroot/images/{Guid.NewGuid()}{extension}";
            FileStream stream = new FileStream(path, FileMode.Create);
            formFileImage.CopyTo(stream);

            string extension1 = Path.GetExtension(formFileVideo.FileName);
            string path1 = $"{Directory.GetCurrentDirectory()}/wwwroot/videos/{Guid.NewGuid()}{extension1}";
            FileStream stream1 = new FileStream(path1, FileMode.Create);
            formFileImage.CopyTo(stream1);



            Movie movie = new()
                {
                    MovieName = model.Movie.MovieName,
                    Description = model.Movie.Description,
                    ImagePath = path,
                    VideoPath = path1
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
