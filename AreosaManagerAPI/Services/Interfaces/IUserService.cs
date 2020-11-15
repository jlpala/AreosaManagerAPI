using AreosaManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreosaManagerAPI.Services.Interfaces
{
    public interface IUserService
    {
        public Task<User> GetUserByCredentials(string email, string password);
    }
}
