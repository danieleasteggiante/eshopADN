namespace eshopADN.Server.Services.CategoryService;

public class CategoryService : ICategoryService
{
    private readonly ILogger<CategoryService> _logger;
    private readonly DataContext _context;
    public CategoryService(ILogger<CategoryService> logger, DataContext context)
    {
        _logger = logger;
        _context = context;
    }
    public async Task<ServiceResponse<List<Category>>> GetCategory()
    {
        var response = await _context.Categories.ToListAsync();
        return new ServiceResponse<List<Category>>
        {
            Data = response
        };
    }
}