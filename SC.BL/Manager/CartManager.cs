using SC.BL.Models;
using SC.BL.Repos;
using System.Collections.Generic;

namespace SC.BL.Manager
{
    public class CartManager
    {
        private CartRepository _cartRepository = new CartRepository();

        public bool Validate(int productId)
        {
            return _cartRepository.Retrieve(productId) != null;
        }

        public void Add(Product product, int quantity)
        {
            _cartRepository.Add(product, quantity);
        }

        public void Update(Cart cart, int serviceId, int quantity)
        {
            _cartRepository.Update(cart, serviceId, quantity);
        }

        public void Delete(Cart cart)
        {
            _cartRepository.Delete(cart);
        }

        public Cart Retrieve(int productId)
        {
            return _cartRepository.Retrieve(productId);
        }

        public List<Cart> RetrieveAll()
        {
            return _cartRepository.RetrieveAll();
        }

        public void ResetList()
        {
            _cartRepository.ResetList();
        }
    }
}
