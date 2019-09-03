using Microsoft.AspNetCore.Mvc;

namespace PizzaBox.Client.Controllers
{
  public class LocationManagerController : Controller
  {
    public IActionResult Select()
    {
      return View();
    }
  }
}