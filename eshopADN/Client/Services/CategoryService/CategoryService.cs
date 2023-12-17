using System.Net.Http.Json;

namespace eshopADN.Client.Services.CategoryService;

public class CategoryService : ICategoryService
{
    private readonly HttpClient _httpClient;
    public CategoryService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
   
    public List<Category> Categories { get; set; }
    public async Task GetCategories()
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category");
        if(response != null && response.Data != null)
            Categories = response.Data;
    }
}