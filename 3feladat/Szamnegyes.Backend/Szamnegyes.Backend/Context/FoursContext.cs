using Microsoft.EntityFrameworkCore;
using Szamnegyes.Shared.Models;

namespace Szamnegyes.Backend.Context
{
    public class FoursContext : DbContext
    {
        public DbSet<Fours> Fours { get; set; }

        public FoursContext(DbContextOptions<FoursContext> options) : base(options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
