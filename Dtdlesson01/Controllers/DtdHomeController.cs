using System.Diagnostics;
using Dtdlesson01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dtdlesson01.Controllers
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

        public IActionResult DtdPrivacy()
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
