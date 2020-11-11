using AreosaManagerAPI.DAL.Interfaces;
using AreosaManagerAPI.Models;
using System;
using System.Linq;

/// <summary>
/// Summary description for Class1
/// </summary>
public class UserRespository : IUserRepository
{
    private AreosaManagerDBContext dBContext;
	public UserRespository()
	{
        dBContext = new AreosaManagerDBContext();
    }

    // DEV NOTES: At some point encription must be added either here or the frontend.
    /// <summary>
    ///     Returns a user whose email and password match the ones provided in email and password respectively.
    /// </summary>
    /// <param name="email">the provided email address.</param>
    /// <param name="password">the provided password.</param>
    /// <returns>The respective user if successful. Null if not.</returns>
    public User GetUserByCredentials(string email, string password)
    {
        User ret = null;
        User user = this.dBContext.TblUsers.Where(u => u.Email.Equals(email) && u.Password.Equals(password)).FirstOrDefault();
        
        if(user != null)
        {
            ret = user;
        }

        return ret;
    }
}
