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
        // private readonly AppDbContext _context;

        // public ProductController(AppDbContext context)
        // {
        //     _context = context;
        // }

        // GET: api/product
       [HttpGet]
       [Route("GetAll")]
public IActionResult GetAll()
{
    var products = new List<Product>
    {
        new Product
        {
            Id = 1,
            Name = "Laptop",
            Price = 55000
        },
        new Product
        {
            Id = 2,
            Name = "Mobile",
            Price = 25000
        },
        new Product
        {
            Id = 3,
            Name = "Tablet",
            Price = 18000
        },
        new Product
        {
            Id = 4,
            Name = "Headphones",
            Price = 3000
        }
    };

    return Ok(products);
}

[HttpGet]
[Route("GetCurrentTime")]

public IActionResult GetCurrentTime()
        {
            return Ok(DateTime.Now.ToString());
        }

        //  // POST: api/product
        // [HttpPost]
        // public async Task<IActionResult> Create(Product product)
        // {
        //     var result = await _context.Products.AddAsync(product);

        //     return Ok(result);
        // }

        // // DELETE: api/product/1
        // [HttpDelete("{id}")]
        // public async Task<IActionResult> Delete(int id)
        //     {
        //         var product =
        //             await _context.Products.FindAsync(id);

        //         if (product == null)
        //         {
        //             return NotFound();
        //         }

        //         _context.Products.Remove(product);

        //         await _context.SaveChangesAsync();

        //         return Ok("Product Deleted Successfully");
        //     }
          }
        }