using D13P06Shop.Shared;
using Shop.Shared.Auth;

namespace Shop.API.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<string>> Login(string email, string password);

        Task<ServiceResponse<int>> Register(User user, string password);

        Task<ServiceResponse<bool>> ChangePassword(int userId, string newPassword);

        Task<bool> UserExists(string email);
    }
}
