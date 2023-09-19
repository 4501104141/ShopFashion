using System.Collections.Generic;

namespace ShopFashion.ViewModels.Common;

public class PagedResult<T>
{
    public List<T> Items { set; get; }
    public int TotalRecord { set; get; }
}