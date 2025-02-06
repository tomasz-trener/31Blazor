using D13P06Shop.Shared;
using Microsoft.AspNetCore.Mvc;
using Shop.Shared.Entity;
using Shop.Shared.Services;

namespace Shop.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            Thread.Sleep(2000);
            var result = await _productService.GetProductsAsync();

            if (result.Success)
                return Ok(result);
            else
            {
                return StatusCode(500, $"Internal server error {result.Message}");
            }
        }


        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Product>>> CreateProduct([FromBody] Product product)
        {
            var result = await _productService.CreateProductAsync(product);

            if (result.Success)
                return Created($"api/Product/{product.Id}", result); // 201
                                                                     //return Ok(result);
            else
            {
                return StatusCode(500, $"Internal server error {result.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<bool>>> DeleteProduct([FromRoute] int id)
        {
            var result = await _productService.DeleteProductAsync(id);

            if (result.Success)
                return Ok(result);
            else
            {
                return StatusCode(500, $"Internal server error {result.Message}");
            }
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Product>>> UpdateProduct([FromBody] Product product)
        {
            var result = await _productService.UpdateProductAsync(product);

            if (result.Success)
                return Ok(result);
            else
            {
                return StatusCode(500, $"Internal server error {result.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProduct([FromRoute] int id)
        {
            try
            {
                var result = await _productService.GetProductAsync(id);
                if (result.Success)
                    return Ok(result);
                else
                {
                    return NotFound($"Product with ID {id} not found");
                    //return StatusCode(500, $"Internal server error {result.Message}");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error {ex.Message}");
            }

        }
    }
}
