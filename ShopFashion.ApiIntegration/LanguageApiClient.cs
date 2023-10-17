using ShopFashion.ViewModels.Common;
using ShopFashion.ViewModels.System.Languages;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;



namespace ShopFashion.ApiIntegration;

public class LanguageApiClient : BaseApiClient, ILanguageApiClient
{
    public LanguageApiClient(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        : base(httpClientFactory, httpContextAccessor, configuration)
    {
    }

    public async Task<ApiResult<List<LanguageVm>>> GetAll()
    {
        return await GetAsync<ApiResult<List<LanguageVm>>>("/api/languages");
    }
}
