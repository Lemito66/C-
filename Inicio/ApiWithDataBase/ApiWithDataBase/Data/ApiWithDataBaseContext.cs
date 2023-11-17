using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiWithDataBase.Models;

namespace ApiWithDataBase.Data
{
    public class ApiWithDataBaseContext : DbContext
    {
        public ApiWithDataBaseContext (DbContextOptions<ApiWithDataBaseContext> options)
            : base(options)
        {
        }

        public DbSet<ApiWithDataBase.Models.Student> Student { get; set; } = default!;
    }
}
