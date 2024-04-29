using System.ComponentModel;

namespace API
{
    public class FakeDataStore
    {
        private static List<Product>? _products;
        public FakeDataStore()
        {
            _products = new List<Product>
            {
                new() { Id = 1, Name = "Product 1" },
                new() { Id = 2, Name = "Product 2" },
                new() { Id = 3, Name = "Product 3" },
                new() { Id = 4, Name = "Product 4" },
                new() { Id = 5, Name = "Product 5" }
            };
        }
        public async Task AddProduct(Product product)
        {
            _products?.Add(product);
            await Task.CompletedTask;
        }   
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await Task.FromResult(_products) ?? [];
        }
        public async Task<Product> GetProductById(int id)
        {
            return await Task.FromResult(_products?.Single(p => p.Id == id) ?? new Product());
        }
    }
}
