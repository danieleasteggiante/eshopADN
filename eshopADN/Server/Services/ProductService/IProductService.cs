namespace eshopADN.Server.Services.ProductService;

public interface IProductService
{
    Task<ServiceResponse<List<Product>>> GetProductsGetAsync();
    
    Task<ServiceResponse<Product>> GetProductByIdAsync(int id);
    Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl);
}