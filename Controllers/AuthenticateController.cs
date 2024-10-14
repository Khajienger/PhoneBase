using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PhoneBase.Models;

public class AuthenticateController : Controller
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;

    //public AuthenticateController(UserManager<User> userManager, SignInManager<User> signInManager)
    //{
    //    _userManager = userManager;
    //    _signInManager = signInManager;
    //}

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<ActionResult> Register(UserRegistration model)
    {

        if (ModelState.IsValid)
        {
            var _user = new User { UserName = model.UserName };
            var createResult = await _userManager.CreateAsync(_user, model.Password);

            if (createResult.Succeeded)
            {
                await _signInManager.SignInAsync(_user, false);
                return RedirectToAction("Index", "Phones");
            }
        }
        return Redirect("/");
    }

    public IActionResult Authorization()
    {
        return View(new UserLogin());
    }

    [HttpGet]
    public IActionResult Registration()
    {
        return View(new UserRegistration());
    }

    [HttpGet]
    public IActionResult Login(string returnUrl)
    {
        return View(new UserLogin()
        {
            ReturnUrl = returnUrl
        });
    }

    //[HttpPost]
    //public async Task<IActionResult> Login(LoginModel model)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        var loginResult = await _signInManager.PasswordSignInAsync(model.Username,
    //            model.Password,
    //            false,
    //            lockoutOnFailure: false);

    //        if (loginResult.Succeeded)
    //        {
    //            if (Url.IsLocalUrl(model.ReturnUrl))
    //            {
    //                return Redirect(model.ReturnUrl);
    //            }
    //            return RedirectToAction("Index", "Home");
    //        }
    //    }

    //    ModelState.AddModelError("", "Пользователь не найден");
    //    return View(model);
    //}

    //[HttpPost, ValidateAntiForgeryToken]
    //public async Task<IActionResult> Logout()
    //{
    //    await _signInManager.SignOutAsync();
    //    return RedirectToAction("Index", "Home");
    //}
}

