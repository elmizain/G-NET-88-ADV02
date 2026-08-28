using ShopMaster.Models;

namespace ShopMaster.Services
{
    public class ProductFilter
    {
        public List<Product> FilterProducts(
            List<Product> products,
            Predicate<Product> condition)
        {
            List<Product> results = new List<Product>();

            foreach (Product product in products)
            {
                if (condition(product))
                {
                    results.Add(product);
                }
            }

            return results;
        }
    }
}