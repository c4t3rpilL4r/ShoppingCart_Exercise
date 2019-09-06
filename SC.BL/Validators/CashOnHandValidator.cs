using SC.BL.Manager;
using System.Linq;

namespace SC.BL.Validators
{
    public class CashOnHandValidator
    {
        public static bool CheckIfCashOnHandIsEnough(int input)
        {
            CartManager _cartManager = new CartManager();

            return input < _cartManager.RetrieveAll().Sum(x => x.PurchasePrice);
        }
    }
}
