using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AreosaManagerAPI.Models;
using AreosaManagerAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AreosaManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        private readonly IAuthService _authService;

        public AuthController(IUserService service)
        {
            _userService = service;
        }

        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> Login(string email, string password)
        //{
        //    if(await _authService.IsValidCredentials(email, password))
        //    {
        //        Task<User> user = _userService.GetUserByCredentials(email, password);
        //        //Task<List<string>> roles = _userService.GetRolesAsync
        //    }

        //}


    }
}
