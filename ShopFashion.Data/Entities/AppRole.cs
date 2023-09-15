using System;
using Microsoft.AspNetCore.Identity;

namespace ShopFashion.Data.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
