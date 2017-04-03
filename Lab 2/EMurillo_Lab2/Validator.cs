using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

// Ernesto Murillo Lab 2  - Validator class 

namespace EMurillo_Lab2
{
    public static class Validator   // Validator class
    {
        private static string title = "Entry Error";    // Title for errors

        public static string Title   // Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }


        // is present bool validation - to make sure entry is not blank
        public static bool IsPresent(TextBox textBox, Label label)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(label.Text + " is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }


        // is decimal bool validation - to make sure entry is a decimal
        public static bool IsDecimal(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value. Numbers Only.", Title);
                textBox.Focus();
                return false;
            }
        }


        // is within range decimal bool validation - to make sure decimal is within a certain min max # range
        public static bool IsWithinRange(TextBox textBox, decimal min, decimal max, Label label)
        {
            decimal number = Convert.ToDecimal(textBox.Text);

            if (number < min || number > max)
            {
                MessageBox.Show(label.Text + " value must be between " + min
                    + " and " + max + ". Decimal Numbers Only", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }


        // is not digits bool validation - to make sure string is all letters
        public static bool IsNotDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                {
                    MessageBox.Show("First or Last Names - letters only please.", Title);
                    return false;
                }
            }
            return true;
        }

        // is digits bool validation - to make sure string is all numbers ***ONLY for phone number
        public static bool IsDigits(string s)
        {
            foreach (char c in s)
            {   // also to make sure string is only 7, 10, 11 chars only for phone number - see formatPhoneNumber 
                if (!Char.IsDigit(c) || s.Count(Char.IsDigit) < 7 || s.Count(Char.IsDigit) == 8 || s.Count(Char.IsDigit) == 9)
                {
                    MessageBox.Show("Phone number must be 7, 10 or 11 digits please. Numbers only.", Title);
                    return false;
                }
            }
            return true;
        }

        //public static bool ValidPhone(string allDigit)
        //{
        //    foreach (char c in allDigit)
        //    {
        //        if (!char.IsDigit(c) || allDigit.Count(char.IsDigit) < 10)
        //            MessageBox.Show("Please enter a 10 digit phone number", "Phone Number Error");
        //        return false;
        //    }
        //    return true;
        //}



        // is valid date for dob validation  *** DOB only
        public static bool IsValidDate(TextBox textBox)
        {
            DateTime dob;
            DateTime dtUpperBoundary = DateTime.Today.AddDays(365 * -100);
            DateTime dtUpperBoundary1 = DateTime.Today.AddDays(365 * -16);

            if (!DateTime.TryParse(textBox.Text, out dob)) // if dob is not a date
            {
                MessageBox.Show("Invalid DOB. Please enter in format DD/MM/YYYY", Title);
                return false;
            }

            if (dob < dtUpperBoundary)   // if dob is less than 100 years old
            {
                MessageBox.Show("Invalid DOB.  You cannot be over 100 years old", Title);
                return false;
            }

            if (dob > dtUpperBoundary1)   // if dob is at least 16 years old
            {
                MessageBox.Show("Invalid DOB.  You cannot be younger than 16 years old", Title);
                return false;
            }

            if (dob >= DateTime.Today)   // if dob is todays date or greater than todays date
            {
                MessageBox.Show("Invalid DOB.  DOB cannot be today's date or greater than today's date", Title);
                return false;
            }

            else
            {
                return true;
            }
        }



        // is valid date for hire date validation
        public static bool IsValidDateHire(TextBox textBox)
        {
            DateTime hireDate;
            DateTime dtUpperBoundary1 = DateTime.Today.AddDays(365 * -5);  // 5 year mark 

            if (!DateTime.TryParse(textBox.Text, out hireDate)) // if hire date is not a date
            {
                MessageBox.Show("Invalid Hire Date. Please enter in format DD/MM/YYYY", Title);
                return false;
            }

            if (hireDate < dtUpperBoundary1)   // if hire date is greater than 5 years from todays date
            {
                MessageBox.Show("Invalid Hire Date. Cannot be more than than 5 years ago", Title);
                return false;
            }

            if (hireDate > DateTime.Today)   // if hire date is greater than todays date
            {
                MessageBox.Show("Invalid Hire Date. Cannot be more greater than todays date", Title);
                return false;
            }


            else
            {
                return true;
            }
        }

        // phone number formatting to display phone number correctly        
        public static string formatPhoneNumber(string phoneNum)
        {
            string phoneFormat = "";
            string numberString = "";
            int numberCount = 0;

            foreach (Char numberChar in phoneNum)
            {
                if (Char.IsNumber(numberChar))
                {
                    numberCount++;
                    numberString += numberChar.ToString();
                }
            }

            // First, remove everything except of numbers
            Regex regexObj = new Regex(@"[^\d]");
            phoneNum = regexObj.Replace(phoneNum, "");

            if (numberCount == 11)
            {
                phoneFormat = "#-###-###-####";
            }
            if (numberCount == 10)
            {
                phoneFormat = "(###) ###-####";
            }
            if (numberCount == 7)
            {
                phoneFormat = "###-####";
            }

            phoneNum = Convert.ToInt64(phoneNum).ToString(phoneFormat);
            return phoneNum;

        }

    }
}
