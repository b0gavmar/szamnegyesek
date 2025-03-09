using Microsoft.EntityFrameworkCore;
using Szamnegyes.Shared.Models;

namespace Szamnegyes.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Fours> fours = new List<Fours>
            {
                new Fours{
                    A = 1, B = 2, C = 3, D = 4,
                    Id = 1234
                }
            };

            modelBuilder.Entity<Fours>().HasData(fours);
        }
    }
}
