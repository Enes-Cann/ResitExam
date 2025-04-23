using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [Authorize]
    [HttpGet("secure")]
    public IActionResult SecureArea()
    {
        var username = User.Identity?.Name;
        return Ok($"🎉 Hoş geldin {username}, bu korumalı bir alandır!");
    }

    [AllowAnonymous]
    [HttpGet("public")]
    public IActionResult PublicArea()
    {
        return Ok("🔓 Burası herkesin erişebileceği bir alan.");
    }
}