using SC.BL.Manager;
using SC.BL.Models;
using System;
using System.Collections.Generic;

namespace SC.UI
{
    public class CartUI
    {
        private static CartManager _cartManager = new CartManager();

        public static void CartDisplay()
        {
            List<Cart> cartList = _cartManager.RetrieveAll();

            Console.WriteLine(@"|-------------------------------------------------------|
| ID |        Item Name        | Quantity | Total Price |
|----|-------------------------|----------|-------------|");

            decimal total = 0;

            foreach (var item in _cartManager.RetrieveAll())
            {
                Console.WriteLine(item.Log());
                total += item.PurchasePrice;
            }

            Console.WriteLine($@"|-------------------------------------------------------|
|                        TOTAL | {string.Format("{0, 22}", "$" + total)} |
|-------------------------------------------------------|
{Environment.NewLine}");
        }
    }
}
