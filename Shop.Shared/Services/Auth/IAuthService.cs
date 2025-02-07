﻿using D13P06Shop.Shared;
using Shop.Shared.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Shared.Services.Auth
{
    public interface IAuthService
    {
        Task<ServiceResponse<string>> Login(UserLoginDto userLoginDto);

        Task<ServiceResponse<int>> Register(UserRegisterDto userRegisterDto);

        Task<ServiceResponse<bool>> ChangePassword(string newPassword);
    }
}
