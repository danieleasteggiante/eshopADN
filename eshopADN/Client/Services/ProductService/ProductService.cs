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
            // TODO meglio togliere il /featured e gestire con un metodo specifico?
            await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product/featured"):
            await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");
        if(response != null && response.Data != null)
            Products = response.Data;
        ProductChange?.Invoke();
    }
    
    public async Task<ServiceResponse<Product>> GetProductByIdAsync(int id)
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{id}");
        return response!;
    }

    public string Message { get; set; } = "Loading...";
    public async Task SearchProduct(string searchTerm)
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/search/{searchTerm}");
        if(response is { Data: not null })
            Products = response.Data;
        if(response?.Data is { Count: 0 })
            Message = "No product found";
        ProductChange?.Invoke();
    }

    public async Task<List<string>> GetSuggestions(string searchTerm)
    {
        var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<string>>>($"api/product/searchSuggestion/{searchTerm}");
        return result?.Data ?? new List<string>();
    }
}