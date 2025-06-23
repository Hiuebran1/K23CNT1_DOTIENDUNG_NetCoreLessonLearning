using Dtdlesson9.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dtdlesson9.Controllers
{
    public class DtdCategoriesController : Controller
    {
        private readonly DtdBookStoreContext _context;

        public DtdCategoriesController(DtdBookStoreContext context)
        {
            _context = context;
        }

        // GET: DtdCategories
        public async Task<IActionResult> DtdIndex(string keyword)
        {
            var DtdCategories = await _context.Categories.ToListAsync();
            if (!string.IsNullOrEmpty(keyword))
            {
                DtdCategories = DtdCategories
                    .Where(x => x.CategoryName.Contains(keyword)).ToList();
            }
            return View(DtdCategories);
        }

        // GET: DtdCategories/Details/5
        public async Task<IActionResult> DtdDetails(int? dtdid)
        {
            if (dtdid == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == dtdid);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: DtdCategories/Create
        public IActionResult DtdCreate()
        {
            var dtdCategory = new Category();
            return View(dtdCategory);
        }

        // POST: DtdCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DtdCreate([Bind("CategoryId,CategoryName")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(DtdIndex));
            }
            return View(category);
        }

        // GET: DtdCategories/Edit/5
        public async Task<IActionResult> DtdEdit(int? dtdid)
        {
            if (dtdid == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(dtdid);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: DtdCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DtdEdit(int dtdid, [Bind("CategoryId,CategoryName")] Category category)
        {
            if (dtdid != category.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CategoryId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(DtdIndex));
            }
            return View(category);
        }

        // GET: DtdCategories/Delete/5
        public async Task<IActionResult> DtdDelete(int? dtdid)
        {
            if (dtdid == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == dtdid);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: DtdCategories/Delete/5
        [HttpPost, ActionName("DtdDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int dtdid)
        {
            var category = await _context.Categories.FindAsync(dtdid);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(DtdIndex));
        }

        private bool CategoryExists(int dtdid)
        {
            return _context.Categories.Any(e => e.CategoryId == dtdid);
        }
    }
}
