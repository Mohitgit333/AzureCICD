using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using productservice.data;
using productservice.models;

namespace productservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/product
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _context.Products.ToListAsync();

            return Ok(products);
        }
    }
}