using ShopFahion.ViewModels.Common;
using ShopFashion.ViewModels.Catalog.Products;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopFashion.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);
        Task<List<ProductViewModel>> GetAll(string languageId);
    }
}