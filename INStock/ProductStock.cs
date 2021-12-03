using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace INStock
{
    public class ProductStock
    {
        private List<Product> productsStock;

        public ProductStock()
        {
            productsStock = new List<Product>();
        }

        public void Add(Product product)
        {
            productsStock.Add(product);
        }

        public bool Contains(Product product)
        {
            return productsStock.Contains(product);
        }

        public int Count => productsStock.Count;

        public Product Find(int index)
        {
            Product product = null;
            try
            {
                product = productsStock.ElementAt(index);
            }
            catch (Exception)
            {
                throw new IndexOutOfRangeException();
            }

            return product;
        }

        public Product FindByLabel(string label)
        {
            Product product = null;
            try
            {
                product = productsStock.Find(x => x.Label == label);
            }
            catch (Exception)
            {
                throw new ArgumentException();
            }

            return product;
        }

        public List<Product> FindAllInPriceRange(decimal startPrice, decimal endPrice)
        {
            return productsStock.FindAll(x => x.Price >= startPrice && x.Price <= endPrice).OrderByDescending(x => x.Price).ToList();
        }

        public List<Product> FindAllByPrice(decimal price)
        {
            return productsStock.FindAll(x => x.Price == price);
        }

        public List<Product> FindMostExpensiveProducts(int quantity)
        {
            var products = productsStock.OrderByDescending(x => x.Price);

            var productsToReturn = new List<Product>();

            for (int i = 0; i < quantity; i++)
            {
                productsToReturn.Add(products.ElementAt(i));
            }

            return productsToReturn;

        }

        public List<Product> FindAllByQuantity(int quantity)
        {
            return productsStock.FindAll(x => x.Quantity == quantity);
        }

        public List<Product> GetEnumerator() => productsStock;
    }
}
