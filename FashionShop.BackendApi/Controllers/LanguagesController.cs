using Microsoft.AspNetCore.Mvc;
using ShopFashion.Application.System.Languages;
using System.Threading.Tasks;

namespace ShopFashion.BackendApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LanguagesController : Controller
{
    private readonly ILanguageService _languageService;

    public LanguagesController(ILanguageService languageService)
    {
        _languageService = languageService;
    }

    [HttpGet()]
    public async Task<IActionResult> GetAll()
    {
        var products = await _languageService.GetAll();
        return Ok(products);
    }
}
