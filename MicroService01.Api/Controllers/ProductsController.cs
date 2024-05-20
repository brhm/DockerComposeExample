using MicroService01.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroService01.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProductsController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Save()
        {
            _context.Products.Add(new Product { Name = "Pen 1" });
            _context.SaveChanges();
            return Ok();
        }
    }
}
