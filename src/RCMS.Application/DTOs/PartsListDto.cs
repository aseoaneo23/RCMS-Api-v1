
namespace RCMS.DTOs;

public class PartsListDto
{
    public int ItemsCount { get; set; }
    public List<PartDto> Parts { get; set; }
    
    public PartsListDto(List<PartDto> parts)
    {
        ItemsCount = parts?.Count ?? 0;
        Parts = parts;
    }
    
}