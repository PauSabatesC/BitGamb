using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BitGamb.API.Data;
using BitGamb.API.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BitGamb.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    // /robot
    public class RobotController : ControllerBase
    {
        private readonly IRobotRepository _robotRepository;
        private readonly IMapper _mapper;
        public RobotController(IRobotRepository robotRepository, IMapper mapper)
        {
            _mapper = mapper;
            _robotRepository = robotRepository;

        }

        [HttpGet("list")]
        //GET /robot/list
        public async Task<IActionResult> GetAllRobots()
        {
            var robots = await _robotRepository.GetRobots();    

            if (robots != null)
            {
                var robotToReturn = _mapper.Map<IEnumerable<RobotsDTO>>(robots);
                return Ok(robotToReturn);
            }
            else
            {
                return BadRequest("Cannot retrieve robots list");
            }

        }

    }
}