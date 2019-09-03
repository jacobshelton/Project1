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
    Pizza Pizza = new Pizza();

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    } 

    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        TempData["PizzaName"] = pizza.Name;
        return RedirectToAction("CrustSelect");
    }

    [HttpGet]
    public IActionResult CrustSelect()
    {
        return View(_db.Crusts.ToList());
    }

    [HttpPost]
    public IActionResult CrustSelect(Crust crust)
    {
        TempData["CrustName"] = crust.Name;
        return RedirectToAction("SizeSelect");
    }

    [HttpGet]
    public IActionResult SizeSelect()
    {
        return View(_db.Sizes.ToList());
    }

    [HttpPost]
    public IActionResult SizeSelect(Size size)
    {
        TempData["SizeName"] = size.Name;

        return RedirectToAction("Data");
    }

    // [HttpGet]
    // public IActionResult ToppingSelect()
    // {
    //     return View(_db.Toppings.ToList());
    // }

    // [HttpPost]
    // public IActionResult ToppingSelect(Pizza pizza)
    // {
    //     foreach(var item in pizza.Toppings)
    //     {
    //         Pizza.Toppings.Add(item);
    //     } 

    //     if (ModelState.IsValid)
    //     {
    //         _db.Pizzas.Add(Pizza);
    //         _db.SaveChanges();

    //         return RedirectToAction("Read");
    //     }
    //     return View();
    // }

    public IActionResult Data(Pizza pizza, Crust crust, Size size)
    {
        pizza.Name = TempData["PizzaName"].ToString();
        crust.Name = TempData["CrustName"].ToString();
        size.Name = TempData["SizeName"].ToString();

        pizza.Crust = _db.Crusts.ToList().Find(c => c.Name.Contains(crust.Name));
        pizza.Size = _db.Sizes.ToList().Find(s => s.Name.Contains(size.Name));

        _db.Pizzas.Add(pizza);
        _db.SaveChanges();

        return RedirectToAction("Read");
    }

    public ViewResult Read()
    {
        return View(_db.Pizzas.ToList());
    }
  }
}