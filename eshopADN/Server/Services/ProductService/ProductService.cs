namespace eshopADN.Server.Services.ProductService;

public class ProductService : IProductService
{
    private readonly DataContext _context;
    public ProductService(DataContext context)
    {
        _context = context;
    }
    public async Task<ServiceResponse<List<Product>>> GetProductsGetAsync()
    {
        return new ServiceResponse<List<Product>>()
            { Data = await _context.Products.ToListAsync() };
    }

    public async Task<ServiceResponse<Product>> GetProductByIdAsync(int id)
    {
        var response = new ServiceResponse<Product>();
        var result = await _context.FindAsync<Product>(id);
        if(result == null)
        {
            response.Success = false;
            response.Message = "Product not found.";
            return response;
        }
        response.Data = result;
        return response;
    }

    public async Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl)
    {
        var response = new ServiceResponse<List<Product>>
        {
            Data = await _context.Products
                .Where(x => x.Category != null && x.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
                .ToListAsync()
        };
        return response;
    }
}