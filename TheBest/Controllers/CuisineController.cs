using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using TheBest.Models;

namespace TheBest.Controllers
{
  public class CuisineController : Controller 
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}