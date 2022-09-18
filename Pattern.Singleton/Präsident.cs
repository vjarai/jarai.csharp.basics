namespace Jarai.CSharp.Pattern.Singleton
{
    internal class Präsident
    {
        private static Präsident _instance;

        private Präsident()
        {
        }

        public static Präsident GetInstance()
        {
            return _instance ?? (_instance = new Präsident());
        }
    }
}
