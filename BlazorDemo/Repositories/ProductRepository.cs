using BlazorDemo.Models;

namespace BlazorDemo.Repositories;

public class ProductRepository
{
    private readonly ContosoCraftsContext _context;

    public ProductRepository(ContosoCraftsContext context)
    {
        _context = context;
    }
    
    public IEnumerable<Product> GetProducts()
    {
        return _context.Products.ToList();
    }
}