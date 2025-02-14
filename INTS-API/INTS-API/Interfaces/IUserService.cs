﻿using INTS_API.Models.ServiceResponse;
using System.Threading.Tasks;

namespace INTS_API.Interfaces
{
    public interface IUserService
    {
        Task<AuthLoginResult> Login(string userName, string plainPassword);
        Task<ServiceResult> Register(string userName, string plainPassword);
    }
}
