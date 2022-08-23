using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MeetUpExam.Models;
namespace MeetUpExam.Controllers;

public class MeetUpController : Controller
{
    public int? id
    {
        get{
            return HttpContext.Session.GetInt32("session");
        }
    }
    private MyContext _context;
    public MeetUpController(MyContext context)
    {
        _context = context;
    }

    [HttpGet("/meetups")]
    public IActionResult MeetUpMain()
    {
        if(HttpContext.Session.GetInt32("session") != null)
        {
            ViewBag.SingleUser = _context.Users.FirstOrDefault(u => u.UserId == id);
            ViewBag.AllMeetUps = _context.MeetUps.Include(m => m.Attendees).Include(u => u.User).OrderBy(m => m.DateAndTime).ToList();
            return View("MeetUp");
        }
        return RedirectToAction("Register", "Login");
    }

    [HttpGet("/new/meetup")]
    public IActionResult NewMeetUpPage()
    {
        ViewBag.SingleUser = _context.Users.FirstOrDefault(u => u.UserId == id);
        return View("NewMeetUp");
    }

    [HttpGet("/meetup/{meetupId}")]
    public IActionResult MeetUpPage(int meetupId)
    {
        ViewBag.OneMeetUp = _context.MeetUps.Include(u => u.User).Include(m => m.Attendees).ThenInclude(u => u.User).FirstOrDefault(m => m.MeetUpId == meetupId);
        MeetUp? OneMeetUp = _context.MeetUps.Include(u => u.User).Include(m => m.Attendees).ThenInclude(u => u.User).FirstOrDefault(m => m.MeetUpId == meetupId);
        return View("MeetUpDetail", OneMeetUp);
    }

    // Editing Database Routes
    // *****************************************************************

    [HttpGet("/delete/{meetupId}")]
    public IActionResult DeleteMeetUp(int meetupId)
    {
        MeetUp? DeleteMeetUp = _context.MeetUps.SingleOrDefault(m => m.MeetUpId == meetupId);
        if(DeleteMeetUp != null)
        {
            _context.MeetUps.Remove(DeleteMeetUp);
            _context.SaveChanges();
        }
        return RedirectToAction("MeetUpMain");
    }

    [HttpGet("/join/{meetupId}")]
    public IActionResult Join(int meetupId)
    {
        Association A = new Association();
        A.UserId = (int)id;
        A.MeetUpId = meetupId;
        _context.Associations.Add(A);
        _context.SaveChanges();
        return RedirectToAction("MeetUpMain");
    }

    [HttpGet("/unjoin/{meetupId}")]
    public IActionResult UnJoin(int meetUpId)
    {
        Association? A = _context.Associations.SingleOrDefault(m => m.MeetUpId == meetUpId && m.UserId == id);
        if(A != null)
        {
            _context.Associations.Remove(A);
            _context.SaveChanges();
        }
        return RedirectToAction("MeetUpMain");
    }


    // POST Routes
    // **************************************************************

    [HttpPost("/submit/meetup/{userId}")]
    public IActionResult NewMeetUp(int userId, MeetUp meetUp)
    {
        if(ModelState.IsValid)
        {
            meetUp.UserId = userId;
            _context.MeetUps.Add(meetUp);
            _context.SaveChanges();
            MeetUp? m = _context.MeetUps.FirstOrDefault(m => m.UserId == userId);
            int meetUpId = meetUp.MeetUpId;
            Console.WriteLine(meetUpId);
            return RedirectToAction("MeetUpPage", new {meetUpId} );
        }
        return NewMeetUpPage();
    }
}