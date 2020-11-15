using System.Threading.Tasks;

namespace AreosaManagerAPI.Controllers
{
    internal interface IAuthService
    {
        public Task<bool> IsValidCredentials(string email, string password);
    }
}