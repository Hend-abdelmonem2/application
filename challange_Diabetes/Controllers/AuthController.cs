using challenge_Diabetes.DTO;
using challenge_Diabetes.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace challenge_Diabetes.Controllers
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
        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromForm] RegisterModelDTO model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.RegisterAsync(model);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);

            return Ok(result);
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromForm] TokenRequestModelDTO model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.Login(model);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);

            return Ok(result);
        }

        [HttpPost("Test")]
            public async Task<IActionResult> Tset()
            {
                var userid = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;

                return Ok(userid);
            }



            [HttpPost("addrole")]
            public async Task<IActionResult> AddRoleAsync([FromForm] AddRoleModelDTO model)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var result = await _authService.AddRoleAsync(model);

                if (!string.IsNullOrEmpty(result))
                    return BadRequest(result);

                return Ok(model);
            }
            
        }
    }

