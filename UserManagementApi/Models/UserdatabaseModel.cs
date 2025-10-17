using System;

namespace UserManagementApi.Models;

public class UserdatabaseModel : CreateStandardUser
{
    public bool Locked { get; set; }
    public DateTime Createddate { get; set; }
    public DateTime Modifieddate { get; set; }
}
