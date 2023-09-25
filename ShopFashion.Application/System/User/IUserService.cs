using ShopFashion.ViewModels.Common;
using ShopFashion.ViewModels.System.User;
using ShopFashion.ViewModels.System.Users;
using System.Threading.Tasks;

namespace ShopFashion.Application.System.Users;

public interface IUserService
{
    Task<string> Authencate(LoginRequest request);
    Task<bool> Register(RegisterRequest request);
    Task<PagedResult<UserVm>> GetUsersPaging(GetUserPagingRequest request);
}