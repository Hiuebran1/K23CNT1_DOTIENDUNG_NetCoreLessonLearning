using DtdLab06.Models;
using Microsoft.AspNetCore.Mvc;


namespace DtdLab06.Controllers
{
    public class DtdEmployeeController : Controller
    {
        // Danh sách nhân viên (biến tĩnh)
        public static List<Employee> dtdListEmployee = new List<Employee>
        {
            new Employee { MaSV = "SV001", HoTen = "Nguyễn Văn A", NgaySinh = new DateTime(1999, 1, 1), Phone = "0901234567", Luong = 10000000, Status = "Đang học" },
            new Employee { MaSV = "SV002", HoTen = "Trần Thị B", NgaySinh = new DateTime(2000, 2, 15), Phone = "0912345678", Luong = 11000000, Status = "Đang học" },
            new Employee { MaSV = "SV003", HoTen = "Lê Văn C", NgaySinh = new DateTime(1998, 5, 20), Phone = "0987654321", Luong = 9000000, Status = "Đã tốt nghiệp" },
            new Employee { MaSV = "SV004", HoTen = "Phạm Thị D", NgaySinh = new DateTime(2001, 7, 10), Phone = "0978123456", Luong = 12000000, Status = "Đang học" },
            new Employee { MaSV = "SV005", HoTen = "Đỗ Văn E", NgaySinh = new DateTime(1997, 12, 30), Phone = "0965432109", Luong = 8500000, Status = "Bảo lưu" }
        };
        public IActionResult DtdListEmployee()
        {
            return View(dtdListEmployee);
        }
        // GET: Hiển thị danh sách nhân viên
        public IActionResult DtdIndex()
        {
            return View(dtdListEmployee);
        }

        // GET: Hiển thị form thêm mới
        [HttpGet]
        public IActionResult DtdCreate()
        {
            return View();
        }

        // POST: Thêm mới nhân viên vào danh sách
        [HttpPost]
        public IActionResult DtdCreateSubmit(Employee emp)
        {
            if (ModelState.IsValid)
            {
                dtdListEmployee.Add(emp);
                return RedirectToAction("DtdIndex");
            }

            return View("DtdCreate", emp); // Nếu lỗi thì hiển thị lại form
        }
    }
}
