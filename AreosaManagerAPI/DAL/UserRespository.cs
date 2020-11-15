using AreosaManagerAPI.DAL.Interfaces;
using AreosaManagerAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Summary description for Class1
/// </summary>
public class UserRespository : IUserRepository
{
    private readonly AreosaManagerDBContext _dBContext;
	public UserRespository()
	{
        _dBContext = new AreosaManagerDBContext();
    }


    // DEV NOTES: At some point encription must be added either here or the frontend.
    /// <summary>
    ///     Returns a user whose email and password match the ones provided in email and password respectively.
    /// </summary>
    /// <param name="email">the provided email address.</param>
    /// <param name="password">the provided password.</param>
    /// <returns>The respective user if successful. Null if not.</returns>
    public async Task<User> GetUserByCredentialsAsync(string email, string password)
    {
        User ret = null;
        User user = await _dBContext.TblUsers.Where(
            u => u.Email.Equals(email) &&
                 u.Password.Equals(password)
            ).SingleAsync();

        if(user != null)
        {
            ret = user;
        }

        return ret;
    }

    public async Task<bool> UserExists(string email, string password)
    {
        return await _dBContext.TblUsers.AnyAsync(u => u.Email.Equals(email) &&
                 u.Password.Equals(password));
    }

    //public Task<List<string>> GetRolesAsync(string email, string password)
    //{
    //    _dBContext.Roles.
    //}
}
