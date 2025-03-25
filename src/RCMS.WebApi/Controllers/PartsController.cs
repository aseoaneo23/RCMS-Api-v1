using Microsoft.AspNetCore.Mvc;
using RCMS.Application.Services;
using RCMS.Exceptions;
using RCMS.Interfaces;

namespace RCMS.WebApi.Controllers
{
    //localhost:5067/api/parts
    [ApiController]
    [Route("api/[controller]")]
    public class PartsController : ControllerBase
    {
        private readonly IPartsService _partsService;

        public PartsController(IPartsService partsService)
        {
            _partsService = partsService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllParts()
        {
            try
            {
                var allParts = await _partsService.GetAllPartsAsync();
                return Ok(allParts);
            }
            catch (NotFoundException nfe)
            {
                return NotFound(nfe.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An unexpected error occured. Exception: {ex.Message}");
            }
        }

        [Route("{partId}")]
        [HttpGet]
        public async Task<IActionResult> GetPartById(int partId)
        {
            try
            {
                var part = await _partsService.GetPartByIdAsync(partId);
                return Ok(part);
            }
            catch (NotFoundException nfe)
            {
                return NotFound(nfe.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An unexpected error occured. Exception: {ex.Message}");

            }
        }

        // [Route("addParts")]
        // [HttpPost]
        // public IActionResult AddParts(Part partDto)
        // {
        //     var partEntity = new Part()
        //     {
        //         Name = partDto.Name,
        //         Price = partDto.Price,
        //         Stock = partDto.Stock
        //     };
        //     _dbContext.Parts.Add(partEntity);
        //     _dbContext.SaveChanges();
        //
        //     string result = JsonConvert.SerializeObject(partEntity, Formatting.Indented);
        //     return Ok($"The part\n {result}\n has been added");
        // }
    }
}  