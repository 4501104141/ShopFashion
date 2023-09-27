using Microsoft.AspNetCore.Mvc;
using ShopFashion.ViewModels.Common;

namespace ShopFashion.AdminApp.Controllers.Components;

public class PagerViewComponent : ViewComponent
{
    public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
    {
        return Task.FromResult((IViewComponentResult)View("Default", result));
    }
}
