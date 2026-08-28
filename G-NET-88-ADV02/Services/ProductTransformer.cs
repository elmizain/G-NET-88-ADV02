using ShopMaster.Models;

namespace ShopMaster.Services
{
    public class ProductTransformer
    {
        public List<Product> TransformProducts(
            List<Product> products,
            Func<Product, Product> transformer)
        {
            List<Product> results = new List<Product>();

            foreach (Product product in products)
            {
                results.Add(transformer(product));
            }

            return results;
        }
    }
}