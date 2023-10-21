using ShopFashion.ViewModels.Common;

namespace ShopFashion.ViewModels.System.User;

public class GetUserPagingRequest : PagingRequestBase
{
    public string Keyword { get; set; }
}
