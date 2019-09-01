using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Data;
using PizzaBox.Domain.Models;

namespace PizzaPlanet.Client.Controllers
{
  public class PizzaController : Controller
  {
    private PizzaBoxDbContext _db = new PizzaBoxDbContext();

    [HttpGet]
    public IActionResult Create()
    {
      return View(_db.Crusts.ToList());
    } 

    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
      if (ModelState.IsValid)
      {
        _db.Pizzas.Add(pizza);
        _db.SaveChanges();

        return RedirectToAction("Read");
      }
      
      return View();
    }

    public ViewResult Read()
    {
      return View(_db.Pizzas.ToList());
    }
  }
}