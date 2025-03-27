using RCMS.Domain.Entities;

namespace RCMS.Infrastructure.Interfaces;

public interface ICategoriesRepository
{
    Task<Category> GetCategoryByIdAsync(int id);
}