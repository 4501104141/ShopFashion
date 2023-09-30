using ShopFashion.ViewModels.Common;
using ShopFashion.ViewModels.System.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopFashion.Application.System.Languages;

public interface ILanguageService
{
    Task<ApiResult<List<LanguageVm>>> GetAll();
}
