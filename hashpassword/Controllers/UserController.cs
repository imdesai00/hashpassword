//using CoreApiResponse;
//using hashpassword.Data;
//using hashpassword.Models;
//using hashpassword.Services;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System.Net;

//namespace hashpassword.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class UserController : BaseController
//    {
//        private readonly IJwtService _jwtService;
//        private readonly IUserRepository _userRepository;

//        public UserController(IUserRepository userRepository, IJwtService jwtService)
//        {
//            _userRepository = userRepository;
//            _jwtService = jwtService;
//        }

//        //[HttpGet]
//        //public IActionResult GetUsers()
//        //{
//        //    var user = _userDataAccess.GetUsers();
//        //    return CustomResult("Data Fetched", user, HttpStatusCode.OK);

//        //}
  
//        [HttpPost("login")]
//        public IActionResult GetUserbyusernameandpassword(UserLoginModel model)
//        {
//            if (_userRepository.ValidateCredentials(model.Username, model.Password))
//            {
//                var token = _jwtService.GenerateToken(model.Username);
//                var refoken = _jwtService.GenerateReferenceToken(token);
//                //var gettoken = _jwtService.GetJwtToken(refoken);
//                return Ok(new { Token = token, RefToken = refoken });
//            }

//            return Unauthorized();

//        }
//    }
//}
