using Microsoft.AspNetCore.Mvc;

namespace eshopADN.Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProduct()
    {
        return Ok(await _productService.GetProductsGetAsync());
    }
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int id)
    {
        return Ok(await _productService.GetProductByIdAsync(id));
    }
    
   [HttpGet("category/{categoryUrl}")]
    public async Task<ActionResult<ServiceResponse<Product>>> GetProductsByCategory(string categoryUrl)
    {
        return Ok(await _productService.GetProductsByCategoryAsync(categoryUrl));
    }
   [HttpGet("search/{searchTerm}")]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> SearchProduct(string searchTerm)
    {
        return Ok(await _productService.SearchProduct(searchTerm));
    }   
    [HttpGet("searchSuggestion/{searchTerm}")]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> SearchProductSuggestion(string searchTerm)
    {
        return Ok(await _productService.GetSuggestions(searchTerm));
    }
    [HttpGet("featured")]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetFeaturedProducts()
    {
        return Ok(await _productService.GetFeaturedProductsAsync());
    }

}