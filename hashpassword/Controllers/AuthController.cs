using hashpassword.Models;
using hashpassword.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using hashpassword.DataAccess;

namespace hashpassword.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthDataAcsess _authDataAcsess;
        private readonly HashService _hashService;

        public AuthController(AuthDataAcsess authDataAcsess, HashService hashService)
        {
            _authDataAcsess = authDataAcsess;
            _hashService = hashService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(User user)
        {
            HashPasswordmodel hashedPassword = _hashService.HashPass(user.Password);
            var users = new User
            {
                Id = user.Id,
                UserName = user.UserName,
                PhoneNo = user.PhoneNo,
                Email = user.Email,
                Password = hashedPassword.hash,
                Salt = hashedPassword.salt
            };
            var result = _authDataAcsess.registeruser(users);
            if (result)
            {
                return Ok("Registration successful");
            }
            else 
            {
                return BadRequest("registration faild");
            }  
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginModel user)
        {
            var users = await _authDataAcsess.FindEmailAsync(user.Email);
            if (users == null)
            {
                return BadRequest("Invalid email or password");
            }

            string hashedPassword = _hashService.HashPassverifyer(user.Password, users.Salt);
            if (users.Password != hashedPassword)
            {
                return BadRequest("Password did not match");
            }

            // Password is correct, proceed with login logic
            return Ok("Login successful");
        }
    }
}
