using Microsoft.AspNetCore.Mvc;

namespace PizzaBox.Client.Controllers
{
  public class PizzaManagerController : Controller
  {
    public IActionResult Select()
    {
      return View();
    }
  }
}