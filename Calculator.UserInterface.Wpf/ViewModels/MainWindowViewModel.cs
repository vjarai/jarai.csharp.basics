using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Jarai.CSharp.Calculator.Logic.Model;

namespace Jarai.CSharp.Calculator.UserInterface.Wpf.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly CalculationService _calculationService;
        private double _ergebnis;
        private double _zahl1;
        private double _zahl2;

        public MainWindowViewModel(CalculationService calculationService)
        {
            _calculationService = calculationService;

            AddCommand = new DelegateCommand(_ => Add());
            SubtractCommand = new DelegateCommand(_ => Subtract());
            MultiplyCommand = new DelegateCommand(_ => Multiply());
            DivideCommand = new DelegateCommand(_ => Divide());
        }

        public ICommand AddCommand { get; set; }

        public ICommand DivideCommand { get; }

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

        public ICommand MultiplyCommand { get; }

        public ICommand SubtractCommand { get; set; }

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

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private void Add()
        {
            Ergebnis = _calculationService.Add(Zahl1, Zahl2);
        }

        private void Divide()
        {
            try
            {
                Ergebnis = _calculationService.Divide(Zahl1, Zahl2);
            }
            catch (InvalidOperationException e) // Division durch 0?
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Multiply()
        {
            Ergebnis = _calculationService.Multiply(Zahl1, Zahl2);
        }

        private void Subtract()
        {
            Ergebnis = _calculationService.Subtract(Zahl1, Zahl2);

        }
    }
}
