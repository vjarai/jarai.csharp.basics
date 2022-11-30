using System.Windows;
using Jarai.CSharp.Calculator.Logic;

namespace Jarai.CSharp.Calculator.UserInterface.Wpf
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
