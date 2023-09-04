using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jarai.CSharp.Calculator.UserInterface.Wpf
{
    public class AddCommandHandler : System.Windows.Input.ICommand
    {
        public ViewModels.MainWindowViewModel MainWindowViewModel
        {
            get => default;
            set
            {
            }
        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        public event EventHandler CanExecuteChanged;
    }
}
