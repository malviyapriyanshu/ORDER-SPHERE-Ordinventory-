using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ordinventory.Data;
using Ordinventory.Models;

namespace Ordinventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<List<Category>> GetCategories()
        {
            var categories = _db.Categories.ToList();
            return Ok(categories);
        }
    }
}
