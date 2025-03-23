using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RCMS.Domain.Entities;
using RCMS.DTOs;
using RCMS.Infrastructure.Persistance;

namespace RCMS.WebApi.Controllers
{
    //localhost:5186/api/parts
    [ApiController]
    [Route("api/[controller]")]
    public class PartsController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public PartsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("getAllParts")]
        [HttpGet]
        public IActionResult GetAllParts()
        {
            var allParts = _dbContext.Parts.ToList();
            return Ok(allParts);
        }

        [Route("addParts")]
        [HttpPost]
        public IActionResult AddParts(Part partDto)
        {
            var partEntity = new Part()
            {
                Name = partDto.Name,
                Price = partDto.Price,
                Stock = partDto.Stock
            };
            _dbContext.Parts.Add(partEntity);
            _dbContext.SaveChanges();

            string result = JsonConvert.SerializeObject(partEntity, Formatting.Indented);
            return Ok($"The part\n {result}\n has been added");
        }
    }
}  