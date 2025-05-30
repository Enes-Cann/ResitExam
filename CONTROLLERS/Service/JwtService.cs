using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;


public class JwtService
{
    private readonly IConfiguration _config;

    public JwtService(IConfiguration config)
    {
        _config = config;
    }

   public string GenerateToken(int userId, string fullName, string role)
{
    var jwtKey = _config["Jwt:Key"];
    if (string.IsNullOrEmpty(jwtKey))
        throw new Exception("JWT Key is not configured!");

    var claims = new[]
    {
         new Claim(ClaimTypes.NameIdentifier, userId.ToString()), 
        new Claim(ClaimTypes.Name, fullName), // artık isim geliyor
        new Claim(ClaimTypes.Role, role.ToLower())
    };

    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

    var token = new JwtSecurityToken(
        issuer: _config["Jwt:Issuer"],
        audience: _config["Jwt:Audience"],
        claims: claims,
        expires: DateTime.Now.AddMinutes(Convert.ToDouble(_config["Jwt:ExpireMinutes"])),
        signingCredentials: creds);

    return new JwtSecurityTokenHandler().WriteToken(token);
}

}