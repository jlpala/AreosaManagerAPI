using AreosaManagerAPI.Models;

namespace AreosaManagerAPI.DAL.Interfaces
{
    public interface IUserRepository { 
        public User GetUserByCredentials(string email, string password);
    }
}