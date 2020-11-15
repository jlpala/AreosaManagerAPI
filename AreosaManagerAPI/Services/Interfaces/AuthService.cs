using AreosaManagerAPI.Controllers;
using AreosaManagerAPI.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreosaManagerAPI.Services.Interfaces
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository repository)
        {
            _userRepository = repository;
        }
        public async Task<bool> IsValidCredentials(string email, string password)
        {
            return await _userRepository.UserExists(email, password);
        }
    }
}
