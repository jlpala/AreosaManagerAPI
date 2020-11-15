using AreosaManagerAPI.DAL.Interfaces;
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
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository repository)
        {
            _userRepository = repository;
        }

        public async Task<User> GetUserByCredentials(string email, string password)
        {
            return await _userRepository.GetUserByCredentialsAsync(email, password);
        }
    }
}
