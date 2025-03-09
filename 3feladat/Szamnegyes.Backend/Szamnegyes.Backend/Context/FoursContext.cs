using Microsoft.EntityFrameworkCore;

namespace Szamnegyes.Backend.Context
{
    public class FoursContext : DbContext
    {
        public DbSet<SzamnegyesProject.Models.Szamnegyes> _fours { get; set; }

        public FoursContext(DbContextOptions<FoursContext> options) : base(options) 
        {

        }
            
    }
}
