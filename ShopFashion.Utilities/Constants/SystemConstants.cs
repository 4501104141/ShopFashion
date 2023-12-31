﻿
namespace ShopFashion.Utilities.Constants;

public class SystemConstants
{
    public const string MainConnectionString = "ShopFashionDB";

    public class AppSettings
    {
        public const string DefaultLanguageId = "DefaultLanguageId";
        public const string Token = "Token";
        public const string BaseAddress = "BaseAddress";
    }
    public class ProductSettings
    {
        public const int NumberOfFeaturedProducts = 4;
        public const int NumberOfLatestProducts = 6;
    }
}