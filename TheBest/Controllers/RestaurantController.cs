using Microsoft.AspNetCore.Mvc;
using TheBest.Models;
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
      return View();
    }
    [HttpPost]
    public ActionResult Create (Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Restaurant thisRestaurant = _db.Restaurants.FirstorDefault(restaurants => restaurants.RestaurantId == id);
      return View(thisItem);
    }
  }
}