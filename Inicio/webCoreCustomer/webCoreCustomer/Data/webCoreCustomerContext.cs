using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webCoreCustomer.Models;

namespace webCoreCustomer.Data
{
    public class webCoreCustomerContext : DbContext
    {
        public webCoreCustomerContext (DbContextOptions<webCoreCustomerContext> options)
            : base(options)
        {
        }

        public DbSet<webCoreCustomer.Models.Customer> Customer { get; set; } = default!;
    }
}
