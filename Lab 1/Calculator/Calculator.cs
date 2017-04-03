using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Ernesto Murillo Lab 1  C# Calculator class 
namespace Calculator
{
    public class Calculator       // class name
    {
        // fields
        private string operationPressed;    // + - * /  sqrt  1/X 
        private decimal firstNumber;  
        private decimal secondNumber; 
        private decimal answerNumber;  // store answer of operation of first number and second number

        // default empty constructor
        public Calculator()
        { }

        // custom constructor
        public Calculator(decimal firstNumber, string operation)
        {
            this.FirstNumber = firstNumber;
            this.OpPressed = operation;
        }

        // custom constructor
        public Calculator(decimal firstNumber, decimal secondNumber, string operation)
        {
            this.OpPressed = operation;
            this.FirstNumber = firstNumber;
            this.SecondNumber = secondNumber;
        }

        // OpPressed property procedure
        public string OpPressed
        {
            get
            {
                return operationPressed;
            }
            set
            {
                operationPressed = value;
            }
        }

        // FirstNumber property procedure
        public decimal FirstNumber
        {
            get
            {
                return firstNumber;
            }
            set
            {
                firstNumber = value;
            }
        }

        // SecondNumber property procedure
        public decimal SecondNumber
        {
            get
            {
                return secondNumber;
            }
            set
            {
                secondNumber = value;
            }
        }

        // AnswerNumber property procedure
        public decimal AnswerNumber
        {
            get
            {
                return answerNumber;
            }
            set
            {
                answerNumber = value;
            }
        }

        // Equals method
        public void Equals()
        {
        
            if (operationPressed == "+")
            {
                answerNumber = firstNumber + secondNumber;
                
            }
            else if (operationPressed == "-")
            {
                answerNumber = firstNumber - secondNumber;
            }
            else if (operationPressed == "*")
            {
                answerNumber = firstNumber * secondNumber;
            }
            else if (operationPressed == "/")
            {
                answerNumber = firstNumber / secondNumber;
            }
            else if (operationPressed == "sqrt")
            {
                double var = Math.Sqrt(Convert.ToDouble(firstNumber));
                answerNumber = Convert.ToDecimal(var);
            }
            else if (operationPressed == "1/X")
            {
                answerNumber = 1 / firstNumber;
            }
            else
            {
                answerNumber = secondNumber;
            }

        }

        // GetDisplayText method
        public string GetDisplayText()
        {
            return answerNumber.ToString();
        }



    }
}







































