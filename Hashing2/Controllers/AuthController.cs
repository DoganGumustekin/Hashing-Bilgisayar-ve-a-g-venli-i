using Hashing2.DTOs;
using Hashing2.Repos;
using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Hashing2.Models;

namespace Hashing2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private AuthRepo _authRepo;

        public AuthController(AuthRepo authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("Register")]
        public ActionResult RegisterController(UserForRegisterDto userForRegisterDto)
        {
            _authRepo.Register(userForRegisterDto, userForRegisterDto.Password);
            return Ok();
        }

        [HttpPost("Login")]
        public ActionResult LoginController(UserForLoginDto userForLoginDto)
        {
            _authRepo.Login(userForLoginDto, userForLoginDto.Password);
            return Ok();
        }
    }
}
