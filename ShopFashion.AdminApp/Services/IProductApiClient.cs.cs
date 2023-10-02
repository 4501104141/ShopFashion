using ShopFashion.ViewModels.Catalog.Products;
using ShopFashion.ViewModels.Common;

namespace ShopFashion.AdminApp.Services
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductVm>> GetPagings(GetManageProductPagingRequest request);
        Task<bool> CreateProduct(ProductCreateRequest request);
    }
}
