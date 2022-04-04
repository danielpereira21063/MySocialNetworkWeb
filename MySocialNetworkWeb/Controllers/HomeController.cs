using Microsoft.AspNetCore.Mvc;

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