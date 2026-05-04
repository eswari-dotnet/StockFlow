using StockFlow.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFlow.Domain.Contracts
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task UpdateAsync(Category category);
    }
}
