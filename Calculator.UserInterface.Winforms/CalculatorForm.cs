using Jarai.CSharp.Calculator.Logic.Model;

namespace Jarai.CSharp.Calculator.UserInterface.WinForms
{
    public partial class CalculatorForm : Form
    {
        private readonly CalculationService _calculationService;
        private readonly CalculatorViewModel _viewModel;


        public CalculatorForm()
        {
            InitializeComponent();
           
            _calculationService = new CalculationService();
           _viewModel = new CalculatorViewModel();

            this.calculatorViewModelBindingSource.DataSource = _viewModel;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _viewModel.Ergebnis = _calculationService.Add(_viewModel.Zahl1, _viewModel.Zahl2);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            _viewModel.Ergebnis = _calculationService.Subtract(_viewModel.Zahl1, _viewModel.Zahl2);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            _viewModel.Ergebnis = _calculationService.Multiply(_viewModel.Zahl1, _viewModel.Zahl2);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            try
            {
                _viewModel.Ergebnis = _calculationService.Divide(_viewModel.Zahl1, _viewModel.Zahl2);
            }
            catch (InvalidOperationException ex)    // wg. Division durch 0
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
