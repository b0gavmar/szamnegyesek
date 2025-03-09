using Microsoft.AspNetCore.Mvc;
using Szamnegyes.Backend.Repos;
using SzamnegyesProject.Models;

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
            List<SzamnegyesProject.Models.Szamnegyes> all = new List<SzamnegyesProject.Models.Szamnegyes>();

            all = await _foursRepo.GetAllAsync();
            return Ok(all);
        }
    }
}
