using StockFlow.Domain.Contracts;
using StockFlow.Domain.Models;
using StockFlow.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFlow.Infrastructure.Repositories
{
    public class BrandRepository : GenericRepository<Brand> , IBrandRepository
    {
        public BrandRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public async Task UpdateAsync(Brand brand)
        {
            _dbContext.Update(brand);
            await _dbContext.SaveChangesAsync();
        }
    }
}
