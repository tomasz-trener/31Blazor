using D13P06Shop.Shared;
using Shop.Shared.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Shared.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ServiceResponse<bool>> ChangePassword(string newPassword)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/auth/changePassword", newPassword);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }

        public async Task<ServiceResponse<string>> Login(UserLoginDto userLoginDto)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/auth/login", userLoginDto);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<ServiceResponse<int>> Register(UserRegisterDto userRegisterDto)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/auth/register", userRegisterDto);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }
    }
}
