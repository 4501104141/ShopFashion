using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShopFashion.Data.Entities;
using ShopFashion.ViewModels.System.User.Roles;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopFashion.Application.System.Roles;

public class RoleService : IRoleService
{
    private readonly RoleManager<AppRole> _roleManager;

    public RoleService(RoleManager<AppRole> roleManager)
    {
        _roleManager = roleManager;
    }

    public async Task<List<RoleVm>> GetAll()
    {
        var roles = await _roleManager.Roles
            .Select(x => new RoleVm()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description
            }).ToListAsync();
        return roles;
    }
}
