using Jarai.CSharp.EntityFrameworkCore.DatabaseFirst.Model;

namespace Jarai.CSharp.EntityFrameworkCore.DatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                var x = db.Customers.ToArray();
            }
        }
    }
}
