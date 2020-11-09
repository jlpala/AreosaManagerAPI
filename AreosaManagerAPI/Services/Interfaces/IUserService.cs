using AreosaManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreosaManagerAPI.Services.Interfaces
{
    interface IUserService
    {
        public User GetUserByCredentials(string email, string password);
    }
}
