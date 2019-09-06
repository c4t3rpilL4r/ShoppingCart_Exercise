using SC.BL.Models;
using SC.BL.Repos;
using System.Collections.Generic;
using System.Linq;

namespace SC.BL.Manager
{
    public class ProductManager
    {
        private ProductRepository _productRepository = new ProductRepository();

        public bool Validate(int productId)
        {
            return _productRepository.Retrieve(productId) != null;
        }

        public Product Retrieve(int productId)
        {
            return _productRepository.Retrieve(productId);
        }

        public IEnumerable<Product> RetrieveAll()
        {
            return _productRepository.RetrieveAll();
        }
    }
}
