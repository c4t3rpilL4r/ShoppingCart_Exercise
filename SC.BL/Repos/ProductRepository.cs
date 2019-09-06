using SC.BL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SC.BL.Repos
{
    internal class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            return RetrieveAll().FirstOrDefault(x => x.Id == productId);
        }

        public IEnumerable<Product> RetrieveAll()
        {
            return File.ReadAllLines("D:\\Mentoring 101\\September04\\ShoppingCart\\SC.BL\\Data\\item.csv")
                .Skip(1)
                .ToList()
                .Select(x => new Product(Convert.ToInt32(x.Split(',')[0]))
                {
                    Name = x.Split(',')[1],
                    Price = Convert.ToInt32(x.Split(',')[2])
                });
        }
    }
}
