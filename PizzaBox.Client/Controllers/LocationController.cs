using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Data;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Controllers
{
  public class LocationController : Controller
  {
    private PizzaBoxDbContext _db = new PizzaBoxDbContext();

    [HttpGet]
    public IActionResult Create()
    {
      return View();
    } 

    [HttpPost]
    public IActionResult Create(Location location)
    {
      if (ModelState.IsValid)
      {
        _db.Locations.Add(location);
        _db.SaveChanges();

        return RedirectToAction("Read");
      }
      
      return View();
    }

        [HttpGet]
    public IActionResult Select()
    {
      return View();
    } 

    [HttpPost]
    public IActionResult Select(Location location)
    {
        return RedirectToAction("Read");
    }

    public ViewResult Read()
    {
      return View(_db.Locations.ToList());
    }
  }
}