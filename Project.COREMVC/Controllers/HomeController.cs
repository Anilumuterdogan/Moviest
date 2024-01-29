using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Concretes;
using Project.COMMON.Tools;
using Project.COREMVC.Models;
using Project.COREMVC.Models.AppUsers;
using Project.ENTITIES.Models;
using System.Diagnostics;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

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

                if(result.Succeeded) 
                {
                    #region RolKontrolIslemi
                    IdentityRole<int> appRole = await _roleManager.FindByNameAsync("Member");
                    if (appRole == null) await _roleManager.CreateAsync(new() { Name = "Member" });
                    await _userManager.AddToRoleAsync(appUser, "Member");
                    #endregion

                    Guid specId = Guid.NewGuid();
                    string body = $"Your account has been created. To confirm your membership, please http://localhost:5166/Home/ConfirmEmail?specId={specId}&id={appUser.Id} Click on the link\";";

                    MailService.Send(model.Email, body: body);

                    TempData["Message"] = "Check your email";
                    return RedirectToAction("RedirectPanel");

                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View();
        }

        public async Task<IActionResult> ConfirmEmail(Guid specId, int id)
        {

            AppUser user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                TempData["Message"] = "User not found";
                return RedirectToAction("RedirectPanel");
            }
            user.EmailConfirmed = true;
            await _userManager.UpdateAsync(user);
            TempData["Message"] = "Your email has been successfully confirmed";
            return RedirectToAction("SignIn");
        }
        public IActionResult RedirectPanel()
        {
            return View();
        }

        public IActionResult SignIn(string returnUrl)
        {
            UserSignInRequestModel usModel = new()
            {
                ReturnUrl = returnUrl
            };

            return View(usModel);
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignInRequestModel model) 
        {
            if (ModelState.IsValid) 
            {
                AppUser appUser = await _userManager.FindByNameAsync(model.UserName); 

                SignInResult result = await _signInManager.PasswordSignInAsync(appUser, model.Password, model.RememberMe, true);
                if(result.Succeeded)
                {
                    if (!string.IsNullOrWhiteSpace(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }

                    IList<string> roles = await _userManager.GetRolesAsync(appUser);
                    if (roles.Contains("Admin"))
                    {
                        return RedirectToAction("AdminPanel");
                    }
                    else if (roles.Contains("Member"))
                    {
                        return RedirectToAction("Member"); //Todo watch list yönledir
                    }
                    return RedirectToAction("Register"); //Todo Panel yerine baþka birþey yazýcaz
                }
                else if (result.IsNotAllowed)
                {
                    return RedirectToAction("MailPanel");
                }
                
                else if (result.IsLockedOut)
                {

                    DateTimeOffset? lockOutEndDate = await _userManager.GetLockoutEndDateAsync(appUser);

                    ModelState.AddModelError("", $"Your account {(lockOutEndDate.Value.UtcDateTime - DateTime.UtcNow).Minutes} was suspended for minutes");
                }

                else
                {
                    string message = "";

                    if (appUser != null)
                    {
                        int maxFailedAttempts = _userManager.Options.Lockout.MaxFailedAccessAttempts;

                        message = $"If {maxFailedAttempts - await _userManager.GetAccessFailedCountAsync(appUser)} If you log in incorrectly again, your account will be temporarily suspended. ";
                    }
                    else
                    {
                        message = "User not found";
                    }

                    ModelState.AddModelError("", message);
                }

            }
            TempData["Message"] = "User not found";
            return RedirectToAction("SignIn");
        }

        public IActionResult MailPanel()
        {
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("SignIn");
        }
    }
}
