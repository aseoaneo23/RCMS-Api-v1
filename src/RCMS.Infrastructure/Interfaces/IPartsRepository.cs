using Microsoft.EntityFrameworkCore.ChangeTracking;
using RCMS.Domain.Entities;

namespace RCMS.Infrastructure.Interfaces;

public interface IPartsRepository
{
    Task<Part?> GetPartByIdAsync(int id);
    
    Task<Part?> GetPartByNameAsync(string partName);

    Task<IEnumerable<Part>> GetAllPartsAsync();
    Task<EntityEntry<Part>> AddPartAsync(Part part);
    
    // Task UpdatePartAsync(Part part);
    // Task DeletePartAsync(int id);
}