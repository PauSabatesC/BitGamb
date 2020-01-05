using System.Collections.Generic;
using System.Threading.Tasks;
using BitGamb.API.Models;
using Microsoft.EntityFrameworkCore;


namespace BitGamb.API.Data
{
    public class RobotRepository : IRobotRepository
    {
        private readonly DataContext _context;

        public RobotRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Robot>> GetRobots()
        {
            var robots = await _context.Robots.ToListAsync();
            return robots;    
        }
    }
}