using System;
using System.Windows.Forms;
using Jarai.Calculator.Logic;

namespace Jarai.Calculator.Gui.WinForms
{
    public partial class CalculatorForm : Form
    {
        private readonly CalculationService _tr = new CalculationService();


        public CalculatorForm()
        {
            InitializeComponent();
            _tr.ResultAvailable += tr_ResultAvailable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _tr.Operand1 = operand1TextBox.Text;
            _tr.Operand2 = operand2TextBox.Text;
            _tr.Addiere();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _tr.Operand1 = operand1TextBox.Text;
            _tr.Operand2 = operand2TextBox.Text;
            _tr.Subtrahiere();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _tr.Operand1 = operand1TextBox.Text;
            _tr.Operand2 = operand2TextBox.Text;
            _tr.Multipliziere();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _tr.Operand1 = operand1TextBox.Text;
            _tr.Operand2 = operand2TextBox.Text;
            try
            {
                _tr.Dividiere();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            _tr.Operand1 = operand1TextBox.Text;
            _tr.Operand2 = operand2TextBox.Text;
            _tr.BerechneAsync();
        }

        private void tr_ResultAvailable(object sender, EventArgs e)
        {
            ergebnisTextBox.Text = _tr.Ergebnis;
        }
    }
}
