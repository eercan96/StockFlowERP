using Microsoft.AspNetCore.Mvc;

namespace StockFlowERP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // Gerçek projede DB'den hash kontrolü yapılmalı
            if (request.Username == "admin" && request.Password == "admin")
            {
                var token = "fake-jwt-token"; // JWT üretimi eklenecek
                return Ok(new { Token = token });
            }
            return Unauthorized();
        }

        public class LoginRequest
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
} 