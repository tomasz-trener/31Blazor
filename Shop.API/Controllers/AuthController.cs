using D13P06Shop.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.API.Services.AuthService;
using Shop.Shared.Auth;
using System.Security.Claims;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto userLoginDto)
        {
            var response = await _authService.Login(userLoginDto.Email, userLoginDto.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<string>>> Register(UserRegisterDto userRegisterDto)
        {
            var user = new User()
            {
                Email = userRegisterDto.Email,
                Username = userRegisterDto.UserName
            };

            var response = await _authService.Register(user, userRegisterDto.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
        [HttpPost("changePassword"), Authorize]
        public async Task<ActionResult<ServiceResponse<bool>>> ChangePassword([FromBody] string newPassword)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var response = await _authService.ChangePassword(int.Parse(userId), newPassword);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

    }
}
