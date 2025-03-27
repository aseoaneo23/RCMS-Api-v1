using RCMS.Domain.Entities;
using RCMS.Infrastructure.Interfaces;
using RCMS.Infrastructure.Persistance;

namespace RCMS.Infrastructure.Repositories;

public class CategoryRepository : ICategoriesRepository
{
    private readonly AppDbContext _dbContext;

    public CategoryRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Category> GetCategoryByIdAsync(int id)
    {
        return await _dbContext.Category.FindAsync(id);
    }
}