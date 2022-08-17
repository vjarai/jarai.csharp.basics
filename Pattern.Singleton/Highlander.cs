namespace Jarai.Pattern.Singleton
{
    internal class Highlander
    {
        private static Highlander _instance;

        private Highlander()
        {
        }

        public static Highlander GetInstance()
        {
            return _instance ?? (_instance = new Highlander());
        }
    }
}
