using Microsoft.AspNetCore.Mvc;

namespace PizzaPlanet.Client.Controllers
{
  public class PizzaManagerController : Controller
  {
    public IActionResult Select()
    {
      return View();
    }
  }
}