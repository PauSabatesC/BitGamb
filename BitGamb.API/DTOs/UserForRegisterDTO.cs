using System.ComponentModel.DataAnnotations;

namespace BitGamb.API.DTOs
{
    public class UserForRegisterDTO
    {
        [Required]
        public string username {get; set;}

        [Required]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Your password has to be at least 4 characters.")]
        public string password {get; set;}
    }
}