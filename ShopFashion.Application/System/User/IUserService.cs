﻿using ShopFashion.ViewModels.Common;
using ShopFashion.ViewModels.System.User;
using ShopFashion.ViewModels.System.Users;
using System;
using System.Threading.Tasks;

namespace ShopFashion.Application.System.Users;

public interface IUserService
{
    Task<ApiResult<string>> Authencate(LoginRequest request);
    Task<ApiResult<bool>> Register(RegisterRequest request);
    Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request);
    Task<ApiResult<PagedResult<UserVm>>> GetUsersPaging(GetUserPagingRequest request);
    Task<ApiResult<UserVm>> GetById(Guid id);
}