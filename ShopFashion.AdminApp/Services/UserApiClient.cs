﻿using Newtonsoft.Json;
using ShopFashion.ViewModels.Common;
using ShopFashion.ViewModels.System.User;
using System.Net.Http.Headers;
using System.Text;

namespace ShopFashion.AdminApp.Services;

public class UserApiClient : IUserApiClient
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IConfiguration _configuration;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public UserApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
    {
        _configuration = configuration;
        _httpClientFactory = httpClientFactory;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<ApiResult<string>> Authenticate(LoginRequest request)
    {
        var json = JsonConvert.SerializeObject(request);
        var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
        var client = _httpClientFactory.CreateClient();
        client.BaseAddress = new Uri("https://localhost:5001");
        var response = await client.PostAsync("/api/users/authenticate", httpContent);
        var token = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            return JsonConvert.DeserializeObject<ApiErrorResult<string>>(await response.Content.ReadAsStringAsync());
        }
        return JsonConvert.DeserializeObject<ApiSuccessResult<string>>(await response.Content.ReadAsStringAsync());
    }

    public async Task<ApiResult<UserVm>> GetById(Guid id)
    {
        var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
        var client = _httpClientFactory.CreateClient();
        client.BaseAddress = new Uri(_configuration["BaseAddress"]);
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
        var response = await client.GetAsync($"/api/users/{id}");
        var body = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            return JsonConvert.DeserializeObject<ApiErrorResult<UserVm>>(body);
        }
        return JsonConvert.DeserializeObject<ApiSuccessResult<UserVm>>(body);
    }

    public async Task<ApiResult<PagedResult<UserVm>>> GetUsersPagings(GetUserPagingRequest request)
    {
        var client = _httpClientFactory.CreateClient();
        var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
        client.BaseAddress = new Uri(_configuration["BaseAddress"]);
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
        string url = $"/api/users/paging?pageIndex="
            + $"{request.PageIndex}&pageSize={request.PageSize}&keyword={request.Keyword}";
        var response = await client.GetAsync(url);
        var body = await response.Content.ReadAsStringAsync();
        var users = JsonConvert.DeserializeObject<ApiSuccessResult<PagedResult<UserVm>>>(body);
        return users;
    }

    public async Task<ApiResult<bool>> RegisterUser(RegisterRequest registerRequest)
    {
        var client = _httpClientFactory.CreateClient();
        client.BaseAddress = new Uri(_configuration["BaseAddress"]);
        var json = JsonConvert.SerializeObject(registerRequest);
        var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await client.PostAsync($"/api/users", httpContent);
        var result = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
        }
        return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);
    }

    public async Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest request)
    {
        var client = _httpClientFactory.CreateClient();
        client.BaseAddress = new Uri(_configuration["BaseAddress"]);
        var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
        var json = JsonConvert.SerializeObject(request);
        var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await client.PutAsync($"/api/users/{id}", httpContent);
        var result = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
        }
        return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);
    }

    public async Task<ApiResult<bool>> Delete(Guid id)
    {
        var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
        var client = _httpClientFactory.CreateClient();
        client.BaseAddress = new Uri(_configuration["BaseAddress"]);
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
        var response = await client.DeleteAsync($"/api/users/{id}");
        var body = await response.Content.ReadAsStringAsync();
        if (response.IsSuccessStatusCode)
        {
            return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(body);
        }
        return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(body);
    }

    public async Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request)
    {
        var client = _httpClientFactory.CreateClient();
        client.BaseAddress = new Uri(_configuration["BaseAddress"]);
        var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
        var json = JsonConvert.SerializeObject(request);
        var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await client.PutAsync($"/api/users/{id}/roles", httpContent);
        var result = await response.Content.ReadAsStringAsync();
        if (response.IsSuccessStatusCode)
        {
            return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);
        }
        return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
    }
}