using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiHaberController : Controller
    {
        private StoreDbContext context;

        public ApiHaberController(StoreDbContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IAsyncEnumerable<Product> GetNews()
        {
            return context.Products;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNews(int id)
        {
            Product p = await context.Products.FindAsync(id);
            if (p==null)
            {
                return NotFound();

            }
            return Ok(new
            {
                icerik = p.İcerik,
                category=p.Category,
                ozet=p.Ozet,
                resimyol=p.ResimYol
            });

        }
    }
}
