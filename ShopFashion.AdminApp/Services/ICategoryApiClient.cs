using ShopFashion.ViewModels.Catalog.Categories;

namespace ShopFashion.AdminApp.Services;

public interface ICategoryApiClient
{
    Task<List<CategoryVm>> GetAll(string languageId);
}
