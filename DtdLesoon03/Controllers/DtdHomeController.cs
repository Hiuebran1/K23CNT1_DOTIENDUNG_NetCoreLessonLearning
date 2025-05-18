using System.Diagnostics;
using DtdLesoon03.Models;
using Microsoft.AspNetCore.Mvc;

namespace DtdLesoon03.Controllers
{
    public class DtdHomeController : Controller
    {
        private readonly ILogger<DtdHomeController> _logger;

        public DtdHomeController(ILogger<DtdHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult DtdIndex()
        {
            return View();
        }

        public IActionResult DtdAbout()
        {
            ViewBag.about = "do dung";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult DtdProfile()
        {
            return View();
        }

        public IActionResult DtdRazerCode()
        {
            return View();
        }
    }
}
