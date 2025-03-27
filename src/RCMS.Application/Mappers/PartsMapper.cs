using RCMS.Domain.Entities;
using RCMS.DTOs;
using RCMS.Interfaces;

namespace RCMS.Mappers;

public class PartsMapper : IPartsMapper
{
    public PartDto ToPartDto (Part part)
    {
        ArgumentNullException.ThrowIfNull(part);
        
        return new PartDto
        {
            Id = part.Id,
            Name = part.Name,
            Description = part.Description,
            Price = part.Price,
            Stock = part.Stock,
            CategoryId = part.CategoryId,
            SupplierId = part.SupplierId
        };
    }
    
    public Part ToPartEntity(PartDto partDto)
    {
        ArgumentNullException.ThrowIfNull(partDto);
        
        return new Part
        {
            Name = partDto.Name,
            Description = partDto.Description,
            Price = partDto.Price,
            Stock = partDto.Stock,
            CategoryId = partDto.CategoryId,
            SupplierId = partDto.SupplierId
        };
    }
}