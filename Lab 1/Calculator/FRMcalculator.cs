using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Ernesto Murillo Lab 1  Advanced C# Calculator 
namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }
        // global variables
        string operationPressed;
        decimal firstNumber;
        decimal secondNumber;
        decimal newNumber;
        bool clicks = false;
      
        // equals button  =
        private void btnEquals_Click(object sender, EventArgs e)
        {
            {    // 2nd number verification check as well
                // Repeat action if Equal is clicked more than once or if number is clicked and operation is clicked with equals
                try
                {
                  //secondNumber = Convert.ToDecimal(txtDisplay.Text);
                    if (clicks == false) //if nothing is clicked
                    {

                        secondNumber = Convert.ToDecimal(txtDisplay.Text);
                        if (secondNumber == 0 && operationPressed == "/")
                        {
                            MessageBox.Show("Cannot Divide by Zero", "Error");
                            
                            secondNumber = 0;
                            txtDisplay.Text = "";
                        }
                        else 
                        {
                            clicks = true;   
                            secondNumber = Convert.ToDecimal(txtDisplay.Text);
                            Calculator newCalc = new Calculator(firstNumber, secondNumber, operationPressed);
                            newCalc.Equals();
                            txtDisplay.Text = newCalc.GetDisplayText();
                        }
                    }
                    else 
                    {
                        if (secondNumber == 0 && operationPressed == "/")
                        {
                            MessageBox.Show("Cannot divide by Zero", "Error");
                            firstNumber = 0;
                            secondNumber = 0;
                            txtDisplay.Text = "";
                        }
                        else
                        {
                            newNumber = Convert.ToDecimal(txtDisplay.Text);
                            Calculator newCalc = new Calculator(newNumber, secondNumber, operationPressed);
                            newCalc.Equals();
                            txtDisplay.Text = newCalc.GetDisplayText();
                        }
                    }
               }
                catch (FormatException)
                {
                    MessageBox.Show("Please Enter A Value", "Format Error");
                }
            }
        }
        
        // clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();  // when Clear button is pressed clear it
            firstNumber = 0;  //reset it
            secondNumber = 0; //reset it
            newNumber = 0; //reset it
            clicks = false;  
            txtDisplay.Text = "0";  //make it zero again
        }

        // back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            string str;
            int loc;
            if (txtDisplay.Text.Length > 0)
            {
                str = txtDisplay.Text.Substring(txtDisplay.Text.Length - 1);
                loc = txtDisplay.Text.Length;
                txtDisplay.Text = txtDisplay.Text.Remove(loc - 1, 1);
            }
        }

        // add button +
        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNumber = Decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            operationPressed = "+";
        }

        // subtract button  -
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            firstNumber = Decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            operationPressed = "-";
        }

        // multiply button  *
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = Decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            operationPressed = "*";
        }

        // divide button /
        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstNumber = Decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            operationPressed = "/";
        }

        // square root button  sqrt 
        private void btnSQRT_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDisplay.Text != "0" || txtDisplay.Text != "")  // if it isnt 0 or blank, record it 
                {
                    firstNumber = Decimal.Parse(txtDisplay.Text);
                    operationPressed = "sqrt";
                    if (firstNumber > 0)  // if it is not a negative number, do sqrt
                    {
                        Calculator newCalc = new Calculator(firstNumber, operationPressed);
                        firstNumber = Decimal.Parse(txtDisplay.Text);
                        newCalc.Equals();
                        txtDisplay.Text = newCalc.GetDisplayText();
                    }
                }
            }
            catch (FormatException)    //if number is pressed and operator is pressed +, -, *, / and then sqrt is pressed
            {
                MessageBox.Show("Cannot sqrt after operator pressed, Enter A Value and start over", "Format Error");
            }

            try
            {
                if (firstNumber < 0)  // if it is a negative number... 
                {
                    Calculator newCalc = new Calculator(firstNumber, operationPressed);
                    firstNumber = Decimal.Parse(txtDisplay.Text);
                    newCalc.Equals();
                    txtDisplay.Text = newCalc.GetDisplayText();
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("You cannot SQRT a negative number", "Format Error");
            }
        }

        // button change sign +/-
        private void btnChangeSign_Click(object sender, EventArgs e)
        {


            decimal makeNegNum = Convert.ToDecimal(txtDisplay.Text);
            decimal timesNegOne = makeNegNum * (-1);
            txtDisplay.Text = timesNegOne.ToString();

        }


        // inverse button  1/X
        private void btnInverse_Click(object sender, EventArgs e)
        {
           if (txtDisplay.Text == "0" || txtDisplay.Text == "")  // if it is 0 or blank, error
            {
                MessageBox.Show("You cannot inverse by 0 or a blank entry. Please enter a value and start over", "Format Error");
            }
           else              // do inverse
                {
                    firstNumber = Decimal.Parse(txtDisplay.Text);
                    operationPressed = "1/X";
                    Calculator newCalc = new Calculator(firstNumber, operationPressed);
                    firstNumber = Decimal.Parse(txtDisplay.Text);
                    newCalc.Equals();
                    txtDisplay.Text = newCalc.GetDisplayText();
                }
          
        }

        // form load
        private void frmCalculator_Load(object sender, EventArgs e)
        {
            clicks = false;
            txtDisplay.Text = "0";
        }

        // created a generic event handler on events called btn_Click for all numeric buttons and decimal
        private void btn_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (clicks))  // if text is zero and clicks is true 
                txtDisplay.Clear();   // clear it

            clicks = false; // put back clicks to false 
            Button b = (Button)sender;  // takes param converts it from button for numbers and decimal

            if (b.Text == ".")  // b.text is the text from button  -  if it equals decimal
            {
                if (!txtDisplay.Text.Contains(".")) // if it does not contain decimal already
                    txtDisplay.Text = txtDisplay.Text + b.Text;  // add the decimal
            }
            else
                txtDisplay.Text = txtDisplay.Text + b.Text;  // add the decimal n that textbox plus whatever button is pressed
        }
    }
}
