using ProductAssignment.Models;

namespace ProductAssignment.Data.Repositories
{
    public class Repository : IRepository
    {
        private readonly List<Product> _products = new();

     

        public IEnumerable<Product> GetAllAsync()
        {
            return _products;
        }

        public void Add(Product product)
        {
            product.Id = _products.Count + 1;
            _products.Add(product);
        }
    }
}