using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Data
{
    public class DinnerDbContext : DbContext
    {
        public DinnerDbContext(DbContextOptions<DinnerDbContext> options) : base(options) { }

        public virtual DbSet<Dinner> Dinners { get; set; }

      
    }
}
