using LegoINTEX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.AccessControl;

namespace LegoINTEX.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ILegoINTEXRepository _repo;

        public HomeController(ILogger<HomeController> logger, ILegoINTEXRepository temp)
        {
            _logger = logger;
            _repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
