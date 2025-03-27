using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RCMS.Domain.Entities;
using RCMS.Infrastructure.Interfaces;
using RCMS.Infrastructure.Persistance;

namespace RCMS.Infrastructure.Repositories;

public class PartsRepository : IPartsRepository
{
    private readonly AppDbContext _dbContext;

    public PartsRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Part>> GetAllPartsAsync()
    { 
        return await _dbContext.Parts.ToListAsync();
    }

    public async Task<Part?> GetPartByIdAsync(int partId)
    {
        return await _dbContext.Parts.FindAsync(partId);
    }
    
    public async Task<Part?> GetPartByNameAsync(string partName)
    {
        return await _dbContext.Parts.FirstOrDefaultAsync(p => p.Name == partName);
    }

    public async Task<EntityEntry<Part>> AddPartAsync(Part part)
    {
        return await _dbContext.Parts.AddAsync(part);
    }
}