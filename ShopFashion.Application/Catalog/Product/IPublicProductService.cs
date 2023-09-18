using ShopFahion.ViewModels.Catalog.Products;
using ShopFahion.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopFashion.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);
        Task<List<ProductViewModel>> GetAll();
    }
}