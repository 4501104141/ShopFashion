using ShopFashion.ViewModels.Common;
using ShopFashion.ViewModels.System.Languages;

namespace ShopFashion.AdminApp.Services
{
    public interface ILanguageApiClient
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}
