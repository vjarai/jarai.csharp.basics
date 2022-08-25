using System.Windows;
using Jarai.Calculator.Logic;
using Jarai.Calculator.UserInterface.Wpf.ViewModels;

namespace Jarai.Calculator.UserInterface.Wpf.Views
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainWindowViewModel(new CalculationService());
            InitializeComponent();

        }

        public MainWindowViewModel ViewModel { get { return (MainWindowViewModel)DataContext; } }
    }
}
