using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BitGamb.API.Data;
using BitGamb.API.DTOs;
using BitGamb.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace BitGamb.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    // /auth
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        private readonly IConfiguration _config;
        public AuthController(IAuthRepository repo, IConfiguration config)
        {
            _repo = repo;
            _config = config;
        }

        [HttpPost("register")]
        // POST auth/register
        public async Task<IActionResult> register(UserForRegisterDTO userForRegisterDto) //ApiController gets username, passwd from Body, and asp receives it as dto
        {
            userForRegisterDto.username = userForRegisterDto.username.ToLower();

            if(!await _repo.UserExists(userForRegisterDto.username))
            {
                var userToCreate = new User
                {
                    username = userForRegisterDto.username
                };

                var createdUser = await _repo.Register(userToCreate, userForRegisterDto.password);

                return StatusCode(201);
            }
            else
            {
                return BadRequest("Username already exists");
            }

        }

        [HttpPost("login")]
        // POST auth/login
        public async Task<IActionResult> login(userForLoginDTO userForLoginDto)
        {
            var userFromRepo = await _repo.Login(userForLoginDto.username.ToLower(), userForLoginDto.password);

            // creation of token identifier
            if (userFromRepo != null)
            {      
                var claims = new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, userFromRepo.id.ToString()),
                    new Claim(ClaimTypes.Name, userFromRepo.username)
                };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(claims),
                    Expires = DateTime.Now.AddDays(1),
                    SigningCredentials = creds
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(tokenDescriptor);
                
                return Ok(new {
                token = tokenHandler.WriteToken(token)
                });
            }
            else
            {
                return Unauthorized();
            }


        }



    }
}