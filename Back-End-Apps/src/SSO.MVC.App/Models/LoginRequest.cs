﻿namespace SSO.MVC.App.Models;

public class LoginRequest
{
    public string? Username { get; set; }
    public string? Password { get; set; }
    public bool RememberLogin { get; set; }
}