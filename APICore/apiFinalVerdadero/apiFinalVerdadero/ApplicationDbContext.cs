using Microsoft.EntityFrameworkCore;

namespace apiFinalVerdadero
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<apiFinalVerdadero.Models.CustomerEL2> CustomerEL2 { get; set; }
    }
}
