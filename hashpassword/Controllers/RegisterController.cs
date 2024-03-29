//using CoreApiResponse;
//using hashpassword.Data;
//using hashpassword.Models;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System.Net;

//namespace hashpassword.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class RegisterController : BaseController
//    {
//        private readonly IRegisterDataAccess _registerDataAccess;

//        public RegisterController(IRegisterDataAccess registerDataAccess)
//        {
//            _registerDataAccess = registerDataAccess;
//        }


//        [HttpPost]
//        public IActionResult createuser(User user)
//        {
//            _registerDataAccess.createuser(user);
//            return CustomResult("User Created", HttpStatusCode.OK);
//        }
//    }
//}
