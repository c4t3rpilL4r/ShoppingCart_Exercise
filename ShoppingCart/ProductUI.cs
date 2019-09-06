using SC.BL.Manager;
using SC.UI.Services;
using ShoppingCart.Services;
using System;

namespace SC.UI
{
    public class ProductUI
    {
        public static void ProductDisplay()
        {
            ProductManager productManager = new ProductManager();

            Console.Title = "Shopping Cart";
            Console.WriteLine($@"|--------------------------------------|
| ID |        Item Name        | Price |
|----|-------------------------|-------|");

            foreach (var item in productManager.RetrieveAll())
            {
                Console.WriteLine(item.Log());
            }

            Console.WriteLine(@"|--------------------------------------|

Please choose service:
1 - To add product to cart
2 - To decrease/delete item from cart
3 - To checkout");

            Console.Write("Enter service number: ");

            ServiceHandler.SelectedService(ConsoleInputValidator.ServiceInputValidator());
        }
    }
}
