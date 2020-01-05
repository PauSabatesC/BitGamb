namespace BitGamb.API.Models
{
    public class RaceRegistries
    {
        public int id {get; set;}
        public User User {get; set;}
        public RobotRace RobotRace {get; set;}
        public Robot Robot {get; set;}
    }
}