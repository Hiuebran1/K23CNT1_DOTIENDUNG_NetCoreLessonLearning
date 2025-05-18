using Dtdlesson4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dtdlesson4.Controllers
{
    public class DtdBookController : Controller
    {
        private List<DtdBook> books = new List<DtdBook>
        {
            new DtdBook
            {
                Id = "B001",
                Title = "C# Programming Basics",
                Description = "An introductory guide to programming with C#.",
                Image = "https://example.com/images/csharp_basics.jpg",
                Price = 19.99f,
                Page = 320
            },
            new DtdBook
            {
                Id = "B002",
                Title = "Mastering ASP.NET Core",
                Description = "Deep dive into ASP.NET Core for modern web development.",
                Image = "https://example.com/images/aspnet_core.jpg",
                Price = 29.99f,
                Page = 450
            },
            new DtdBook
            {
                Id = "B003",
                Title = "Entity Framework Core In Action",
                Description = "Learn how to use EF Core to manage data in .NET applications.",
                Image = "https://example.com/images/ef_core.jpg",
                Price = 24.50f,
                Page = 380
            },
            new DtdBook
            {
                Id = "B004",
                Title = "LINQ Essentials",
                Description = "Explore the power and flexibility of LINQ in C#.",
                Image = "https://example.com/images/linq_essentials.jpg",
                Price = 15.00f,
                Page = 250
            },
            new DtdBook
            {
                Id = "B005",
                Title = "Clean Code in C#",
                Description = "Best practices and principles for writing clean, maintainable code in C#.",
                Image = "https://example.com/images/clean_code.jpg",
                Price = 27.75f,
                Page = 400
            }
        };
        public IActionResult DtdIndex()
        {
            return View(books);
        } 
        public IActionResult DtdCreate()
        {
            DtdBook book = new DtdBook();
            return View(books);
        }
    }
}

