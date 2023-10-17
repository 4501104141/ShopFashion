using ShopFashion.ViewModels.Catalog.Products;
using ShopFashion.ViewModels.Utilities.Slides;
using System.Collections.Generic;

namespace ShopFashion.WebApp.Models
{
    public class HomeViewModel
    {
        public List<SlideVm> Slides { get; set; }
        public List<ProductVm> FeaturedProducts { get; set; }
    }
}
