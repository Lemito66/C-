using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webAppDemo33.Models;

namespace webAppDemo33.Data
{
    public class webAppDemo33Context : DbContext
    {
        public webAppDemo33Context (DbContextOptions<webAppDemo33Context> options)
            : base(options)
        {
        }

        public DbSet<webAppDemo33.Models.Productos> Productos { get; set; } = default!;
    }
}
