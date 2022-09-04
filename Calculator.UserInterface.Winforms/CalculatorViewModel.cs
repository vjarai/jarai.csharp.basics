using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Jarai.CSharp.Calculator.UserInterface.WinForms
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private double _ergebnis;
        private double _zahl1;
        private double _zahl2;

        public void ReadView()
        {
           
        }

        public double Ergebnis
        {
            get => _ergebnis;
            set
            {
                if (value.Equals(_ergebnis)) return;
                _ergebnis = value;
                OnPropertyChanged();
            }
        }

        public double Zahl1
        {
            get => _zahl1;
            set
            {
                if (value.Equals(_zahl1)) return;
                _zahl1 = value;
                OnPropertyChanged();
            }
        }

        public double Zahl2
        {
            get => _zahl2;
            set
            {
                if (value.Equals(_zahl2)) return;
                _zahl2 = value;
                OnPropertyChanged();
            }
        }

        public void WriteView()
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
