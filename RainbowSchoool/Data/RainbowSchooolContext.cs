using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RainbowSchoool.Models;

namespace RainbowSchoool.Data
{
    public class RainbowSchooolContext : DbContext
    {
        public RainbowSchooolContext (DbContextOptions<RainbowSchooolContext> options)
            : base(options)
        {
        }

        public DbSet<RainbowSchoool.Models.Student> Student { get; set; } = default!;

        public DbSet<RainbowSchoool.Models.Teacher>? Teacher { get; set; }
    }
}
