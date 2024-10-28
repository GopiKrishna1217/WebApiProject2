using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Unicode;

namespace WebApiProject.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class AuthController : ControllerBase
    //{
    //    private readonly IConfiguration _configuration;
    //    private readonly UserManager<User> _userManager;
    //    public AuthController(IConfiguration configuration, UserManager<User> userManager)
    //    {
    //        _configuration = configuration;
    //        _userManager = userManager;
    //    }
    //    [HttpPost("Login")]
    //    public async Task<IActionResult> Login(LoginModel loginModel)
    //    {
    //        var user = await _userManager.FindByEmailAsync(loginModel.UserEmail);
    //        if(user!=null && await _userManager.CheckPasswordAsync(user, loginModel.Password))
    //        {
    //            var token=GenerateJwtToken(user);
    //            return Ok(new {token});
    //        }
    //        return Unauthorized();

    //    }

    //    public string GenerateJwtToken(User userDetails) {
    //        var claims = new[]
    //        {
    //             new Claim(JwtRegisteredClaimNames.Sub,userDetails.Email) ,
    //             new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()) ,

    //         };
    //        var key =new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
    //            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
    //        var token = new JwtSecurityToken(
    //            issuer: _configuration["Jwt:Issuer"],
    //            audience: _configuration["Jwt:JBDCBHDJCJDHCBSDJCJSDC"],
    //            claims: claims,
    //            expires: DateTime.Now.AddMinutes(60),
    //            signingCredentials: creds
    //            );
    //        return new JwtSecurityTokenHandler().WriteToken(token);
    //    }
    //}
}
