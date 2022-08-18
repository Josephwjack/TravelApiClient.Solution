using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;
using System.Security.Claims;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TravelClient.Models;



namespace TravelClient.Controllers
{
  public class AuthenticateController : Controller
  {
      private readonly ILogger<AuthenticateController> _logger;

      public AuthenticateController(ILogger<AuthenticateController> logger)
      {
        _logger = logger;
      }

      public IActionResult Index()
      {
        return View();
      }







  }
}