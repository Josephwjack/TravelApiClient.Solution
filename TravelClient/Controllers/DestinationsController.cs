using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelClient.Models;

namespace TravelClient.Controllers
{
  public class DestinationsController : Controller
  {
    public IActionResult Index()
    {
      var allDestinations = Destination.GetDestinations();
      return View(allDestinations);
    }

    [HttpPost]
    public IActionResult Index(Destination destination)
    {
      Destination.Post(destination);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var destination = Destination.GetDetails(id);
      return View(destination);
    }

    public IActionResult Edit()
   
  }

}
