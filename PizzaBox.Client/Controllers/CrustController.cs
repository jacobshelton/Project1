using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Data;
using PizzaBox.Domain.Models;

namespace PizzaPlanet.Client.Controllers
{
  public class CrustController : Controller
  {
    private PizzaBoxDbContext _db = new PizzaBoxDbContext();

    [HttpGet]
    public IActionResult Create()
    {
      return View();
    } 

    [HttpPost]
    public IActionResult Create(Crust crust)
    {
      if (ModelState.IsValid)
      {
        _db.Crusts.Add(crust);
        _db.SaveChanges();

        return RedirectToAction("Read");
      }
      
      return View();
    }

    public ViewResult Read()
    {
      return View(_db.Crusts.ToList());
    }
  }
}