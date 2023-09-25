using ShopFashion.ViewModels.Common;
using ShopFashion.ViewModels.System.User;
using ShopFashion.ViewModels.System.Users;

namespace ShopFashion.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
        Task<PagedResult<UserVm>> GetUsersPagings(GetUserPagingRequest request);
    }
}