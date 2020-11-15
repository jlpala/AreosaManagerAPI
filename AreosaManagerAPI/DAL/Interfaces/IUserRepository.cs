using AreosaManagerAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AreosaManagerAPI.DAL.Interfaces
{
    public interface IUserRepository { 
        public Task<User> GetUserByCredentialsAsync(string email, string password);
        public Task<bool> UserExists(string email, string password);
        //public Task<List<string>> GetRolesAsync(string email, string password);
    }
}