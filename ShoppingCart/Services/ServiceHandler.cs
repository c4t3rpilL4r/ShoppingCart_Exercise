using SC.BL.Manager;
using ShoppingCart.Services;
using System;

namespace SC.UI.Services
{
    public class ServiceHandler
    {
        private static CartManager _cartManager = new CartManager();

        public static void SelectedService(int serviceId)
        {
            ProductManager productManager = new ProductManager();

            if (serviceId == 1)
            {
                Console.Write("Enter product id: ");
                int productId = ConsoleInputValidator.ServiceInputValidator(serviceId);
                int quantity = ConsoleInputValidator.QuantityInputValidator(serviceId);

                if (_cartManager.Retrieve(productId) != null)
                {
                    _cartManager.Update(_cartManager.Retrieve(productId), serviceId, quantity);
                }
                else
                {
                    _cartManager.Add(productManager.Retrieve(productId), quantity);
                }

                DisplayHandler.DisplayService();
            }
            else if (serviceId == 2)
            {
                Console.Write("Choose which ID to decrease/remove: ");
                int productId = ConsoleInputValidator.ServiceInputValidator(serviceId);
                int quantity = ConsoleInputValidator.QuantityInputValidator(serviceId);

                _cartManager.Update(_cartManager.Retrieve(productId), serviceId, quantity);

                DisplayHandler.DisplayService();
            }
            else if (serviceId == 3)
            {
                Console.Write("Please enter cash on hand: ");
                ConsoleInputValidator.ServiceInputValidator(serviceId);

                DoTransactionAgain();
            }
        }

        public static bool ValidateService(int serviceId)
        {
            if (serviceId == 2 || serviceId == 3)
            {
                if (_cartManager.RetrieveAll().Count < 1)
                {
                    return false;
                }
            }
            else if (serviceId != 1)
            {
                return false;
            }

            return true;
        }

        public static void DoTransactionAgain()
        {
            Console.Write(@"Thank you for shopping with us.

Would you like to do more transactions (y/n): ");

            string answer = Console.ReadLine().ToLower();

            while (!(answer.Equals("y") || answer.Equals("n")))
            {
                InvalidInputHandler.EraseInvalidInput(-1);
                answer = Console.ReadLine();
            }

            if (answer.Equals("y"))
            {
                Console.Clear();
                _cartManager.ResetList();
                ProductUI.ProductDisplay();
            }
            else if (answer.Equals("n"))
            {
                Environment.Exit(0);
            }
        }
    }
}
