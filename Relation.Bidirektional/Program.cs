namespace Jarai.CSharp.Relation.Bidirectional
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var p1 = new Person("Fritz", "Meier");
            var p2 = new Person("Susi", "Sorglos");

            // nicht verheiratet
            p1.Anzeigen();
            p2.Anzeigen();

            p1.Heiraten(p2);
            p1.Anzeigen();
            p2.Anzeigen();

            p2.Trennen();
            p1.Anzeigen();
            p2.Anzeigen();

            /* Ausgabe
  
        Guten Tag ich heisse Fritz Meier und bin ledig.
        Guten Tag ich heisse Susi Sorglos und bin ledig.
  
        Guten Tag ich heisse Fritz Meier und bin verheiratet mit Susi Meier
        Guten Tag ich heisse Susi Meier (geburtsname Sorglos) und bin verheiratet mit Fritz Meier
              
        Guten Tag ich heisse Fritz Meier und bin geschieden.
        Guten Tag ich heisse Susi Sorglos und bin geschieden.
        */
        }
    }
}
