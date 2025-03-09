using Microsoft.EntityFrameworkCore;
using Szamnegyes.Backend.Context;
using SzamnegyesProject.Models;

namespace Szamnegyes.Backend.Repos
{
    public class FoursRepo
    {
        private readonly List<SzamnegyesProject.Models.Szamnegyes> _fours = new List<SzamnegyesProject.Models.Szamnegyes>();

        private readonly DbContext _dbContext;
        private readonly DbSet<SzamnegyesProject.Models.Szamnegyes> _dbSet;

        public FoursRepo(FoursContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext?.Set<SzamnegyesProject.Models.Szamnegyes>();
        }

        public Task<List<SzamnegyesProject.Models.Szamnegyes>> GetAllAsync()
        {
            return _dbSet.ToListAsync();
        }
    }
}
