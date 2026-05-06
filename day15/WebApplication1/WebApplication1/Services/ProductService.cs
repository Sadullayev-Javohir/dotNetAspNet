using WebApplication1.Interfaces;

namespace WebApplication1.Services;

public class ProductService : IProductService
{
    public List<string> GetAll()
    {
        return new List<string>()
        {
            "Phone",
            "Laptop",
            "Mouse"
        };
    }
}