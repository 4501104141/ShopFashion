﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopFashion.Application.System.Roles;
using System.Threading.Tasks;

namespace ShopFashion.BackendApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class RolesController : ControllerBase
{
    private readonly IRoleService _roleService;

    public RolesController(IRoleService roleService)
    {
        _roleService = roleService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var roles = await _roleService.GetAll();
        return Ok(roles);
    }
}
