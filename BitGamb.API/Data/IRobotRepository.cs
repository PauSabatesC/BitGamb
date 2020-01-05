using System.Threading.Tasks;
using System.Collections.Generic;
using BitGamb.API.Models;

namespace BitGamb.API.Data
{
    public interface IRobotRepository
    {
        Task<List<Robot>> GetRobots();
        
    }
}