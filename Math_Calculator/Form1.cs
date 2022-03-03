namespace Math_Calculator
{
    public partial class mainForm : Form
    {
        // Required variables declared.
        string mathOperationSelected = ""; // Stores the math operation selected by the user.
        double firstNumber; // Stores the first number entered by the user.
        double secondNumber; // Stores the second number entered by the user.
        bool calculatorOn = false; // If 'true', calculator is ON.
        bool calculatorOff = false; // If 'true', calculator is OFF.

        public mainForm()
        {
            InitializeComponent();
        }

        // If 'btnOne' clicked, '1' is entered in the display.
        private void btnOne_Click(object sender, EventArgs e)
        {
            // Checks the state of the calculator. If it's 'OFF', user is asked to turned it 'ON'.
            if (calculatorOn == true && calculatorOff == false)
            {
                // Restricts the user from entering more than 8 numerals.
                if (txtDisplay.Text.Count() >= 8)
                {
                    MessageBox.Show("The maximum numerals that can be entered is 8");
                }
                else
                {
                    txtDisplay.Text += "1";
                }
            }
            // Message displayed to the user, if calculator is 'OFF'.
            else if (calculatorOff == true && calculatorOn == false)
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
            else
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
        }

        // If 'btnTwo' clicked, '2' is entered in the display.
        private void btnTwo_Click(object sender, EventArgs e)
        {
            // Checks the state of the calculator. If it's 'OFF', user is asked to turned it 'ON'.
            if (calculatorOn == true && calculatorOff == false)
            {
                // Restricts the user from entering more than 8 numerals.
                if (txtDisplay.Text.Count() >= 8)
                {
                    MessageBox.Show("The maximum numerals that can be entered is 8");
                }
                else
                {
                    txtDisplay.Text += "2";
                }
            }
            // Message displayed to the user, if calculator is 'OFF'.
            else if (calculatorOff == true && calculatorOn == false)
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
            else
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
        }

        // If 'btnThree' clicked, '3' is entered in the display.
        private void btnThree_Click(object sender, EventArgs e)
        {
            // Checks the state of the calculator. If it's 'OFF', user is asked to turned it 'ON'.
            if (calculatorOn == true && calculatorOff == false)
            {
                // Restricts the user from entering more than 8 numerals.
                if (txtDisplay.Text.Count() >= 8)
                {
                    MessageBox.Show("The maximum numerals that can be entered is 8");
                }
                else
                {
                    txtDisplay.Text += "3";
                }
            }
            // Message displayed to the user, if calculator is 'OFF'.
            else if (calculatorOff == true && calculatorOn == false)
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
            else
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
        }

        // If 'btnFour' clicked, '4' is entered in the display.
        private void btnFour_Click(object sender, EventArgs e)
        {
            // Checks the state of the calculator. If it's 'OFF', user is asked to turned it 'ON'.
            if (calculatorOn == true && calculatorOff == false)
            {
                // Restricts the user from entering more than 8 numerals.
                if (txtDisplay.Text.Count() >= 8)
                {
                    MessageBox.Show("The maximum numerals that can be entered is 8");
                }
                else
                {
                    txtDisplay.Text += "4";
                }
            }
            // Message displayed to the user, if calculator is 'OFF'.
            else if (calculatorOff == true && calculatorOn == false)
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
            else
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
        }

        // If 'btnFive' clicked, '5' is entered in the display.
        private void btnFive_Click(object sender, EventArgs e)
        {
            // Checks the state of the calculator. If it's 'OFF', user is asked to turned it 'ON'.
            if (calculatorOn == true && calculatorOff == false)
            {
                // Restricts the user from entering more than 8 numerals.
                if (txtDisplay.Text.Count() >= 8)
                {
                    MessageBox.Show("The maximum numerals that can be entered is 8");
                }
                else
                {
                    txtDisplay.Text += "5";
                }
            }
            // Message displayed to the user, if calculator is 'OFF'.
            else if (calculatorOff == true && calculatorOn == false)
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
            else
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
        }

        // If 'btnSix' clicked, '6' is entered in the display.
        private void btnSix_Click(object sender, EventArgs e)
        {
            // Checks the state of the calculator. If it's 'OFF', user is asked to turned it 'ON'.
            if (calculatorOn == true && calculatorOff == false)
            {
                // Restricts the user from entering more than 8 numerals.
                if (txtDisplay.Text.Count() >= 8)
                {
                    MessageBox.Show("The maximum numerals that can be entered is 8");
                }
                else
                {
                    txtDisplay.Text += "6";
                }
            }
            // Message displayed to the user, if calculator is 'OFF'.
            else if (calculatorOff == true && calculatorOn == false)
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
            else
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
        }

        // If 'btnSeven' clicked, '7' is entered in the display.
        private void btnSeven_Click(object sender, EventArgs e)
        {
            // Checks the state of the calculator. If it's 'OFF', user is asked to turned it 'ON'.
            if (calculatorOn == true && calculatorOff == false)
            {
                // Restricts the user from entering more than 8 numerals.
                if (txtDisplay.Text.Count() >= 8)
                {
                    MessageBox.Show("The maximum numerals that can be entered is 8");
                }
                else
                {
                    txtDisplay.Text += "7";
                }
            }
            // Message displayed to the user, if calculator is 'OFF'.
            else if (calculatorOff == true && calculatorOn == false)
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
            else
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
        }

        // If 'btnEight' clicked, '8' is entered in the display.
        private void btnEight_Click(object sender, EventArgs e)
        {
            // Checks the state of the calculator. If it's 'OFF', user is asked to turned it 'ON'.
            if (calculatorOn == true && calculatorOff == false)
            {
                // Restricts the user from entering more than 8 numerals.
                if (txtDisplay.Text.Count() >= 8)
                {
                    MessageBox.Show("The maximum numerals that can be entered is 8");
                }
                else
                {
                    txtDisplay.Text += "8";
                }
            }
            // Message displayed to the user, if calculator is 'OFF'.
            else if (calculatorOff == true && calculatorOn == false)
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
            else
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
        }

        // If 'btnNine' clicked, '9' is entered in the display.
        private void btnNine_Click(object sender, EventArgs e)
        {
            // Checks the state of the calculator. If it's 'OFF', user is asked to turned it 'ON'.
            if (calculatorOn == true && calculatorOff == false)
            {
                // Restricts the user from entering more than 8 numerals.
                if (txtDisplay.Text.Count() >= 8)
                {
                    MessageBox.Show("The maximum numerals that can be entered is 8");
                }
                else
                {
                    txtDisplay.Text += "9";
                }
            }
            // Message displayed to the user, if calculator is 'OFF'.
            else if (calculatorOff == true && calculatorOn == false)
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
            else
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
        }

        // If 'btnZero' clicked, '0' is entered in the display.
        private void btnZero_Click(object sender, EventArgs e)
        {
            // Checks the state of the calculator. If it's 'OFF', user is asked to turned it 'ON'.
            if (calculatorOn == true && calculatorOff == false)
            {
                // Restricts the user from entering more than 8 numerals.
                if (txtDisplay.Text.Count() >= 8)
                {
                    MessageBox.Show("The maximum numerals that can be entered is 8");
                }
                else
                {
                    txtDisplay.Text += "0";
                }
            }
            // Message displayed to the user, if calculator is 'OFF'.
            else if (calculatorOff == true && calculatorOn == false)
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
            else
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
        }

        // If 'btnDecimal' clicked, '.' is entered in the display.
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            // Checks the state of the calculator. If it's 'OFF', user is asked to turned it 'ON'.
            if (calculatorOn == true && calculatorOff == false)
            {
                // Restricts the user from entering more than 8 numerals.
                if (txtDisplay.Text.Count() >= 8)
                {
                    MessageBox.Show("The maximum numerals that can be entered is 8");
                }
                else
                {
                    txtDisplay.Text += ".";
                }
            }
            // Message displayed to the user, if calculator is 'OFF'.
            else if (calculatorOff == true && calculatorOn == false)
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
            else
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
        }

        // If 'btnClear' clicked, display textbox and mathOperationSelected variable is cleared.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            mathOperationSelected = "";
        }

        // 'btnAdd' clicked to select addition option.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Checks the state of the calculator. If it's 'OFF', user is asked to turned it 'ON'. 
            if (calculatorOn == true && calculatorOff == false)
            {
                // 'mathOperationSelected' filled with the operation selected.
                mathOperationSelected = "+";
                // String entered in display textbox is converted to a double and stored in 'firstNumber'.
                firstNumber = double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
            }
            // Message displayed to the user, if calculator is 'OFF'.
            else if (calculatorOff == true && calculatorOn == false)
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
            else
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
        }

        // 'btnSubstract' clicked to select substraction option.
        private void btnSubstract_Click(object sender, EventArgs e)
        {
            // Checks the state of the calculator. If it's 'OFF', user is asked to turned it 'ON'.
            if (calculatorOn == true && calculatorOff == false)
            {
                // 'mathOperationSelected' filled with the operation selected.
                mathOperationSelected = "-";
                // String entered in display textbox is converted to a double and stored in 'firstNumber'.
                firstNumber = double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
            }
            // Message displayed to the user, if calculator is 'OFF'.
            else if (calculatorOff == true && calculatorOn == false)
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
            else
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
        }

        // 'btnMultiply' clicked to select multiplication option.
        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            // Checks the state of the calculator. If it's 'OFF', user is asked to turned it 'ON'.
            if (calculatorOn == true && calculatorOff == false)
            {
                // 'mathOperationSelected' filled with the operation selected.
                mathOperationSelected = "*";
                // String entered in display textbox is converted to a double and stored in 'firstNumber'.
                firstNumber = double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
            }
            // Message displayed to the user, if calculator is 'OFF'.
            else if (calculatorOff == true && calculatorOn == false)
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
            else
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
        }

        // 'btnDivide' clicked to select division option.
        private void btnDivide_Click(object sender, EventArgs e)
        {
            // Checks the state of the calculator. If it's 'OFF', user is asked to turned it 'ON'.
            if (calculatorOn == true && calculatorOff == false)
            {
                // 'mathOperationSelected' filled with the operation selected.
                mathOperationSelected = "/";
                // String entered in display textbox is converted to a double and stored in 'firstNumber'.
                firstNumber = double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
            }
            // Message displayed to the user, if calculator is 'OFF'.
            else if (calculatorOff == true && calculatorOn == false)
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
            else
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
        }

        // 'btnPlusMinusSymbol' clicked to select positivity/negativity of a number.
        private void btnPlusMinusSymbol_Click(object sender, EventArgs e)
        {
            // Checks the state of the calculator. If it's 'OFF', user is asked to turned it 'ON'.
            if (calculatorOn == true && calculatorOff == false)
            {
                // If display textbox is empty, user is asked to first enter a number.
                if (txtDisplay.Text == "")
                {
                    MessageBox.Show("Please enter a number to change its symbol to + or -");
                }
                else
                {
                    double userInput = Convert.ToDouble(txtDisplay.Text);
                    txtDisplay.Text = Convert.ToString(userInput * (-1));
                }
            }
            // Message displayed to the user, if calculator is 'OFF'.
            else if (calculatorOff == true && calculatorOn == false)
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
            else
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
        }

        // 'btnCalculate' is clicked to compute the equation entered by the user.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Checks the state of the calculator. If it's 'OFF', user is asked to turned it 'ON'.
            if (calculatorOn == true && calculatorOff == false)
            {
                // If display textbox is empty, message displayed to the user to write a complete equation.
                if (txtDisplay.Text == "")
                {
                    MessageBox.Show("Please enter a complete equation to compute its result");
                }
                else
                {
                    // String entered in display textbox is converted to a double and stored in 'secondNumber'.
                    secondNumber = double.Parse(txtDisplay.Text);
                    double result; // Stores the calculated answer.

                    // Switch statement used to decide which equation is needed to be applied.
                    switch (mathOperationSelected)
                    {
                        // If '+' selected, both numbers entered are added.
                        case "+":
                            result = (firstNumber + secondNumber);
                            // Formats the calculated answer to show a comma every 3 numbers from the decimal point.
                            txtDisplay.Text = string.Format("{0:n}", result);
                            break;
                        // If '-' selected, both numbers entered are added.
                        case "-":
                            result = (firstNumber - secondNumber);
                            // Formats the calculated answer to show a comma every 3 numbers from the decimal point.
                            txtDisplay.Text = string.Format("{0:n}", result);
                            break;
                        // If '*' selected, both numbers entered are added.
                        case "*":
                            result = (firstNumber * secondNumber);
                            // Formats the calculated answer to show a comma every 3 numbers from the decimal point.
                            txtDisplay.Text = string.Format("{0:n}", result);
                            break;
                        // If '/' selected, both numbers entered are added.
                        case "/":
                            result = (firstNumber / secondNumber);
                            // Formats the calculated answer to show a comma every 3 numbers from the decimal point.
                            txtDisplay.Text = string.Format("{0:n}", result);
                            break;
                        default:
                            break;
                    }
                }
            }
            // If calculator is 'OFF', user is asked to turn the calculator is 'ON'.
            else if (calculatorOff == true && calculatorOn == false)
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
            else
            {
                MessageBox.Show("Please click the 'ON' button to use the calculator");
            }
        }

        // If 'btnOn' is clicked, calculator is turned 'ON'.
        private void btnOn_Click(object sender, EventArgs e)
        {
            calculatorOn = true;
            calculatorOff = false;
        }

        // If 'btnOff' is clicked, calculator is turned 'OFF'.
        private void btnOff_Click(object sender, EventArgs e)
        {
            calculatorOff = true;
            calculatorOn = false;
            txtDisplay.Text = "";
        }
    }
}