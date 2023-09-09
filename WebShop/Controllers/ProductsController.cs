using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebShop.Data;
using WebShop.Data.Model;

namespace WebShop.API.Controllers
{
    
    public class ProductsController : BaseApiController
    {
        private readonly ApplicationDbContext context;
        public ProductsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return await context.Products.ToListAsync();

             
        }

        [HttpGet("{id}")] // api/products/ 3
        public async Task<ActionResult<Product>> GetProduct(int id) 
        {
            var product = await context.Products.FindAsync(id);

            if (product == null) return NotFound();

            return product;
        }
    }
}
