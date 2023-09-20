using ShopFashion.ViewModels.Catalog.Products;
using ShopFashion.ViewModels.Common;
using System.Threading.Tasks;

namespace ShopFashion.Application.Catalog.Products;

public interface IPublicProductService
{
    Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);
}