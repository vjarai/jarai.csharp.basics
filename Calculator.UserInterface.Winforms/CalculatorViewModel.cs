using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Jarai.CSharp.Calculator.UserInterface.WinForms
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private double _ergebnis;
        private double _zahl1;
        private double _zahl2;

        public double Ergebnis
        {
            get
            {
                return _ergebnis;
            }
            set
            {
                if (value.Equals(_ergebnis))
                {
                    return;
                }

                _ergebnis = value;
                OnPropertyChanged();
            }
        }

        public double Zahl1
        {
            get
            {
                return _zahl1;
            }
            set
            {
                if (value.Equals(_zahl1))
                {
                    return;
                }

                _zahl1 = value;
                OnPropertyChanged();
            }
        }

        public double Zahl2
        {
            get
            {
                return _zahl2;
            }
            set
            {
                if (value.Equals(_zahl2))
                {
                    return;
                }

                _zahl2 = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
