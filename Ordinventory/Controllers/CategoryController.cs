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
        
        [HttpGet("{id}")]
        public ActionResult<Category> GetCategory(int id)
        {
            var category = _db.Categories.Find(id);
            if(category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }


        [HttpPost]
        public ActionResult<Category> AddCategory([FromBody]Category category)
        {
            if(category == null)
            {
                return BadRequest();
            }

            category.Id = 0;
            _db.Categories.Add(category);
            _db.SaveChanges();
            return CreatedAtAction(nameof(GetCategory), new { id = category.Id }, category);
        }
    }
}
