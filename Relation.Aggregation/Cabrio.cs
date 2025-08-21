using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Jarai.CSharp.Objektorientierung1.Aggregation
{
    public class Cabrio : Auto
    {
        private bool _verdeckIstOffen;

      
        public override  void Fahren(double strecke)
        {
            ÖffnenVerdeck();

            base.Fahren(strecke);

            SChliessenVerdeck();
        }

     
        public override void Anzeigen()
        {
            Console.WriteLine($"Verdeck ist offen {_verdeckIstOffen}");
            base.Anzeigen();
        }

        public void ÖffnenVerdeck()
        {
            _verdeckIstOffen = true;
            Console.WriteLine("Verdeck wurde geöffnet.");
        }

        public void SChliessenVerdeck()
        {
            _verdeckIstOffen = false;
            Console.WriteLine("Verdeck wurde geschlossen.");
        }
    }
}
