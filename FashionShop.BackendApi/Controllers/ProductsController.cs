using System.Threading.Tasks;
using ShopFashion.Application.Catalog.Products;
using Microsoft.AspNetCore.Mvc;

namespace ShopFashion.BackendApi.Controllers
{
    public class ProductsController : BaseApiController
    {
        private readonly IPublicProductService _publicProductService;
        public ProductsController(IPublicProductService publicProductService)
        {
            _publicProductService = publicProductService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _publicProductService.GetAll();
            return Ok(products);
        }
        [HttpPut]
        public async Task<IActionResult> Put()
        {
            //call service
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            //call service
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete()
        {
            //call service
            return Ok();
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetById(int productId)
        {
            //call service
            return Ok();
        }

        [HttpGet("category/{categoryId}")]
        public async Task<IActionResult> GetByCategoryId(int categoryId)
        {
            //call service
            return Ok();
        }
    }
}