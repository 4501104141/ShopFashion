using ShopFashion.ViewModels.Common;
using System;
using System.Collections.Generic;

namespace ShopFashion.ViewModels.System.User;

public class RoleAssignRequest
{
    public Guid Id { get; set; }
    public List<SelectItem> Roles { get; set; } = new List<SelectItem>();
}
