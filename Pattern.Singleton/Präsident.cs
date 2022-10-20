namespace Jarai.CSharp.Pattern.Singleton
{
    internal class Präsident
    {
        private static Präsident? _instance;

        private Präsident()
        {
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
