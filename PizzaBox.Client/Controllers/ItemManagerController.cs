using Microsoft.AspNetCore.Mvc;

namespace PizzaBox.Client.Controllers
{
  public class ItemManagerController : Controller
  {
    public IActionResult Select()
    {
      return View();
    }
  }
}