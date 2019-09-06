namespace SC.BL.Models
{
    public class Cart
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }

        public string Log() => string.Format("| {0, 2} | {1, 23} | {2, 8} | {3, 11} |", ProductId, ProductName, Quantity, "$" + PurchasePrice);
    }
}
