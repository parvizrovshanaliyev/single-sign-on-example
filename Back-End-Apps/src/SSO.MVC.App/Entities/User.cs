namespace SSO.MVC.App.Entities;

public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? Username { get; set; }
    public string? PasswordHash { get; set; }
    
    // add audit fields
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}