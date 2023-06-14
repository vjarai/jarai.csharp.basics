namespace Jarai.CSharp.Pattern.Singleton
{
    internal class Präsident
    {
        private static Präsident _instance;

        private Präsident()
        {
            Console.WriteLine("Praesident Lincoln geboren.");
        }

        public static Präsident GetInstance()
        {
            
            if (_instance == null)
            {
                _instance = new Präsident();
            }

            return _instance ;
        }
    }
}
