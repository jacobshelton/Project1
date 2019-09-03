using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Data;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Controllers
{
  public class UserPizzaController : Controller
  {
    private PizzaBoxDbContext _db = new PizzaBoxDbContext();
    Pizza Pizza = new Pizza();

    [HttpGet]
    public IActionResult ChooseLocation()
    {
        return View(_db.Locations.ToList());
    } 

    [HttpPost]
    public IActionResult ChooseLocation(Location location)
    {
        TempData["LocationAddress"] = location.Address;

        return RedirectToAction("Create");
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View(_db.Pizzas.ToList());
    } 

    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        TempData["PizzaName"] = pizza.Name;

        if (pizza.Name == "Custom")
        {
            return RedirectToAction("CrustSelect");
        }

        return View();
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

        return RedirectToAction("ToppingSelect");
    }

    [HttpGet]
    public IActionResult ToppingSelect()
    {
        return View(_db.Toppings.ToList());
    }

    [HttpPost]
    public IActionResult ToppingSelect(List<string> toppings)
    {  
        TempData["ToppingCount"] = toppings.Count;

        switch (toppings.Count)
        {
            case 1:
                TempData["ToppingName"] = toppings[0];
                break;

            case 2:
                TempData["ToppingName"] = toppings[0];
                TempData["ToppingName1"] = toppings[1];
                break;

            case 3:
                TempData["ToppingName"] = toppings[0];
                TempData["ToppingName1"] = toppings[1];
                TempData["ToppingName2"] = toppings[2];
                break;

            case 4:
                TempData["ToppingName"] = toppings[0];
                TempData["ToppingName1"] = toppings[1];
                TempData["ToppingName2"] = toppings[2];
                TempData["ToppingName3"] = toppings[3];
                break;

            case 5:
                TempData["ToppingName"] = toppings[0];
                TempData["ToppingName1"] = toppings[1];
                TempData["ToppingName2"] = toppings[2];
                TempData["ToppingName3"] = toppings[3];
                TempData["ToppingName4"] = toppings[4];
                break;

            default:
                return View(_db.Toppings.ToList());
        }

        return RedirectToAction("Data");
    }


    public IActionResult Data(Pizza pizza, Crust crust, Size size)
    {
        return RedirectToAction("Read");
    }

    public ViewResult Read(Pizza pizza, Crust crust, Size size, List<string> toppings)
    {
        int count = int.Parse(TempData["ToppingCount"].ToString());

        pizza.Name = TempData["PizzaName"].ToString();
        crust.Name = TempData["CrustName"].ToString();
        size.Name = TempData["SizeName"].ToString();

        switch (toppings.Count)
        {
            case 1:
                toppings.Add(TempData["ToppingName"].ToString());
                break;

            case 2:
                toppings.Add(TempData["ToppingName"].ToString());
                toppings.Add(TempData["ToppingName1"].ToString());
                break;

            case 3:
                toppings.Add(TempData["ToppingName"].ToString());
                toppings.Add(TempData["ToppingName1"].ToString());
                toppings.Add(TempData["ToppingName2"].ToString());
                break;

            case 4:
                toppings.Add(TempData["ToppingName"].ToString());
                toppings.Add(TempData["ToppingName1"].ToString());
                toppings.Add(TempData["ToppingName2"].ToString());
                toppings.Add(TempData["ToppingName3"].ToString());
                break;

            case 5:
                toppings.Add(TempData["ToppingName"].ToString());
                toppings.Add(TempData["ToppingName1"].ToString());
                toppings.Add(TempData["ToppingName2"].ToString());
                toppings.Add(TempData["ToppingName3"].ToString());
                toppings.Add(TempData["ToppingName4"].ToString());
                break;
        }

        pizza.Crust = _db.Crusts.ToList().Find(c => c.Name.Contains(crust.Name));
        pizza.Size = _db.Sizes.ToList().Find(s => s.Name.Contains(size.Name));

        ViewBag.PizzaName = pizza.Name;
        ViewBag.CrustName = crust.Name;
        ViewBag.SizeName = size.Name;

        double sum = 0.0;
        foreach(var item in pizza.Toppings)
            sum += item.Price;

        ViewBag.PizzaPrice = pizza.Crust.Price + pizza.Size.Price;

        return View();
    }
  }
}