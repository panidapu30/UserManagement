using System;
using UserManagementApi.Models;

namespace UserManagementApi.Interfaces;

public interface IAdminuserRepo
{
    Task<List<UserdatabaseModel>> GetUsersasync();
    Task AddUserasync(CreateStandardUser user);
    Task DeleteUserasync(string email);

}
