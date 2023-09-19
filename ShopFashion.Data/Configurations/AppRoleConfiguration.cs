﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ShopFashion.Data.Entities;

namespace ShopFashion.Data.Configurations
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.ToTable("AppRoles");
            builder.Property(x => x.Description).HasMaxLength(200).IsRequired();
        }
    }
}