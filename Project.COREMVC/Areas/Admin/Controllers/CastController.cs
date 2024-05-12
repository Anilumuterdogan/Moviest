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
        public async Task<IActionResult> CreateCast(CastRequestPageVM model)
        {
            Cast cast = new()
            {
                FirstName = model.Cast.FirstName,
                LastName = model.Cast.LastName,
                Description = model.Cast.Description,
                ImagePath = model.Cast.ImagePath,
                VideoPath = model.Cast.VideoPath,
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
        public async Task<IActionResult> UpdateCast(Cast model)
        {
            await _castManager.UpdateAsync(_mapper.Map<CastDTO>(model));
            return RedirectToAction("Index");
        }

    }
}
