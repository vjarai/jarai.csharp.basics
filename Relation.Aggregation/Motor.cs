using System.Diagnostics;

namespace Jarai.CSharp.Objektorientierung1.Aggregation
{
    public class Motor
    {
        public Motor(int ps)
        {
            Ps = ps;
            Debug.WriteLine("Motor gebaut");
        }

        public int Drehzahl { get; private set; }
        public int Ps { get; }

        public void Abstellen()
        {
            Drehzahl = 0;
            Debug.WriteLine("Motor abgestellt");
        }

        public void Anlassen()
        {
            if (Drehzahl > 0)
            {
                Debug.WriteLine("Autsch, Motor war schon an.");
            }
            else
            {
                Drehzahl = 1000;
                Debug.WriteLine("Motor angelassen");
            }
        }

        public void Anzeigen()
        {
            Debug.WriteLine(ToString());
        }


        public override string ToString()
        {
            return "PS: " + Ps;
        }
    }
}
