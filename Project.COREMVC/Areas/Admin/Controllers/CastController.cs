using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.DTOClasses;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.COREMVC.Areas.Admin.Models.Casts.PageVms;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CastController : Controller
    {
        readonly ICastManager _castManager;
        IMapper _mapper;

        public CastController(ICastManager castManager, IMapper mapper)
        {
            _castManager = castManager;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
                RedirectToAction("Index", "Home");

            return View(_mapper.Map<List<Cast>>(_castManager.GetAll()));
        }

        public IActionResult CreateCast()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCast(CastRequestPageVM model, IFormFile formFileImage)
        {
            string pathImg = "";
            if (formFileImage != null)
            {
                Guid uniqueName = Guid.NewGuid();
                string extension = Path.GetExtension(formFileImage.FileName);
                model.Cast.ImagePath = $"/castimages/{uniqueName}{extension}";
                string path = $"{Directory.GetCurrentDirectory()}/wwwroot{model.Cast.ImagePath}";
                FileStream stream = new FileStream(path, FileMode.Create);
                pathImg = path;
                formFileImage.CopyTo(stream);
            }
            Cast cast = new()
            {
                FirstName = model.Cast.FirstName,
                LastName = model.Cast.LastName,
                Description = model.Cast.Description,
                ImagePath = pathImg

            };
            await _castManager.AddAsync(_mapper.Map<CastDTO>(cast));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteCast(int id)
        {
            _castManager.Delete(await _castManager.FindAsync(id));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DestroyCast(int id)
        {
            _castManager.Destroy(await _castManager.FindAsync(id));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateCast(int id)
        {
            return View(_mapper.Map<Cast>(await _castManager.FindAsync(id)));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCast(Cast model, IFormFile formFileImage)
        {
            string orgImg, orgVid;
            var movie = await _castManager.FindAsync(model.ID);
            orgImg = movie.ImagePath;
            if (formFileImage != null)
            {
                Guid uniqueName = Guid.NewGuid();
                string extension = Path.GetExtension(formFileImage.FileName);
                model.ImagePath = $"/castimages/{uniqueName}{extension}";
                string path = $"{Directory.GetCurrentDirectory()}/wwwroot{model.ImagePath}";
                FileStream stream = new FileStream(path, FileMode.Create);               
                formFileImage.CopyTo(stream);
            }
            else
            {
                model.ImagePath = orgImg;
            }
            await _castManager.UpdateAsync(_mapper.Map<CastDTO>(model));
            return RedirectToAction("Index");
        }

    }
}
