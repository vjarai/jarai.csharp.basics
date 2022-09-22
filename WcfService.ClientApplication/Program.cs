using Jarai.CSharp.WcfService.ClientApplication.CalculationServiceReference;


namespace Jarai.CSharp.WcfService.ClientApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var client = new CalculationServiceClient();

            string result = client.GetData(10);

            client.Close();
        }
    }
}
