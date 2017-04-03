using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Ernesto Murillo lab 5

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        // made variables global
        string displayString;
        decimal displayValue;
        bool newValue;
        bool decimalEntered;

        //updated 
        MemoryCalculator Calc = new MemoryCalculator();
       
        private void Form1_Load(object sender, System.EventArgs e)
        {
            displayValue = 0;
            displayString = "";
            newValue = true;
            decimalEntered = false;
        }

      
        private void btnNumber_Click(object sender, System.EventArgs e)
        {
            if (newValue)
            {
                displayString = "";
                newValue = false;
            }
            displayString += ((Button)sender).Tag.ToString();
            displayValue = Convert.ToDecimal(displayString);
            txtDisplay.Text = displayString;
        }


        private void btnBackSpace_Click(object sender, System.EventArgs e)
        {

            if (displayString.Length > 1)
            {
                displayString = displayString.Substring(0, displayString.Length - 1);
                displayValue = Convert.ToDecimal(displayString);
                txtDisplay.Text = displayString;
            }
            if (displayString.Length == 1)
            {
                displayValue = Convert.ToDecimal(Calc.CurrentValue);
                displayString = displayValue.ToString();
                txtDisplay.Text = displayString;
                txtDisplay.Text = "0";
                newValue = true;
            }

               
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            Calc.Clear();
            displayString = "";
            displayValue = 0;
            txtDisplay.Text = displayValue.ToString();
            newValue = true;
            decimalEntered = false;
        }

     
        private void btnDecimal_Click(object sender, System.EventArgs e)
        {

            if (!decimalEntered)
            {
                displayString += ".";
                displayValue = Convert.ToDecimal(displayString);
                txtDisplay.Text = displayString;
                decimalEntered = true;
            }
        }

        //corrected
        private void btnSign_Click(object sender, System.EventArgs e)
        {
            displayValue = (displayValue * -1);
            displayString = displayValue.ToString();
            txtDisplay.Text = displayValue.ToString();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            Calc.Add(displayValue);
            newValue = true;
            decimalEntered = false;
            displayValue = Convert.ToDecimal(Calc.CurrentValue);
            txtDisplay.Text = displayValue.ToString();
        }

        private void btnSubtract_Click(object sender, System.EventArgs e)
        {
            Calc.Subtract(displayValue);
            newValue = true;
            decimalEntered = false;
            displayValue = Convert.ToDecimal(Calc.CurrentValue);
            txtDisplay.Text = displayValue.ToString();
        }

        private void btnMultiply_Click(object sender, System.EventArgs e)
        {
            Calc.Multiply(displayValue);
            newValue = true;
            decimalEntered = false;
            displayValue = Convert.ToDecimal(Calc.CurrentValue);
            txtDisplay.Text = displayValue.ToString();
        }

        private void btnDivide_Click(object sender, System.EventArgs e)
        {
            Calc.Divide(displayValue);
            newValue = true;
            decimalEntered = false;
            displayValue = Convert.ToDecimal(Calc.CurrentValue); 
            txtDisplay.Text = displayValue.ToString();
        }

        private void btnSqrt_Click(object sender, System.EventArgs e)
        {
            Calc.SquareRoot(displayValue);
            displayValue = Convert.ToDecimal(Calc.CurrentValue); 
            txtDisplay.Text = displayValue.ToString();
        }

        private void btnReciprocal_Click(object sender, System.EventArgs e)
        {
            try
            {
                Calc.Reciprocal(displayValue);
                displayValue = Convert.ToDecimal(Calc.CurrentValue); 
                txtDisplay.Text = displayValue.ToString();
            }
            catch (DivideByZeroException)
            {
                displayValue = 0;
                MessageBox.Show("Cannot divide by zero", "Format Error");
                newValue = true;
                decimalEntered = false;
            }
        }

        private void btnEquals_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (newValue)
                {
                Calc.Equals(Calc.Operand2);
                displayValue = Calc.CurrentValue;
                txtDisplay.Text = displayValue.ToString();
                }
                else
                Calc.Equals(displayValue);
                displayValue = Convert.ToDecimal(Calc.CurrentValue);
                txtDisplay.Text = displayValue.ToString();
                newValue = true;
                decimalEntered = false;

            }
            catch (FormatException)    //if too many numbers are pressed
            {
                MessageBox.Show("Too many numbers", "Format Error");
            }
            catch (DivideByZeroException)    //if divide by zero
            {
                MessageBox.Show("Cannot divide by zero", "Format Error");
            }

        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            Calc.MemoryClear();
            btnM.Text = "";
            displayString = "";
            txtDisplay.Text = displayValue.ToString();
            newValue = true;
            decimalEntered = false;

        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            Calc.MemoryStore(displayValue);
            btnM.Text = "M";
        }

        private void btnMplus_Click(object sender, EventArgs e)
        {
            Calc.MemoryAdd(displayValue);


        }

        private void btnMR_Click(object sender, EventArgs e)
        {
           
                if (newValue)
                {
                displayString = "";
                newValue = false;
                }
            displayString = Calc.MemoryRecall().ToString();
            displayValue = Convert.ToDecimal(displayString);
            txtDisplay.Text = displayValue.ToString();
        }

  
       

     
    }
}