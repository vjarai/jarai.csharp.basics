using System;

namespace Jarai.CSharp.Relation.Inheritance
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

                // meinMöbel.Benutzen(); // Exception: Nicht montiert!
                meinMöbel.Montieren();
                meinMöbel.Benutzen();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            ikeaFrankfurt.Show();
        }
    }
}
