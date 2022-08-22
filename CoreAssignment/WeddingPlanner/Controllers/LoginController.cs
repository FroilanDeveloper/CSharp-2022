using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using WeddingPlanner.Models;
namespace WeddingPlanner.Controllers;

public class LoginController : Controller
{
    // public int? id
    // {
    //     get{
    //         return HttpContext.Session.GetInt32("session");
    //     }
    // }
    private MyContext _context;
    public LoginController(MyContext context)
    {
        _context = context;
    }

    [HttpGet("/")]
    public ViewResult Register()
    {
        HttpContext.Session.Clear();
        return View("Home");
    }

    [HttpPost("/register")]
    public IActionResult RegisterNew(User newUser)
    {
        if (ModelState.IsValid)
        {
            if(_context.Users.Any(u => u.Email == newUser.Email))
            {
                ModelState.AddModelError("Email", "Email already in use!");
                return Register();
            }
            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
            _context.Users.Add(newUser);
            _context.SaveChanges();
            HttpContext.Session.SetInt32("session", newUser.UserId);
            return RedirectToAction("WeddingHome", "Wedding");
        }
        return Register();
    }

    [HttpPost("/login/validation")]
    public IActionResult LoginValid(LoginUser user)
    {
        if (ModelState.IsValid)
        {
            var userInDb = _context.Users.FirstOrDefault(u => u.Email == user.EmailValid);
            if (userInDb == null)
            {
                ModelState.AddModelError("EmailValid", "Invalid Email/Password");
                return Register();
            }

            var hasher = new PasswordHasher<LoginUser>();

            var result = hasher.VerifyHashedPassword(user, userInDb.Password, user.PasswordValid);

            if (result == 0)
            {
                ModelState.AddModelError("EmailValid", "Invalid Email/Password");
                return Register();
            }
            else
            {
                HttpContext.Session.SetInt32("session", userInDb.UserId);
                return Redirect("/weddings");
            }
        }
        return Register();
    }
}