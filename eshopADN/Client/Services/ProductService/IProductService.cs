namespace eshopADN.Client.Services.ProductService;

public interface IProductService
{
    event Action ProductChange ;
    List<Product> Products { get; set; }
    Task GetProducts(string categoryUrl = null);
    Task<ServiceResponse<Product>> GetProductByIdAsync(int id);
    public string Message { get; set; }
    Task SearchProduct(string searchTerm);
    Task<List<string>> GetSuggestions(string searchTerm);
}