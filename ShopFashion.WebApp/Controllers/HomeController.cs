﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopFashion.WebApp.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Localization;
using System;
using ShopFashion.ApiIntegration;
using System.Threading.Tasks;
using ShopFashion.Utilities.Constants;
using System.Globalization;

namespace ShopFashion.WebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ISharedCultureLocalizer _loc;
    private readonly ISlideApiClient _slideApiClient;
    private readonly IProductApiClient _productApiClient;

    public HomeController(ILogger<HomeController> logger, ISlideApiClient slideApiClient,
            IProductApiClient productApiClient)
    {
        _logger = logger;
        _slideApiClient = slideApiClient;
        _productApiClient = productApiClient;
    }

    public async Task<IActionResult> Index()
    {
        var culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
        var viewModel = new HomeViewModel
        {
            Slides = await _slideApiClient.GetAll(),
            FeaturedProducts = await _productApiClient.GetFeaturedProducts(culture, SystemConstants.ProductSettings.NumberOfFeaturedProducts),
            LatestProducts = await _productApiClient.GetLatestProducts(culture, SystemConstants.ProductSettings.NumberOfLatestProducts)
        };
        return View(viewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult SetCultureCookie(string cltr, string returnUrl)
    {
        Response.Cookies.Append(
            CookieRequestCultureProvider.DefaultCookieName,
            CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(cltr)),
            new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );
        return LocalRedirect(returnUrl);
    }
}
