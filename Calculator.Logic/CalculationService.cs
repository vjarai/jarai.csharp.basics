using System;
using System.Threading;
using System.Threading.Tasks;

namespace Jarai.Calculator.Logic
{
    public class CalculationService
    {
        private double _ergebnis;
        private double _operand1;
        private double _operand2;

        public string Ergebnis => _ergebnis.ToString();

        public string Operand1
        {
            get => _operand1.ToString();
            set => _operand1 = Convert.ToDouble(value);
        }

        public string Operand2
        {
            get => _operand2.ToString();
            set => _operand2 = Convert.ToDouble(value);
        }

        public void Addiere()
        {
            SetErgebnis(_operand1 + _operand2);
        }

        public Task<double> BerechneAsync()
        {
            return new Task<double>(AddiereFunc);
        }

        public void Dividiere()
        {
            if (_operand2 == 0)
            {
                throw new Exception("Division durch 0!");
            }

            SetErgebnis(_operand1 / _operand2);
        }

        public void Multipliziere()
        {
            SetErgebnis(_operand1 * _operand2);
        }


        public double Multiply(double factor1, double factor2)
        {
            return factor1 * factor2;
        }

        public void Subtrahiere()
        {
            SetErgebnis(_operand1 - _operand2);
        }

        public event EventHandler ResultAvailable;

        private double AddiereFunc()
        {
            Thread.Sleep(1000);
            return _operand1 + _operand2;
        }

        private void SetErgebnis(double e)
        {
            _ergebnis = e;

            if (ResultAvailable != null)
            {
                ResultAvailable(this, null);
            }
        }
    }
}
