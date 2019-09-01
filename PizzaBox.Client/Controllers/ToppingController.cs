using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Data;
using PizzaBox.Domain.Models;

namespace PizzaPlanet.Client.Controllers
{
  public class ToppingController : Controller
  {
    private PizzaBoxDbContext _db = new PizzaBoxDbContext();

    [HttpGet]
    public IActionResult Create()
    {
      return View();
    } 

    [HttpPost]
    public IActionResult Create(Topping topping)
    {
      if (ModelState.IsValid)
      {
        _db.Toppings.Add(topping);
        _db.SaveChanges();

        return RedirectToAction("Read");
      }
      
      return View();
    }

    public ViewResult Read()
    {
      return View(_db.Toppings.ToList());
    }
  }
}