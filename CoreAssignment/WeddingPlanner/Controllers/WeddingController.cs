using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using WeddingPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers;

public class WeddingController : Controller
{
    private int? id
    {
        get
        {
            return HttpContext.Session.GetInt32("session");
        }
    }
    private MyContext _context;
    public WeddingController(MyContext context)
    {
        _context = context;
    }

    [HttpGet("/weddings")]
    public IActionResult WeddingHome()
    {
        if(HttpContext.Session.GetInt32("session") != null)
        {
            List<Wedding> AllWeddings = _context.Weddings.Include(u => u.Attendees).ToList();
            return View("Weddings", AllWeddings);
        } else {
            return RedirectToAction("Register", "Login");
        }
    }

    [HttpGet("/new/wedding")]
    public IActionResult NewWedding()
    {
        if (HttpContext.Session.GetInt32("session") != null)
        {
            return View("NewWedding");
        } 
        else
        {
            return RedirectToAction("Register", "Login");
        }
    }

    [HttpGet("/delete/{weddingId}")]
    public IActionResult DeleteWedding(int weddingId)
    {
        Wedding? DeletedWedding = _context.Weddings.SingleOrDefault(w => w.WeddingId == weddingId);
        if(DeletedWedding != null)
        {
            _context.Weddings.Remove(DeletedWedding);
            _context.SaveChanges();
        }
        return RedirectToAction("WeddingHome");
    }

    [HttpGet("/rsvp/{weddingId}")]
    public IActionResult RSVP(int weddingId)
    {
        Association ass = new Association();
        ass.UserId = (int)id;
        ass.WeddingId = weddingId;
        _context.Associations.Add(ass);
        _context.SaveChanges();
        return RedirectToAction("WeddingHome");
    }

    [HttpGet("/unrsvp/{weddingId}")]
    public IActionResult UNRSVP(int weddingId)
    {
        Association? association = _context.Associations.SingleOrDefault(w => w.WeddingId == weddingId && w.UserId == id);
        if(association != null)
        {
            _context.Associations.Remove(association);
            _context.SaveChanges();
        }
        return RedirectToAction("WeddingHome");
    }

    [HttpGet("/wedding/{weddingId}")]
    public IActionResult DetailPage(int weddingId)
    {
        ViewBag.SingleWedding = _context.Weddings.Include(u => u.Attendees).ThenInclude(u => u.User).FirstOrDefault(w => w.WeddingId == weddingId);

        return View("WeddingDetail");
    }

    [HttpPost("/create/wedding")]
    public IActionResult SubmitWedding(Wedding newWedding)
    {
        if(ModelState.IsValid)
        {
            newWedding.Creator = id;
            _context.Weddings.Add(newWedding);
            _context.SaveChanges();
            return RedirectToAction("WeddingHome");
        }
        return NewWedding();
    }
}