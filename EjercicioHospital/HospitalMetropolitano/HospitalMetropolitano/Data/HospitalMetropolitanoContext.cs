using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HospitalMetropolitano.Models;

namespace HospitalMetropolitano.Data
{
    public class HospitalMetropolitanoContext : DbContext
    {
        public HospitalMetropolitanoContext (DbContextOptions<HospitalMetropolitanoContext> options)
            : base(options)
        {
        }

        public DbSet<HospitalMetropolitano.Models.Customer> Customer { get; set; } = default!;
    }
}
