using System.Linq;

namespace Jarai.CSharp.Linq.YieldReturn
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var datasource = new DataSource();

            int slowResult = datasource.GetValues(100).FirstOrDefault();
            var slowResult2 = datasource.GetValues(100).Take(5);

            int fastResult = datasource.GetValuesUsingYieldReturn(100).FirstOrDefault();
            var fastResult2 = datasource.GetValuesUsingYieldReturn(100).Take(5).ToList();
        }
    }
}
