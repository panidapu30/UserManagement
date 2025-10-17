using System;

namespace UserManagementApi.Models;

public class CreateStandardUser : Standarduser
{
    public string Password { get; set; }
    public bool IsAdmin { get; set; }
}
