using Microsoft.EntityFrameworkCore;

namespace WebCoreApp.Data
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {
            
        }
        public DbSet<Models.Products> Products => Set<Models.Products>();
    }
}
