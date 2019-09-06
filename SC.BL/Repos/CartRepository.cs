using SC.BL.Models;
using System.Collections.Generic;
using System.Linq;

namespace SC.BL.Repos
{
    internal class CartRepository
    {
        private static List<Cart> _cartList = new List<Cart>();

        public void Add(Product product, int quantity)
        {
            Cart cart = new Cart()
            {
                ProductId = product.Id,
                ProductName = product.Name,
                Quantity = quantity,
                PurchasePrice = product.Price * quantity
            };

            _cartList.Add(cart);
        }

        public void Update(Cart cart, int serviceId, int quantity)
        {
            if (serviceId == 1)
            {
                cart.PurchasePrice += (cart.PurchasePrice / cart.Quantity) * quantity;
                cart.Quantity += quantity;
            }
            else if (serviceId == 2)
            {
                if ((cart.Quantity - quantity) > 0)
                {
                    cart.PurchasePrice -= (cart.PurchasePrice / cart.Quantity) * quantity;
                    cart.Quantity -= quantity;
                }
                else
                {
                    Delete(cart);
                }
            }
        }

        public void Delete(Cart cart)
        {
            _cartList.Remove(cart);
        }

        public Cart Retrieve(int productId)
        {
            return _cartList.FirstOrDefault(x => x.ProductId == productId);
        }

        public List<Cart> RetrieveAll()
        {
            return _cartList;
        }

        public void ResetList()
        {
            _cartList.Clear();
        }
    }
}
