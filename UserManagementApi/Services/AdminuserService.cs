using System;
using UserManagementApi.Interfaces;
using UserManagementApi.Models;

namespace UserManagementApi.Services;

public class AdminuserService : IAdminuserService
{
    public Task<string> AddnewUserasync(CreateStandardUser user)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUserasync(string Email)
    {
        throw new NotImplementedException();
    }

    public Task<CreateStandardUser> GetUsersasync()
    {
        throw new NotImplementedException();
    }

    public Task<CreateStandardUser> GetUsersAsync(string email)
    {
        throw new NotImplementedException();
    }
}
