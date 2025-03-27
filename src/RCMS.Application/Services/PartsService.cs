using RCMS.Domain.Entities;
using RCMS.DTOs;
using RCMS.Exceptions;
using RCMS.Infrastructure.Interfaces;
using RCMS.Interfaces;
using RCMS.Mappers;
using RCMS.Utils;

namespace RCMS.Application.Services;

public class PartsService : IPartsService
{
    private readonly IPartsRepository _partsRepository;
    private readonly IPartsMapper _mapper;
    private readonly Sanitizer _sanitizer;

    public PartsService(IPartsRepository partsRepository, PartsMapper mapper, Sanitizer sanitizer)
    {
        _partsRepository = partsRepository;
        _mapper = mapper;
        _sanitizer = sanitizer;
    }

    public async Task<PartsListDto> GetAllPartsAsync()
    {
       var partEntities = await _partsRepository.GetAllPartsAsync();
       var partsList = partEntities.Select<Part , PartDto>( part => _mapper.ToPartDto(part)).ToList();
       var parts = new PartsListDto(partsList);
       
       return parts.Parts.Count == 0 ? throw new NotFoundException("No parts were found! Try to create one") 
           : parts;
    }

    public async Task<PartDto> GetPartByIdAsync(int partId)
    { 
        var part = await _partsRepository.GetPartByIdAsync(partId);
        return part == null ? throw new NotFoundException($"Part with ID {partId} not found")
            : _mapper.ToPartDto(part);
    }

    public async Task<PartDto> CreatePartAsync(PartDto partDto)
    {
        var partOnDb = await _partsRepository.GetPartByNameAsync(_sanitizer.SanitizeInput(partDto.Name));
        
        if (partOnDb != null)
        {
            throw new DuplicatedItemException($"Part with ID {partDto.Id} already exists");
        }
        
        var part = _mapper.ToPartEntity(partDto);
        var addedPart = await _partsRepository.AddPartAsync(part);
        return _mapper.ToPartDto(addedPart.Entity);
    }
    // public async Task<PartDto> UpdatePartAsync(Guid id, PartDto partDto){}
    // public async Task DeletePartAsync(Guid id){}    
}
    


