using ShopFashion.ViewModels.Catalog.Categories;


namespace ShopFashion.ApiIntegration;

public interface ICategoryApiClient
{
    Task<List<CategoryVm>> GetAll(string languageId);
}
