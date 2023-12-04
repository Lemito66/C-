using Microsoft.EntityFrameworkCore;
using apiFinalVerdadero.Models;

namespace apiFinalVerdadero
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ComentarioEL> ComentarioEL { get; set; }
        protected readonly IConfiguration Configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        
    }
}
