using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ordinventory.Data;

namespace Ordinventory.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Category
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }
    }
}