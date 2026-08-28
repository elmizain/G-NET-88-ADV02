using ShopMaster.Models;
using ShopMaster.Services;

ProductCatalog catalog = new ProductCatalog();

Console.WriteLine("=== ShopMaster Product Catalog ===");
Console.WriteLine();

Console.WriteLine("All Products:");
foreach (Product product in catalog.GetAllProducts())
{
    Console.WriteLine(
        $"ID: {product.Id}, Name: {product.Name}, " +
        $"Category: {product.Category}, Price: ${product.Price}, " +
        $"Stock: {product.Stock}");
}
Console.WriteLine();
catalog.PrintReport();
Console.WriteLine();
 Console.WriteLine("--- Electronics ---");

List<Product> electronics = catalog.SearchProducts(
    product => product.Category == "Electronics"
);

foreach (Product product in electronics)
{
    Console.WriteLine(
        $"{product.Name} - ${product.Price} (Stock: {product.Stock})");
}

Console.WriteLine();
Console.WriteLine("--- Under $50 ---");

List<Product> under50 = catalog.SearchProducts(
    product => product.Price < 50
);

foreach (Product product in under50)
{
    Console.WriteLine(
        $"{product.Name} - ${product.Price} (Stock: {product.Stock})");
}

Console.WriteLine();
Console.WriteLine("--- Transform Products ---");

List<string> productNames = catalog.TransformProducts(
    product => product.Name
);

foreach (string name in productNames)
{
    Console.WriteLine(name);
}

Console.WriteLine();
Console.WriteLine("--- Filter Products ---");

List<Product> filteredProducts = catalog.FilterProducts(
    product => product.Stock > 50
);

foreach (Product product in filteredProducts)
{
    Console.WriteLine(
        $"{product.Name} - ${product.Price} (Stock: {product.Stock})");
}
