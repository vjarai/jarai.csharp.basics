using System.Diagnostics;

namespace Jarai.Relation.Aggregation
{
    public class Motor
    {
        private readonly int _ps;
        private int _drehzahl;

        public Motor(int ps)
        {
            _ps = ps;
            Debug.WriteLine("Motor gebaut");
        }

        public void Abstellen()
        {
            _drehzahl = 0;
            Debug.WriteLine("Motor abgestellt");
        }

        public void Anlassen()
        {
            if (_drehzahl > 0)
            {
                Debug.WriteLine("Autsch, Motor war schon an.");
            }
            else
            {
                _drehzahl = 1000;
                Debug.WriteLine("Motor angelassen");
            }
        }

        public void Anzeigen()
        {
            Debug.WriteLine(ToString());
        }


        public override string ToString()
        {
            return "PS: " + _ps;
        }

        ~Motor()
        {
            Debug.WriteLine("Motor von Garbage Kollektion abgeräumt.");
        }
    }
}
