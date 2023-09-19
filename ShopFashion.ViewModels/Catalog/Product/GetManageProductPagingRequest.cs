﻿using ShopFashion.ViewModels.Common;
using System.Collections.Generic;

namespace ShopFashion.ViewModels.Catalog.Products;

public class GetManageProductPagingRequest : PagingRequestBase
{
    public string Keyword { get; set; }
    public List<int> CategoryIds { get; set; }
}