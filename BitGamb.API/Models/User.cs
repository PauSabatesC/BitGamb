namespace BitGamb.API.Models
{
    public class User
    {
        public int id {get; set;}

        public string username {get; set;}

        public string email {get; set;}

        public byte[] passwordHash {get; set;}

        public byte[] passwordSalt {get; set;}

        public int bits {get; set;}

    }
}