namespace eshopADN.Server.Services.ProductService;

public interface IProductService
{
    Task<ServiceResponse<List<Product>>> GetProductsGetAsync();
    
    Task<ServiceResponse<Product>> GetProductByIdAsync(int id);
    Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl);
    Task<ServiceResponse<List<Product>>> SearchProduct(string searchTerm);
    Task<ServiceResponse<List<string>>> GetSuggestions(string searchTerm);
}