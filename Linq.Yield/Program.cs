using System;
using System.Linq;

namespace Jarai.CSharp.Linq.YieldReturn
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var datasource = new DataSource();

            //int slowResult = datasource.GenerateData(100).FirstOrDefault();
            var slowResult2 = datasource.GenerateData(100).Take(5);

            //int fastResult = datasource.GenerateDataUsingYieldReturn(100).FirstOrDefault();
            var fastResult2 = datasource.GenerateDataUsingYieldReturn(100).Take(5).ToList();

            Console.ReadLine();
        }
    }
}
