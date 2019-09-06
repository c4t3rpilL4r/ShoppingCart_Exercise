using SC.BL.Manager;
using SC.UI.Services;
using SC.BL.Validators;

using System;

namespace ShoppingCart.Services
{
    public class ConsoleInputValidator
    {
        private static CartManager _cartManager = new CartManager();

        public static int ServiceInputValidator(int serviceId = 0)
        {
            ProductManager productManager = new ProductManager();
            int input;
            var isValid = false;

            do
            {
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    InvalidInputHandler.EraseInvalidInput(serviceId);
                }

                switch (serviceId)
                {
                    case 0:
                        // the value of input here will then become the serviceId once validated if either 1,2,3
                        isValid = !ServiceHandler.ValidateService(input);
                        break;
                    case 1:
                        isValid = !productManager.Validate(input);
                        break;
                    case 2:
                        isValid = !_cartManager.Validate(input);
                        break;
                    case 3:
                        isValid = CashOnHandValidator.CheckIfCashOnHandIsEnough(input);
                        break;
                }

                if (isValid)
                {
                    InvalidInputHandler.EraseInvalidInput(serviceId);
                }

            } while (isValid);

            return input;
        }

        public static int QuantityInputValidator(int serviceId)
        {
            int input;
            Console.Write("Quantity: ");
            bool isValid = true;

            do
            {
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    InvalidInputHandler.EraseInvalidInput(-2);
                }

                if (serviceId == 1)
                {
                    isValid = input > 0 ? true : false;
                }
                else if (serviceId == 2)
                {
                    isValid = input < 0 ? false : true;
                }

                if (!isValid)
                {
                    InvalidInputHandler.EraseInvalidInput(-2);
                }
            } while (!isValid);
            
            return input;
        }
    }
}
