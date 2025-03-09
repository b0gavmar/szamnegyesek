using Microsoft.EntityFrameworkCore;
using Szamnegyes.Backend.Context;
using Szamnegyes.Shared.Models;

namespace Szamnegyes.Backend.Repos
{
    public class FoursRepo
    {

        private readonly FoursContext _dbContext;
        private readonly DbSet<Fours> _dbSet;

        public FoursRepo(FoursContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Fours;
        }

        public Task<List<Fours>> GetAllAsync()
        {
            return _dbSet.ToListAsync();
        }
    }
}
