using RCMS.Domain.Entities;

namespace RCMS.Infrastructure.Interfaces;

public interface IPartsRepository
{
    Task<Part?> GetPartByIdAsync(int id);
    Task<IEnumerable<Part>> GetAllPartsAsync();
    // Task AddPartAsync(Part part);
    // Task UpdatePartAsync(Part part);
    // Task DeletePartAsync(int id);
}