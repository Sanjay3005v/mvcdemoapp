using mvcdemoapp.Models;

namespace mvcdemoapp.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProduct();
        Product? GetProductById(int pid);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int pid);

    }
}
