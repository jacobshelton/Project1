using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Data;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Controllers
{
  public class UserController : Controller
  {
    private PizzaBoxDbContext _db = new PizzaBoxDbContext();

    [HttpGet]
    public IActionResult Create()
    {
      return View();
    } 

    [HttpPost]
    public IActionResult Create(User user)
    {
      if (ModelState.IsValid)
      {
        _db.Users.Add(user);
        _db.SaveChanges();

        return RedirectToAction("Login");
      }
      
      return View();
    }
    
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(User user)
    {
        if (user.Name == "Admin")
        {
            return RedirectToAction("Index","Home",new {area=""});
        }

        else if (_db.Users.ToList().Exists(u => u.Name == user.Name))
        {
            return RedirectToAction("UserIndex","Home",new {area=""});
        }

        return View();
    }

    public ViewResult Read()
    {
      return View(_db.Users.ToList());
    }
  }
}