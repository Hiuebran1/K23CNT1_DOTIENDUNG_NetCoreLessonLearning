using DtdLesson8.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace DtdLesson8.Controllers
{
    public class DtdAccountController : Controller
    {
        // GET: DtdAccountController
        public ActionResult Index()
        {
            List<DtdAccount> accounts = new List<DtdAccount>();

            return View(accounts);
        }

        // GET: DtdAccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DtdAccountController/Create
        public ActionResult Create()
        {
            DtdAccount model = new DtdAccount();
            return View(model);
        }

        // POST: DtdAccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DtdAccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DtdAccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DtdAccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DtdAccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        [AcceptVerbs("Get", "Post")]
        public ActionResult VerifyPhone(string dtdPhone)
        {
            // Simulate a phone number check (e.g., check against a database)
            // For demonstration, let's assume the phone number is valid if it starts with "+1"
            Regex _isPhone = new Regex(@"^\+1\d{10}$");
            if (!_isPhone.IsMatch(dtdPhone))
            {
                return Json($"Phone number is not valid,Ex: 0376963462 or 0376.963.462"); // Phone number is valid
            }
            else
            {
                return Json(true);
            }
        }
    }
}
