using Microsoft.AspNetCore.Mvc;

namespace PizzaPlanet.Client.Controllers
{
  public class ItemManagerController : Controller
  {
    public IActionResult Select()
    {
      return View();
    }
  }
}