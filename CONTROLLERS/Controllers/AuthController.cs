using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResitExam.DATABASE;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

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
    var user = _context.Users
        .Include(u => u.Role)
        .Include(u => u.Student)
        .Include(u => u.Instructor)
        .Include(u => u.Secretary)
        .FirstOrDefault(u => u.Username == login.Username && u.Password == login.Password);

    if (user == null)
        return Unauthorized("Invalid credentials");

    if ((user.RoleId == 1 && login.Role.ToLower() != "student") ||
        (user.RoleId == 2 && login.Role.ToLower() != "instructor") ||
        (user.RoleId == 3 && login.Role.ToLower() != "facultysecretary"))
    {
        return BadRequest("You are trying to login with the wrong role.");
    }

    // Öğrenciyse adını al, değilse kullanıcı adı
    string fullName =
        user.Student?.Name ??
        user.Instructor?.Name ??
        user.Secretary?.Name ??
        user.Username;

    // Normalize role
    string tokenRole = user.Role.Name.ToLower().Replace(" ", "");

    // ✅ TOKEN ID LOGIC – doğru ID'yi ata
    int tokenId = tokenRole switch
    {
        "student" => user.Student?.Id ?? 0,
        "instructor" => user.Instructor?.Id ?? 0,
        "facultysecretary" => user.Secretary?.Id ?? 0,
        _ => user.Id
    };

    // 🪵 Loglarla doğrula
    Console.WriteLine($"[DEBUG] TOKEN’A YAZILAN ROLE: {tokenRole}");
    Console.WriteLine($"[DEBUG] Student?.Id: {user.Student?.Id}");
    Console.WriteLine($"[DEBUG] Instructor?.Id: {user.Instructor?.Id}");
    Console.WriteLine($"[DEBUG] Secretary?.Id: {user.Secretary?.Id}");
    Console.WriteLine($"[DEBUG] Seçilen tokenId: {tokenId}");

    var token = _jwtService.GenerateToken(tokenId, fullName, tokenRole);
    return Ok(new { token });
}


    
    [Authorize]
    [HttpGet("GetUserInfo")]
    public IActionResult GetUserInfo()
    {
        var identity = HttpContext.User.Identity as ClaimsIdentity;
        if (identity == null)
            return Unauthorized();

        var username = identity.FindFirst(ClaimTypes.Name)?.Value;
        var role = identity.FindFirst(ClaimTypes.Role)?.Value;

        return Ok(new
        {
            username,
            role
        });
    }
}
