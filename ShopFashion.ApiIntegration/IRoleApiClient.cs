using ShopFashion.ViewModels.Common;
using ShopFashion.ViewModels.System.User.Roles;

namespace ShopFashion.ApiIntegration;

public interface IRoleApiClient
{
    Task<ApiResult<List<RoleVm>>> GetAll();
}
