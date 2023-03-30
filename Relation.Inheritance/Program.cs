namespace Jarai.CSharp.Objektorientierung2.Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ikeaFrankfurt = new Ikea("Frankfurt");
            var ikeaStuttgart = new Ikea("Stuttgart");

            try
            {
                var meinMöbel = ikeaFrankfurt.Verkaufen();

                if (meinMöbel != null)
                {
                    // meinMöbel.Benutzen(); // Exception: Nicht montiert!
                    meinMöbel.Montieren();
                    meinMöbel.Benutzen();
                }
            }
            catch (MoebelNichtMontiertException e)
            {
                Console.WriteLine("Bitte das Möbel vor der Benutzung montieren: " + e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Houston, wir haben ein Problem: " + e.Message);
            }

            ikeaFrankfurt.Show();
        }
    }
}
