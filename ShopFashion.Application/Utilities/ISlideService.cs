using ShopFashion.ViewModels.Utilities.Slides;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopFashion.Application.Utilities
{
    public interface ISlideService
    {
        Task<List<SlideVm>> GetAll();
    }
}
