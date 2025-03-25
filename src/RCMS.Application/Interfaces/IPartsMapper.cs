using RCMS.Domain.Entities;
using RCMS.DTOs;

namespace RCMS.Interfaces;

public interface IPartsMapper
{ 
    PartDto ToPartDto (Part part);
    
}