using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Concretes;
using Project.COMMON.Tools;
using Project.COREMVC.Models;
using Project.COREMVC.Models.AppUsers;
using Project.ENTITIES.Models;
using System.Diagnostics;

namespace Project.COREMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        readonly UserManager<AppUser> _userManager;
        readonly RoleManager<IdentityRole<int>> _roleManager;
        readonly SignInManager<AppUser> _signInManager;


        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager, RoleManager<IdentityRole<int>> roleManager, SignInManager<AppUser> signInManager)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterModel model) 
        {
           if(ModelState.IsValid) 
            {
                AppUser appUser = new()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                };

                IdentityResult result = await _userManager.CreateAsync(appUser,model.Password);


            }
            



        }
    }
}
