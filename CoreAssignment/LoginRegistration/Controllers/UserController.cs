using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using LoginRegistration.Models;
namespace LoginRegistration.Controllers;

public class UserController : Controller
{
    private MyContext _context;

    public UserController(MyContext context)
    {
        _context = context;
    }

    [HttpGet("/")]
    public ViewResult Register()
    {
        return View("Registration");
    }

    [HttpPost("/register")]
    public IActionResult RegisterNew(User newUser)
    {
        if (ModelState.IsValid)
        {
            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
            _context.Users.Add(newUser);
            _context.SaveChanges();
            return View("User");
        }
        return Register();
    }

    [HttpGet("/login")]
    public IActionResult Login()
    {
        return View("Login");
    }

    [HttpPost("/login/validation")]
    public IActionResult LoginValid(LoginUser user)
    {
        if(ModelState.IsValid)
        {
            var userInDb = _context.Users.FirstOrDefault(u => u.Email == user.Email);
            if(userInDb == null)
            {
                ModelState.AddModelError("Email", "Invalid Email/Password");
                return Login();
            }

            var hasher = new PasswordHasher<LoginUser>();

            var result = hasher.VerifyHashedPassword(user, userInDb.Password, user.Password);

            if(result == 0)
            {
                ModelState.AddModelError("Email", "Invalid Email/Password");
                return Login();
            } else {
                return View("User");
            }
        }
        return Login();
    }
}