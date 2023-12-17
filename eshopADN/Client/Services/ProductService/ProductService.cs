using System.Net.Http.Json;

namespace eshopADN.Client.Services.ProductService;

public class ProductService : IProductService
{
    private readonly HttpClient _httpClient;
    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public event Action? ProductChange;
    public List<Product> Products { get; set; } = new List<Product>();
    public async Task GetProducts(string? categoryUrl = null)
    {
        var response = categoryUrl == null ? 
            await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product"):
            await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");
        if(response != null && response.Data != null)
            Products = response.Data;
        ProductChange.Invoke();
    }
    
    public async Task<ServiceResponse<Product>> GetProductByIdAsync(int id)
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{id}");
        return response!;
    }
}