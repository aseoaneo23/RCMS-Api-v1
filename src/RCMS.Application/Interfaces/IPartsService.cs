using RCMS.Domain.Entities;
using RCMS.DTOs;

namespace RCMS.Interfaces
{
    public interface IPartsService
    {
        Task<PartDto> GetPartByIdAsync(int id);
        Task<PartsListDto> GetAllPartsAsync();
        // Task<PartDto> CreatePartAsync(PartDto partDto);
        // Task<PartDto> UpdatePartAsync(Guid id, PartDto partDto);
        // Task DeletePartAsync(Guid id);
    }
}

