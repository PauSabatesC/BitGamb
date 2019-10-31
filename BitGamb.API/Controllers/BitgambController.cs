using System.Linq;
using System.Threading.Tasks;
using BitGamb.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BitGamb.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class BitgambController : ControllerBase
    {
        private readonly ILogger<BitgambController> _logger;
        private readonly DataContext _context;

        public BitgambController(ILogger<BitgambController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;

        }

        // GET /bitgamb
        [HttpGet]
        public int provaReturn()
        {
            return 3;
        }

        // GET /bitgamb/robots 
        [HttpGet("robots")]
        public async Task<IActionResult> GetRobots()
        {
            var robots = await _context.Robots.ToListAsync();

            return Ok(robots);
        }

        [AllowAnonymous]
        // GET /bitgamb/robots/{id}
        [HttpGet("robots/{id}")]
        public async Task<IActionResult> GetRobots(int id)
        {
            var robot = await _context.Robots.FirstOrDefaultAsync(x => x.id == id);

            return Ok(robot);
        }


    }
}
