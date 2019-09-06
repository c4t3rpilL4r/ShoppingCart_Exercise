using SC.BL.Manager;
using SC.UI;
using System;

namespace ShoppingCart.Services
{
    public class DisplayHandler
    {
        public static void Run()
        {
            DisplayHandler.DisplayService();
        }

        public static void DisplayService(int serviceId = 0)
        {
            CartManager cartManager = new CartManager();

            Console.Clear();

            if (cartManager.RetrieveAll().Count > 0)
            {
                CartUI.CartDisplay();
            }

            ProductUI.ProductDisplay();
        }
    }
}
