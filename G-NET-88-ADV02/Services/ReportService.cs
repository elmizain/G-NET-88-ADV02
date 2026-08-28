using ShopMaster.Models;

namespace ShopMaster.Services
{
    public class ReportService
    {
        public void PrintReport(List<Product> products, Action<Product> printer)
        {
            foreach (Product product in products)
            {
                printer(product);
            }
        }
    }
}