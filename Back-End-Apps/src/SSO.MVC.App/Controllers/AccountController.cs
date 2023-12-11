using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SSO.MVC.App.Entities;
using SSO.MVC.App.Models;

namespace SSO.MVC.App.Controllers;

public class AccountController : Controller
{
    private readonly IConfiguration _configuration;
    private readonly IJwtService _jwtService;
    
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        if (IsValidUserAsync(request, out var user))
        {
            var token = _jwtService.GenerateJwtToken(user.Username);
            var refreshToken = _jwtService.GenerateRefreshToken();
            
            return Ok(new LoginResponse()
            {
                Token = token,
                RefreshToken = refreshToken
            });
        }

        return Unauthorized("Invalid credentials");
    }
    
    private bool IsValidUserAsync(LoginRequest request, out User user)
    {
        user = new User(); // get user from db
        
        return true;
    }
    
    public IActionResult Logout()
    {
        return SignOut("Cookies", "oidc");
    }
    
}