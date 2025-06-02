using Microsoft.AspNetCore.Mvc;
using Dtdlesson7.Models;
using System.Collections.Generic;
using System.Linq;

namespace Dtdesson7.Controllers
{
    public class DtdEmployeeController : Controller
    {
        // Dữ liệu tĩnh 5 nhân viên
        private static List<DtdEmployee> employees = new List<DtdEmployee>()
        {
            new DtdEmployee { DtdId = 1, DtdName = "Do Tien Dung", DtdBirthDay = "2005-10-26", Email = "dodung26102005@gmail.com", DtdPhone = "0376963462" },
            new DtdEmployee { DtdId = 2, DtdName = "Tran Thi B", DtdBirthDay = "1992-02-02", Email = "b@example.com", DtdPhone = "0987654321" },
            new DtdEmployee { DtdId = 3, DtdName = "Le Van C", DtdBirthDay = "1988-03-03", Email = "c@example.com", DtdPhone = "0912345678" },
            new DtdEmployee { DtdId = 4, DtdName = "Pham Thi D", DtdBirthDay = "1995-04-04", Email = "d@example.com", DtdPhone = "0999888777" },
            new DtdEmployee { DtdId = 5, DtdName = "Hoang Van E", DtdBirthDay = "1991-05-05", Email = "e@example.com", DtdPhone = "0900777666" }
        };

        // GET: NvtIndex
        public IActionResult DtdIndex()
        {
            return View(employees);
        }

        // GET: NvtDetails
        public IActionResult DtdDetails(int id)
        {
            var emp = employees.FirstOrDefault(e => e.DtdId == id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        // GET: NvtCreate
        public IActionResult DtdCreate()
        {
            return View();
        }

        // POST: NvtCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DtdCreate(DtdEmployee employee)
        {
            if (ModelState.IsValid)
            {
                employee.DtdId = employees.Max(e => e.DtdId) + 1;
                employees.Add(employee);
                return RedirectToAction(nameof(DtdIndex));
            }
            return View(employee);
        }

        // GET: NvtEdit
        public IActionResult DtdEdit(int id)
        {
            var emp = employees.FirstOrDefault(e => e.DtdId == id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        // POST: NvtEdit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DtdEdit(int id, DtdEmployee employee)
        {
            if (id != employee.DtdId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var existingEmp = employees.FirstOrDefault(e => e.DtdId == id);
                if (existingEmp != null)
                {
                    existingEmp.DtdName = employee.DtdName;
                    existingEmp.DtdBirthDay = employee.DtdBirthDay;
                    existingEmp.Email = employee.Email;
                    existingEmp.DtdPhone = employee.DtdPhone;
                }
                return RedirectToAction(nameof(DtdIndex));
            }
            return View(employee);
        }

        // GET: NvtDelete
        public IActionResult DtdDelete(int id)
        {
            var emp = employees.FirstOrDefault(e => e.DtdId == id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        // POST: NvtDelete
        [HttpPost, ActionName("DtdDelete")]
        [ValidateAntiForgeryToken]
        public IActionResult DtdDeleteConfirmed(int id)
        {
            var emp = employees.FirstOrDefault(e => e.DtdId == id);
            if (emp != null)
            {
                employees.Remove(emp);
            }
            return RedirectToAction(nameof(DtdIndex));
        }
    }
}