using System;
using UserManagementApi.Models;

namespace UserManagementApi.Interfaces;

public interface IAdminuserService
{
    Task<string> AddnewUserasync(CreateStandardUser user);
    Task DeleteUserasync(string Email);
    Task<CreateStandardUser> GetUsersasync();
    Task<CreateStandardUser> GetUsersAsync(string email);
}
