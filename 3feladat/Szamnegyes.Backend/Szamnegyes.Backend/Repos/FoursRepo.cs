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

        public async Task<List<Fours>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<Fours> GetByIdAsync(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task CreateAsync(Fours fours)
        {
            try
            {
                _dbSet.Add(fours);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
