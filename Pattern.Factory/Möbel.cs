namespace Pattern.Factory
{
    public abstract class Möbel
    {
        public Möbel(decimal preis)
        {
            Preis = preis;
        }


        public decimal Preis { get; set; }

        public abstract void Montieren();

        public abstract void Benutzen();
    }
}
