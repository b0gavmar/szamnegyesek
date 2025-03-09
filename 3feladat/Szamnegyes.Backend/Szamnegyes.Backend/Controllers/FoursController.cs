using Microsoft.AspNetCore.Mvc;
using Szamnegyes.Backend.Repos;
using Szamnegyes.Shared.Models;

namespace Szamnegyes.Backend.Controllers
{
    [Route("api/fours")]
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
    }
}
