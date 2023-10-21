using ShopFashion.ViewModels.Common;
using ShopFashion.ViewModels.System.Languages;


namespace ShopFashion.ApiIntegration
{
    public interface ILanguageApiClient
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}
