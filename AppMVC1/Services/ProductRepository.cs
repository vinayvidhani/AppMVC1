using AppMVC1.Models;
using Microsoft.EntityFrameworkCore;

namespace AppMVC1.Services
{
    public class ProductRepository : IProductReporsitory
    {
        private readonly AppDbContext dbContext;

        public ProductRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await dbContext.Products.ToListAsync();
        }
    }
}
