using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResitExam.DATABASE;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly JwtService _jwtService;

    public AuthController(ApplicationDbContext context, JwtService jwtService)
    {
        _context = context;
        _jwtService = jwtService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginDto login)
    {
        var user = _context.Users.Include(u => u.Role)
            .FirstOrDefault(u => u.Username == login.Username && u.Password == login.Password);

        if (user == null)
            return Unauthorized("Invalid credentials");

        var token = _jwtService.GenerateToken(user.Username, user.Role.Name.ToLower());
        return Ok(new { token });
    }
}