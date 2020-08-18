using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BanksoftHW.Models
{
    public class BanksoftHWDbContext : IdentityDbContext
    {
        public BanksoftHWDbContext (DbContextOptions<BanksoftHWDbContext> options)
            : base(options)
        {
        }

        public DbSet<BanksoftHW.Models.Movie> Movie { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
