using Microsoft.AspNetCore.Mvc;
using TravelClient.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using TravelClient.ViewModels;


namespace TravelClient.Controllers
{
  public class AuthenticateController : Controller
  {
   

    

        // public ActionResult Index()
        // {
        //     return View();
        // }

        // public IActionResult Register()
        // {
        //     return View();
        // }

        // [HttpPost]
        // public async Task<ActionResult> Register(RegisterViewModel model)
        // {
        //     var user = new ApplicationUser { UserName = model.Username };
        //     IdentityResult result = await _userManager.CreateAsync(user, model.Password);
        //     if (result.Succeeded)
        //     {
        //         return RedirectToAction("Login");
        //     }
        //     else
        //     {
        //         return View();
        //     }
        // }

        // public ActionResult Login()
        // {
        //   return View();
        // }

        // [HttpPost]
        // public async Task<ActionResult> Login(LoginViewModel model)
        // {
        //   Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, isPersistent: true, lockoutOnFailure: false);
        //   if (result.Succeeded)
        //   {
        //     return RedirectToAction("Home", "Index");
        //   }
        //   else
        //   {
        //     return View();
        //   }
        // }

        // [HttpPost]
        // public async Task<ActionResult> LogOff()
        // {
        //   await _signInManager.SignOutAsync();
        //   return RedirectToAction("Index");
        // }
  }








}