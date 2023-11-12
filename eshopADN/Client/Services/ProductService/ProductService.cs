using System.Net.Http.Json;

namespace eshopADN.Client.Services.ProductService;

public class ProductService : IProductService
{
    private readonly HttpClient _httpClient;
    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public List<Product> Products { get; set; } = new List<Product>();
    public async Task GetProducts()
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
        if(response is { Success: true, Data: not null })
        {
            Products = response.Data;
        }
    }

    public async Task<ServiceResponse<Product>> GetProductByIdAsync(int id)
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{id}");
        return response!;
    }
}