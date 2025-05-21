using Microsoft.AspNetCore.Mvc;
using DtdLesson5.Models.DataModel;
namespace DtdLesson5.Controllers
{
    public class DtdMemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DtdGetMember()
        {
            var dtdMember = new DtdMember();
            dtdMember.DtdMemberID = Guid.NewGuid().ToString();
            dtdMember.DtdUserName = "DtdUserName";
            dtdMember.DtdFullName = "DtdFullName";
            dtdMember.DtdPassword = "DtdPassword";
            dtdMember.DtdEmail = "DtdEmail";
            ViewBag.DtdMember = dtdMember;
            return View();
        }
    }
}
