using Microsoft.AspNetCore.Mvc;
using Szamnegyes.Backend.Repos;
using Szamnegyes.Shared.Converters;
using Szamnegyes.Shared.Models;

namespace Szamnegyes.Backend.Controllers
{
    [Route("fours")]
    [ApiController]
    public class FoursController : ControllerBase
    {
        private readonly FoursRepo _foursRepo;
        public FoursController(FoursRepo foursRepo)
        {
            _foursRepo = foursRepo;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAllAsync()
        {
            List<Fours>  all = await _foursRepo.GetAllAsync();
            return Ok(all);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            Fours negyes = await _foursRepo.GetByIdAsync(id);
            return Ok(negyes);
        }

        [HttpPost()]
        public async Task<IActionResult> AddFours([FromBody] FoursDto dto)
        {
            try
            {
                Fours fours = dto.ToModel();
                await _foursRepo.CreateAsync(fours);
                return StatusCode(201);

            }
            catch(Exception ex)
            {
                return StatusCode(400,ex.Message);
            }

        }
    }
}
