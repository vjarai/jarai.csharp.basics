namespace Jarai.CSharp.Linq.YieldReturn
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dataGenerator = new DataGenerator();

            // Erzeugt erst ALLE Daten und benutzt davon nur die ersten 5
            var slowResult = dataGenerator.GenerateData(100).Take(5);

            // Erzeugt nur so viele Daten, wie tatsächlich weiterverarbeitet werden (5)
            var fastResult = dataGenerator.GenerateDataUsingYieldReturn(100).Take(5).ToList();

            Console.ReadLine();
        }
    }
}
