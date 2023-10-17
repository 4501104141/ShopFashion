using ShopFashion.ViewModels.Catalog.Products;
using ShopFashion.ViewModels.Common;


namespace ShopFashion.ApiIntegration;

public interface IProductApiClient
{
    Task<PagedResult<ProductVm>> GetPagings(GetManageProductPagingRequest request);
    Task<bool> CreateProduct(ProductCreateRequest request);
    Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);
    Task<ProductVm> GetById(int id, string languageId);
    Task<List<ProductVm>> GetFeaturedProducts(string languageId, int take);
}
