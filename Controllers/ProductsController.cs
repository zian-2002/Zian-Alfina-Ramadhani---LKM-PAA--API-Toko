using Microsoft.AspNetCore.Mvc;
using TugasTM1.Data;
using TugasTM1.Models;

namespace TugasTM1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new { status = "success", data = _context.Products.ToList() });
        }

        [HttpPost]
        public IActionResult Create([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest(new
                {
                    status = "error",
                    message = "Data kosong"
                });
            }

            product.CreatedAt = DateTime.UtcNow;
            product.UpdatedAt = DateTime.UtcNow;

            _context.Products.Add(product);
            _context.SaveChanges();

            return StatusCode(201, new
            {
                status = "success",
                data = product
            });
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Product product)
        {
            var data = _context.Products.Find(id);

            if (data == null)
            {
                return NotFound(new
                {
                    status = "error",
                    message = "Produk tidak ditemukan"
                });
            }

            data.Name = product.Name;
            data.Price = product.Price;
            data.UpdatedAt = DateTime.UtcNow;

            _context.SaveChanges();

            return Ok(new
            {
                status = "success",
                data = data
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var data = _context.Products.Find(id);
            if (data == null)
                return NotFound(new { status = "error", message = "Not found" });

            _context.Products.Remove(data);
            _context.SaveChanges();

            return Ok(new { status = "success", message = "Deleted" });
        }
    }
}