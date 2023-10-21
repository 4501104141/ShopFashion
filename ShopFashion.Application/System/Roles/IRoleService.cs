using ShopFashion.ViewModels.System.User.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopFashion.Application.System.Roles;

public interface IRoleService
{
    Task<List<RoleVm>> GetAll();
}
