using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TheBest.Controllers
{
  public class RestaurantsController : Controller
  {
    private readonly TheBestContext _db;

    public RestaurantsController(TheBestContext db)
    {
      _db = db; 
    }
    public ActionResult Index()
    {
      List<Restaurant> model = _db.Restaurants.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      ViewBag.CuisineId = new SelectList(db.Cuisines, "")
    }
  }
}