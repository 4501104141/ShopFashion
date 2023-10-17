using ShopFashion.ViewModels.Utilities.Slides;

namespace ShopFashion.ApiIntegration
{
    public interface ISlideApiClient
    {
        Task<List<SlideVm>> GetAll();
    }
}
