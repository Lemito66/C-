using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepasoWebCore.Controllers;

namespace RepasoWebCore.Data
{
    public class RepasoWebCoreContext : DbContext
    {
        public RepasoWebCoreContext (DbContextOptions<RepasoWebCoreContext> options)
            : base(options)
        {
        }

        public DbSet<RepasoWebCore.Controllers.Customer> Customer { get; set; } = default!;
    }
}
