using ShopFashion.ViewModels.System.Languages;

namespace ShopFashion.AdminApp.Models
{
    public class NavigationViewModel
    {
        public List<LanguageVm> Languages { get; set; }

        public string CurrentLanguageId { get; set; }
    }
}
