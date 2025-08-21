using System.Diagnostics;

namespace Jarai.CSharp.Objektorientierung1.Aggregation
{
    public class Motor
    {
        public Motor(int ps)
        {
            Ps = ps;
            Console.WriteLine("Motor gebaut");
        }

        public int Drehzahl { get; private set; }
        public int Ps { get; }

        public void Abstellen()
        {
            Drehzahl = 0;
            Console.WriteLine("Motor abgestellt");
        }

        public void Anlassen()
        {
            if (Drehzahl > 0)
            {
                Console.WriteLine("Autsch, Motor war schon an.");
            }
            else
            {
                Drehzahl = 1000;
                Console.WriteLine("Motor angelassen");
            }
        }

        public void Anzeigen()
        {
            Console.WriteLine(ToString());
        }


        public override string ToString()
        {
            return "PS: " + Ps;
        }
    }
}
