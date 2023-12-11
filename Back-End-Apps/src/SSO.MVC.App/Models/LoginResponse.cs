namespace SSO.MVC.App.Models;

public class LoginResponse
{
    public string? Token { get; set; }
    public string? RefreshToken { get; set; }
}