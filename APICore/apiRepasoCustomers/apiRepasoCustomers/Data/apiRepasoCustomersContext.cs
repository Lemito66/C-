using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using apiRepasoCustomers.Models;

namespace apiRepasoCustomers.Data
{
    public class apiRepasoCustomersContext : DbContext
    {
        public apiRepasoCustomersContext (DbContextOptions<apiRepasoCustomersContext> options)
            : base(options)
        {
        }

        public DbSet<apiRepasoCustomers.Models.CustomerEL> CustomerEL { get; set; } = default!;
    }
}
