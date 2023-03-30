namespace Jarai.CSharp.Objektorientierung4.Bidirectional
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var p1 = new Person("Fritz", "Meier");
            var p2 = new Person("Susi", "Sorglos");

            // nicht verheiratet
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            p1.Heiraten(p2);
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            p2.Trennen();
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            /* Ausgabe
  
            Guten Tag ich heisse Fritz Meier und bin ledig.
            Guten Tag ich heisse Susi Sorglos und bin ledig.
      
            Guten Tag ich heisse Fritz Meier und bin verheiratet mit Susi Meier
            Guten Tag ich heisse Susi Meier (geburtsname Sorglos) und bin verheiratet mit Fritz Meier
                  
            Guten Tag ich heisse Fritz Meier und bin geschieden.
            Guten Tag ich heisse Susi Sorglos und bin geschieden.
            
             */

            Console.ReadLine();
        }
    }
}
