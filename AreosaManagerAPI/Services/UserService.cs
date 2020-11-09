using AreosaManagerAPI.Models;
using AreosaManagerAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreosaManagerAPI.Services
{
    public class UserService : IUserService
    {
        public User GetUserByCredentials(string email, string password)
        {
            User user = new User() { Id = 1, Email = "email@domain.com", Password = "password", Name = "Ole Petter Dahlmann" };
            if (user != null)
            {
                user.Password = string.Empty;
            }
            return user;
        }
    }
}
