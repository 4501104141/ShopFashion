using ShopFashion.ViewModels.System.Users;

namespace ShopFashion.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
    }
}