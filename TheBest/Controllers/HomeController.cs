using Microsoft.AspNetCore.Mvc;

namespace TheBest.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}