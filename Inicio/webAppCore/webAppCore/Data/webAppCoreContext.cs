using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webAppCore.Models;

namespace webAppCore.Data
{
    public class webAppCoreContext : DbContext
    {
        public webAppCoreContext (DbContextOptions<webAppCoreContext> options)
            : base(options)
        {
        }

        public DbSet<webAppCore.Models.Product> Product { get; set; } = default!;
    }
}
