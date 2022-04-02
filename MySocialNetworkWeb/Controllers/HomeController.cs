using Microsoft.AspNetCore.Mvc;
using MySocialNetworkWeb.Models;
using System.Diagnostics;

namespace MySocialNetworkWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}