using mvcdemoapp.Models;

namespace mvcdemoapp.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProduct();
        Product? GetProductById(int pid);
    }
}
