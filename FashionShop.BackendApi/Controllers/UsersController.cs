using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopFashion.Application.System.Users;
using ShopFashion.ViewModels.System.User;
using System;
using System.Threading.Tasks;

namespace ShopFashion.BackendApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("authenticate")]
    [AllowAnonymous]
    public async Task<IActionResult> Authenticate([FromBody] LoginRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var resultToken = await _userService.Authencate(request);
        if (string.IsNullOrEmpty(resultToken.ResultObj))
        {
            return BadRequest("Username or password is incorrect.");
        }
        return Ok(resultToken);
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Register([FromBody] RegisterRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var result = await _userService.Register(request);
        if (!result.IsSuccessed)
        {
            return BadRequest("Register is unsuccessful.");
        }
        return Ok(result);
    }

    //http://localhost/api/users/paging?pageIndex=1&pageSize=10&keyword=
    [HttpGet("paging")]
    public async Task<IActionResult> GetAllPaging([FromQuery] GetUserPagingRequest request)
    {
        var products = await _userService.GetUsersPaging(request);
        return Ok(products);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UserUpdateRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var result = await _userService.Update(id, request);
        if (!result.IsSuccessed)
        {
            return BadRequest(result);
        }
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var user = await _userService.GetById(id);
        return Ok(user);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _userService.Delete(id);
        return Ok(result);
    }
}