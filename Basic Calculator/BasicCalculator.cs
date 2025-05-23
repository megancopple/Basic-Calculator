namespace Basic_Calculator
{
    public partial class BasicCalculatorForm : Form
    {
        public BasicCalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
                decimal operand2 = Convert.ToDecimal(txtOperand2.Text);
                string op = txtOperator.Text;

                decimal result = Calculate(operand1, op, operand2);
txtResult.Text = $" {Math.Round(result, 4)}";
            }
        }

        // VALIDATION METHODS
        private bool IsValidData()
        {
            return IsPresent(txtOperand1, "Operand 1") &&
                   IsPresent(txtOperand2, "Operand 2") &&
                   IsDecimal(txtOperand1, "Operand 1") &&
                   IsDecimal(txtOperand2, "Operand 2") &&
                   IsInRange(txtOperand1, "Operand 1") &&
                   IsInRange(txtOperand2, "Operand 2") &&
                   IsOperator(txtOperator, "Operator") &&
                   NoDivideByZero();
        }

        private bool IsPresent(TextBox txt, string name)
        {
            if (txt.Text.Trim() == "")
            {
                MessageBox.Show($"{name} is required.");
                txt.Focus();
                return false;
            }
            return true;
        }

        private bool IsDecimal(TextBox txt, string name)
        {
            if (!decimal.TryParse(txt.Text, out _))
            {
                MessageBox.Show($"{name} must be a valid number.");
                txt.Focus();
                return false;
            }
            return true;
        }

        private bool IsInRange(TextBox txt, string name)
        {
            decimal val = Convert.ToDecimal(txt.Text);
            if (val < 0 || val > 1000000)
            {
                MessageBox.Show($"{name} must be between 0 and 1,000,000.");
                txt.Focus();
                return false;
            }
            return true;
        }

        private bool IsOperator(TextBox txt, string name)
        {
            string[] validOps = { "+", "-", "*", "/" };
            if (!validOps.Contains(txt.Text.Trim()))
            {
                MessageBox.Show($"{name} must be one of: +, -, *, /");
                txt.Focus();
                return false;
            }
            return true;
        }

        private bool NoDivideByZero()
        {
            if (txtOperator.Text.Trim() == "/" && Convert.ToDecimal(txtOperand2.Text) == 0)
            {
                MessageBox.Show("Cannot divide by zero.");
                txtOperand2.Focus();
                return false;
            }
            return true;
        }

        // CALCULATION METHOD
        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            switch (operator1)
            {
                case "+": return operand1 + operand2;
                case "-": return operand1 - operand2;
                case "*": return operand1 * operand2;
                case "/": return operand2 != 0 ? operand1 / operand2 : 0;
                default: throw new InvalidOperationException("Invalid operator.");
            }
        }

    }
}

