using ShopMaster.Models;

namespace ShopMaster.Services
{
    public class ProductCatalog
    {
        private List<Product> products = new List<Product>();

        public ProductCatalog()
        {
            products.Add(new Product
            {
                Id = 1,
                Name = "Laptop",
                Category = "Electronics",
                Price = 1200,
                Stock = 10
            });

            products.Add(new Product
            {
                Id = 2,
                Name = "Phone",
                Category = "Electronics",
                Price = 800,
                Stock = 25
            });

            products.Add(new Product
            {
                Id = 3,
                Name = "T-Shirt",
                Category = "Clothing",
                Price = 30,
                Stock = 100
            });

            products.Add(new Product
            {
                Id = 4,
                Name = "Jeans",
                Category = "Clothing",
                Price = 60,
                Stock = 50
            });

            products.Add(new Product
            {
                Id = 5,
                Name = "Chocolate",
                Category = "Food",
                Price = 5,
                Stock = 200
            });

            products.Add(new Product
            {
                Id = 6,
                Name = "Coffee Beans",
                Category = "Food",
                Price = 15,
                Stock = 80
            });

            products.Add(new Product
            {
                Id = 7,
                Name = "C# Book",
                Category = "Books",
                Price = 45,
                Stock = 30
            });

            products.Add(new Product
            {
                Id = 8,
                Name = "Novel",
                Category = "Books",
                Price = 20,
                Stock = 60
            });

            products.Add(new Product
            {
                Id = 9,
                Name = "Headphones",
                Category = "Electronics",
                Price = 150,
                Stock = 40
            });
        }



        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public List<Product> GetAllProducts()
        {
            return products;
        }

        public List<Product> SearchProducts(Func<Product, bool> condition)
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
        public List<string> TransformProducts(Func<Product, string> transformer)
        {
            List<string> results = new List<string>();

            foreach (Product product in products)
            {
                results.Add(transformer(product));
            }

            return results;
        }
        public List<Product> FilterProducts(Func<Product, bool> condition)
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
        public void PrintReport()
        {
            Console.WriteLine("=== Product Report ===");

            foreach (Product product in products)
            {
                Console.WriteLine(
                    $"ID: {product.Id}, Name: {product.Name}, " +
                    $"Category: {product.Category}, Price: ${product.Price}, " +
                    $"Stock: {product.Stock}");
            }
        }
    }

}