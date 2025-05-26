using Microsoft.AspNetCore.Mvc;

namespace DtdLab06.Models
{
    public class DtdEmployee : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
    
    
        public class Employee
        {
            public string MaSV { get; set; }
            public string HoTen { get; set; }
            public DateTime NgaySinh { get; set; }
            public string Phone { get; set; }
            public decimal Luong { get; set; }
            public string Status { get; set; }
        }
    }


