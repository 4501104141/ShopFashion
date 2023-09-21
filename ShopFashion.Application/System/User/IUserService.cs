using ShopFashion.ViewModels.System.Users;
using System.Threading.Tasks;

namespace ShopFashion.Application.System.Users;

public interface IUserService
{
    Task<string> Authencate(LoginRequest request);
    Task<bool> Register(RegisterRequest request);
}