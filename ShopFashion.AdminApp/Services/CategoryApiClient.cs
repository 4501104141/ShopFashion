﻿using ShopFashion.ViewModels.Catalog.Categories;

namespace ShopFashion.AdminApp.Services;

public class CategoryApiClient : BaseApiClient, ICategoryApiClient
{
    public CategoryApiClient(IHttpClientFactory httpClientFactory,
               IHttpContextAccessor httpContextAccessor,
                IConfiguration configuration)
        : base(httpClientFactory, httpContextAccessor, configuration)
    {
    }

    public async Task<List<CategoryVm>> GetAll(string languageId)
    {
        return await GetListAsync<CategoryVm>("/api/categories?languageId=" + languageId);
    }
}
