namespace SC.BL.Models
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            Id = productId;
        }

        public int Id { get; private set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string Log() => string.Format("| {0, 2} | {1, 23} | ${2, 4} |", Id, Name, Price);
    }
}
