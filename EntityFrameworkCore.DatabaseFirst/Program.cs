using Jarai.CSharp.EntityFrameworkCore.DatabaseFirst.Model;
using Microsoft.EntityFrameworkCore;

namespace Jarai.CSharp.EntityFrameworkCore.DatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {

                var products = db.Products.Include(x => x.Supplier)
                    .Where(x => x.ProductName.Contains("bier"))
                    .OrderByDescending(x => x.UnitPrice);

                foreach (var product in products)
                {
                    Console.WriteLine($"Product: {product.ProductName} vom Hersteller {product.Supplier.ContactName}");
                }

            }
        }
    }
}
