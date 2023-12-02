using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using apiRepasoVerdadera.Models;

namespace apiRepasoVerdadera.Data
{
    public class apiRepasoVerdaderaContext : DbContext
    {
        public apiRepasoVerdaderaContext (DbContextOptions<apiRepasoVerdaderaContext> options)
            : base(options)
        {
        }

        public DbSet<apiRepasoVerdadera.Models.CustomerEL2> CustomerEL2 { get; set; } = default!;
    }
}
