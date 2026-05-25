using mvcdemoapp.Models;

namespace mvcdemoapp.Services
{
    public class ProductService : IProductService
    {

        private readonly List<Product> _products = new()
        {
            new Product { ProductId=101,ProductName="Laptop",ProductPrice=90000,ProductCategory="Electronics",IsAvailable=true,ProductDescription="Laptop"},
            new Product { ProductId=102,ProductName="Smart Phone",ProductPrice=9000,ProductCategory="Electronics",IsAvailable=true,ProductDescription="Phone"},
            new Product { ProductId=103,ProductName="HeadPhones",ProductPrice=900,ProductCategory="Accessories",IsAvailable=true,ProductDescription="HeadPhones"},
            new Product { ProductId=104,ProductName="Desktop",ProductPrice=80000,ProductCategory="Electronics",IsAvailable=true,ProductDescription="Desktop"},
            new Product { ProductId=105,ProductName="IPhone",ProductPrice=95000,ProductCategory="Electronics",IsAvailable=true,ProductDescription="IPhone"},
        };
        public IEnumerable<Product> GetAllProduct()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }

    }
}
