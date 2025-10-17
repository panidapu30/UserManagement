using System;
using UserManagementApi.Interfaces;
using UserManagementApi.Models;

namespace UserManagementApi.Respositories;

public class AdminuserRepo(IConfiguration config) : IAdminuserRepo
{
    private readonly IConfiguration _config = config;
    public Task AddUserasync(CreateStandardUser user)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUserasync(string email)
    {
        throw new NotImplementedException();
    }

    public Task<List<UserdatabaseModel>> GetUsersasync()
    {
        var connectionString = _config.GetConnectionString("DefaultConnection");
        var books = new List<UserdatabaseModel>();

        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            var command = new SqlCommand("SELECT Id, Title, Author, Price FROM Books", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                books.Add(new Book
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Author = reader.GetString(2),
                    Price = reader.GetDecimal(3)
                });
            }
        }
    }
}
